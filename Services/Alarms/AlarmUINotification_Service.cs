using App_UI_Mobile_Laminado.Services.Communication.Variables;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App_UI_Mobile_Laminado.Services.Alarms
{
    public sealed partial class AlarmUINotification : IAsyncDisposable
    {
        private readonly TimeSpan _period;
        private readonly ILogger<AlarmUINotification>? _logger;
        private readonly object _gate = new();

        private CancellationTokenSource? _cts;
        private Task? _backgroundTask;
        private int _consecutiveErrors;
        public AlarmUINotification(AlarmEngine alarmEngine, TimeSpan? period = null, ILogger<AlarmUINotification>? logger = null)
        {
            _period = period ?? TimeSpan.FromMilliseconds(1000); // ajuste conforme sua necessidade
            _logger = logger;
        }
        public bool IsRunning
        {
            get
            {
                var t = Volatile.Read(ref _backgroundTask);
                return t is not null && !t.IsCompleted;
            }
        }
        /// <summary>Task do loop, útil para testes/espera.</summary>
        public Task? Completion => Volatile.Read(ref _backgroundTask);
        public void Start()
        {
            lock (_gate)
            {
                if (IsRunning) return;
                _cts = new CancellationTokenSource();
                _backgroundTask = Task.Run(() => RunLoopAsync(_cts.Token));
            }
        }
        public async Task StopAsync(TimeSpan? timeout = null)
        {
            Task? toAwait;
            lock (_gate)
            {
                if (_backgroundTask is null)
                    return;

                try { _cts?.Cancel(); }
                catch { /* ignorar cancel repetido */ }

                toAwait = _backgroundTask;
            }
            try
            {
                if (toAwait is not null)
                {
                    if (timeout is { } t)
                        await Task.WhenAny(toAwait, Task.Delay(t));
                    else
                        await toAwait;
                }
            }
            finally
            {
                lock (_gate)
                {
                    _cts?.Dispose();
                    _cts = null;
                    _backgroundTask = null;
                }
            }
        }
        private async Task RunLoopAsync(CancellationToken ct)
        {
            using var timer = new PeriodicTimer(_period);

            while (await timer.WaitForNextTickAsync(ct))
            {
                try
                {
                    await DoWorkOnceAsync(ct).ConfigureAwait(false);
                    _consecutiveErrors = 0; // reset após sucesso
                }
                catch (OperationCanceledException) when (ct.IsCancellationRequested)
                {
                    // cancelamento normal
                    break;
                }
                catch (Exception ex)
                {
                    _logger?.LogError(ex, "[AlarmUINotification] erro de iteração");
                    // backoff exponencial limitado (250ms, 500ms, 1s, ... até 10s)
                    _consecutiveErrors = Math.Min(_consecutiveErrors + 1, 8);
                    var backoff = TimeSpan.FromMilliseconds(250 * (1 << Math.Min(_consecutiveErrors, 7)));
                    var capped = backoff > TimeSpan.FromSeconds(10) ? TimeSpan.FromSeconds(10) : backoff;

                    try { await Task.Delay(capped, ct).ConfigureAwait(false); }
                    catch (OperationCanceledException) { break; }
                }
            }
        }
        public async ValueTask DisposeAsync()
        {
            await StopAsync(TimeSpan.FromMilliseconds(1000));
        }
        private async Task DoWorkOnceAsync(CancellationToken ct)
        {

        }
    }
}
