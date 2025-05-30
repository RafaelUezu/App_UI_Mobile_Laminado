using System;
using Microsoft.Maui.Controls;
using App_UI_Mobile_Laminado.MVVM.View.Pages.Operacao;
using App_UI_Mobile_Laminado.MVVM.View.Pages.Relatorios;
using App_UI_Mobile_Laminado.MVVM.View.Pages.ProgramacaoHoraria;
using App_UI_Mobile_Laminado.MVVM.View.Pages.Receitas;
using App_UI_Mobile_Laminado.MVVM.View.Pages.Manutencao;
using App_UI_Mobile_Laminado.MVVM.View.Pages.Login;
using App_UI_Mobile_Laminado.Services.db.Login;
using App_UI_Mobile_Laminado.MVVM.Model.Pages;

namespace App_UI_Mobile_Laminado
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();
            CriarMenuDinamico();
            // Rotas podem ser registradas aqui se forem navegáveis
            Routing.RegisterRoute(nameof(Page_Login_Inicial), typeof(Page_Login_Inicial));

        }

        private void Button_Logout_Clicked(object sender, EventArgs e)
        {
            Application.Current.MainPage = new Page_Login_Inicial();
        }

        private void CriarMenuDinamico()
        {
            int nivel = Preferences.Get("NivelAcesso", 0); // padrão: OPERADOR


            // Operação (todos têm acesso)
            var itemOperacao = new FlyoutItem
            {
                Title = "Operação",
                Icon = "factory.png",
                FlyoutDisplayOptions = FlyoutDisplayOptions.AsSingleItem
            };

            itemOperacao.Items.Add(new ShellContent
            {
                Title = "Operação Automática",
                Icon = "head_gear.png",
                ContentTemplate = new DataTemplate(typeof(Page_Operacao_Automatica)),
                Route = "Page_Operacao_Automatica"
            });

            itemOperacao.Items.Add(new ShellContent
            {
                Title = "Supervisão dos Tempos",
                Icon = "hour_glass.png",
                ContentTemplate = new DataTemplate(typeof(Page_Operacao_SupervisaodosTempos)),
                Route = "Page_Operacao_SupervisaodosTempos"
            });

            var itemRelatorios = new FlyoutItem
            {
                Title = "Relatórios",
                Icon = "statistics.png",
                FlyoutDisplayOptions = FlyoutDisplayOptions.AsSingleItem
            };

            itemRelatorios.Items.Add(new ShellContent
            {
                Title = "Histórico de Alarmes",
                Icon = "alarm.png",
                ContentTemplate = new DataTemplate(typeof(Page_Relatorios_Alarmes)),
                Route = "Page_Relatorios_Alarmes"
            });

            itemRelatorios.Items.Add(new ShellContent
            {
                Title = "Relatório de Energia",
                Icon = "electrical_place.png",
                ContentTemplate = new DataTemplate(typeof(Page_Relatorios_Energia)),
                Route = "Page_Relatorios_Energia"
            });

            itemRelatorios.Items.Add(new ShellContent
            {
                Title = "Relatório de Temperatura",
                Icon = "thermometer_place.png",
                ContentTemplate = new DataTemplate(typeof(Page_Relatorios_Temperatura)),
                Route = "Page_Relatorios_Temperatura"
            });

            Items.Add(itemOperacao);
            Items.Add(itemRelatorios);

            if (nivel >= (int)NivelAcesso.SUPERVISOR)
            {
                itemOperacao.Items.Add(new ShellContent
                {
                    Title = "Operação Manual",
                    Icon = "front_hand.png",
                    ContentTemplate = new DataTemplate(typeof(Page_Operacao_Manual)),
                    Route = "Page_Operacao_Manual"
                });

                Items.Add(itemOperacao);

                var itemReceitas = new FlyoutItem
                {
                    Title = "Receitas",
                    Icon = "lab_items.png",
                    FlyoutDisplayOptions = FlyoutDisplayOptions.AsSingleItem
                };

                itemReceitas.Items.Add(new ShellContent
                {
                    Title = "Edição de receitas",
                    Icon = "pen.png",
                    ContentTemplate = new DataTemplate(typeof(Page_Receitas_Edicao)),
                    Route = "Page_Receitas_Edicao"
                });

                Items.Add(itemReceitas);

                var itemProgramacaoHoraria = new FlyoutItem
                {
                    Title = "Programação Horária",
                    Icon = "alarm_clock.png",
                    FlyoutDisplayOptions = FlyoutDisplayOptions.AsSingleItem
                };

                itemProgramacaoHoraria.Items.Add(new ShellContent
                {
                    Title = "Programação Horária",
                    Icon = "alarm_clock.png",
                    ContentTemplate = new DataTemplate(typeof(Page_ProgramacaoHoraria)),
                    Route = "Page_ProgramacaoHoraria"
                });

                Items.Add(itemProgramacaoHoraria);
            }

            if (nivel >= (int)NivelAcesso.GERENTE)
            {

            }

            FlyoutItem itemManutencao = null;

            if (nivel >= (int)NivelAcesso.TECNICO)
            {
                itemManutencao = new FlyoutItem
                {
                    Title = "Manutenção",
                    Icon = "services.png",
                    FlyoutDisplayOptions = FlyoutDisplayOptions.AsSingleItem
                };

                itemManutencao.Items.Add(new ShellContent
                {
                    Title = "Referências",
                    Icon = "lighthouse.png",
                    ContentTemplate = new DataTemplate(typeof(Page_Manutencao_Referencias)),
                    Route = "Page_Manutencao_Referencias"
                });

                itemManutencao.Items.Add(new ShellContent
                {
                    Title = "Operação Manual",
                    Icon = "front_hand.png",
                    ContentTemplate = new DataTemplate(typeof(Page_Operacao_Manual)),
                    Route = "Page_Operacao_Manual"
                });

                itemManutencao.Items.Add(new ShellContent
                {
                    Title = "Supervisão das Entradas",
                    Icon = "antenna.png",
                    ContentTemplate = new DataTemplate(typeof(Page_Manutencao_Entradas)),
                    Route = "Page_Manutencao_Entradas"
                });

                itemManutencao.Items.Add(new ShellContent
                {
                    Title = "Supervisão das Saídas",
                    Icon = "screwdriver.png",
                    ContentTemplate = new DataTemplate(typeof(Page_Manutencao_Configuracao)),
                    Route = "Page_Manutencao_Configuracao"
                });
            }

            if (nivel >= (int)NivelAcesso.DEV && itemManutencao != null)
            {
                itemManutencao.Items.Add(new ShellContent
                {
                    Title = "Configuração Tablet",
                    Icon = "screwdriver.png",
                    ContentTemplate = new DataTemplate(typeof(Page_Manutencao_Configuracao)),
                    Route = "Page_Manutencao_Configuracao"
                });
            }

            if (itemManutencao != null)
                Items.Add(itemManutencao);
        }
    }
}
