using MAUI_Opcua.Services.Communication.Variable;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;
using MAUI_Opcua.Services.Drivers.Opcua;

namespace App_UI_Mobile_Laminado.Services.Alarms
{
    /// <summary>
    /// Representa um único sinal de alarme booleano, com detecção de bordas (0→1 / 1→0),
    /// registro de horários e suporte a reconhecimento (ACK).
    /// </summary>
    public sealed class AlarmInput
    {
        // --------- Identidade / metadados ---------

        /// <summary>Identificador único do alarme (estável para logs/servidor).</summary>
        public string Id { get; }
        /// <summary>Nome amigável para UI e relatórios.</summary>
        public string DisplayName { get; }
        /// <summary>Descrição do alarme.</summary>
        public string? Description { get; set; } = string.Empty;
        /// <summary>Localização física do dispositivo no panel.</summary>
        public string? Location_Panel { get; set; } = string.Empty;
        /// <summary>Localização física do dispositivo na máquina.</summary>
        public string? Location_Machine { get; set; } = string.Empty;
        /// <summary>Categoria do dispositivo.</summary>
        public CategoryLevel? Category { get; set; } = CategoryLevel.General;
        public enum CategoryLevel
        {
            General,
            Safety,
            Process,
            Communication,
            Power,
            Maintenance,
        }
        public SubCategoryLevel? SubCategory { get; set; } = SubCategoryLevel.Standard;
        public enum SubCategoryLevel
        {
            Standard,
            Movement,
            Positioning,
            Signaling,
        }
        public string? FunctionDescription { get; set; } = string.Empty;
        public string? RecommendedAction { get; set; } = string.Empty;
        public SeverityLevel? Severity { get; set; } = SeverityLevel.Medium;
        public enum SeverityLevel
        {
            Info,
            Warning,
            LowLow,
            Low,
            Medium,
            Hi,
            HiHi,
            Critical
        }
        // --------- Estado observável ---------
        /// <summary>Estado lógico atual (true = alarmado).</summary>
        public bool IsActive { get; private set; }
        /// <summary> Comando para insert no servidor (subida ou descida).</summary>
        public bool CommandSavedOnServer_Activated { get; private set; }
        /// <summary> Comando para update no servidor (subida ou descida).</summary>
        public bool CommandSavedOnServer_Desactivated { get; private set; }
        /// <summary> Comando para update no servidor (subida ou descida).</summary>
        public bool CommandSavedOnServer_Acknowed { get; private set; }
        /// <summary>Horário (UTC) da última transição (subida ou descida).</summary>
        public DateTimeOffset? LastChangeUtc { get; private set; }
        /// <summary>Horário (UTC) da última subida (0→1).</summary>
        public DateTimeOffset? LastActivatedUtc { get; private set; }
        /// <summary>Horário (UTC) da última descida (1→0).</summary>
        public DateTimeOffset? LastClearedUtc { get; private set; }
        /// <summary>Se o alarme ativo foi reconhecido por operador/sistema.</summary>
        public bool IsAcknowledged { get; private set; }
        /// <summary>Horário (UTC) do último reconhecimento (ACK).</summary>
        public DateTimeOffset? LastAcknowledgedUtc { get; private set; }
        /// <summary>Último erro de leitura (se houver). Não altera IsActive por si só.</summary>
        public Exception? LastReadError { get; private set; }
        // --------- Infra de leitura e memória interna ---------
        private readonly Func<CancellationToken, ValueTask<bool>> _readAsync;
        private bool? _lastRaw; // null => ainda não inicializado
        /// <summary>Resultado de transição após uma sondagem (poll).</summary>
        public enum Transition { None, Activated, Cleared }


        /// <summary>
        /// Cria um AlarmInput.
        /// </summary>
        /// <param name="id">Identificador único do alarme (ex.: "ALM_GERAL_1").</param>
        /// <param name="displayName">Nome amigável; se nulo/vazio, usa o id.</param>
        /// <param name="description">Descrição do ID</param>
        /// <param name="Location_Panel">Local no painel</param>
        /// <param name="Location_Machine">Local na máquina</param>
        /// <param name="category">Categoria do alarme</param>
        /// <param name="subCategory">Subcategoria do alarme</param>
        /// <param name="functionDescription">Descrição da função do alarme</param>
        /// <param name="recommended">Ação recomendada</param>
        /// <param name="readAsync">
        /// Função assíncrona que retorna o valor booleano atual (fonte: OPC UA, simulação, etc.).
        /// </param>
        public AlarmInput
        (
            string id,
            string? displayName,
            string? description,
            string? location_Panel,
            string? location_Machine,
            CategoryLevel? category,
            SubCategoryLevel? subCategory,
            string? functionDescription,
            string? recommended,
            Func<CancellationToken, ValueTask<bool>> readAsync
        )
        {
            if (string.IsNullOrWhiteSpace(id))
                throw new ArgumentException("Id não pode ser nulo ou vazio.", nameof(id));

            Id = id;
            DisplayName         = string.IsNullOrWhiteSpace(displayName) ? id : displayName;
            Description         = description ?? string.Empty;
            Location_Panel      = location_Panel ?? string.Empty;
            Location_Machine    = location_Machine ?? string.Empty;
            Category            = category ?? CategoryLevel.General;
            SubCategory         = subCategory ?? SubCategoryLevel.Standard;
            FunctionDescription = functionDescription ?? string.Empty;
            RecommendedAction   = recommended ?? string.Empty;
            _readAsync          = readAsync ?? throw new ArgumentNullException(nameof(readAsync));
        }


        /// <summary>
        /// Realiza uma leitura, atualiza estado interno e informa se houve transição.
        /// Chamar periodicamente a partir do motor (service/loop).
        /// </summary>
        public async ValueTask<Transition> PollAsync(CancellationToken ct)
        {
            try
            {
                LastReadError = null;

                bool current = await _readAsync(ct);

                // --- PRIMEIRA AMOSTRAGEM ---
                if (_lastRaw is null)
                {
                    _lastRaw = current;
                    IsActive = current;

                    if (current)
                    {
                        // Se já inicia ativo, considera como subida (0→1) no instante do start
                        var now = DateTimeOffset.UtcNow;
                        LastChangeUtc = now;
                        LastActivatedUtc = now;
                        IsAcknowledged = false;
                        CommandSavedOnServer_Activated = true;
                        LastAcknowledgedUtc = null;

                        return Transition.Activated;
                    }

                    // current == false: apenas inicializa sem gerar evento de "Cleared"
                    return Transition.None;
                }

                // --- DEMAIS AMOSTRAGENS (sem mudança aqui) ---
                if (current != _lastRaw.Value)
                {
                    _lastRaw = current;
                    IsActive = current;

                    var now = DateTimeOffset.UtcNow;
                    LastChangeUtc = now;

                    if (current)
                    {
                        CommandSavedOnServer_Activated = true;
                        LastActivatedUtc = now;
                        IsAcknowledged = false;
                        LastAcknowledgedUtc = null;
                        return Transition.Activated;
                    }
                    else
                    {
                        CommandSavedOnServer_Desactivated = true;
                        LastClearedUtc = now;
                        return Transition.Cleared;
                    }
                }

                return Transition.None;
            }
            catch (Exception ex)
            {
                LastReadError = ex;
                return Transition.None;
            }
        }

        /// <summary>
        /// Reconhece (ACK) o alarme se estiver ativo. Não muda IsActive.
        /// </summary>
        /// <param name="whenUtc">Opcionalmente, um horário (UTC) a registrar; se nulo, usa agora.</param>
        public void Acknowledge(DateTimeOffset? whenUtc = null)
        {
            if (IsActive)
            {
                CommandSavedOnServer_Acknowed = true;
                IsAcknowledged = true;
                LastAcknowledgedUtc = whenUtc ?? DateTimeOffset.UtcNow;
            }
        }
    }
}

