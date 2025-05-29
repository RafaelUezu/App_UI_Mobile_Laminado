using System;
using Microsoft.Maui.Controls;
using App_UI_Mobile_Laminado.MVVM.View.Pages;
using App_UI_Mobile_Laminado.MVVM.View.Pages.Operacao;
using App_UI_Mobile_Laminado.MVVM.View.Pages.Login;

namespace App_UI_Mobile_Laminado
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();
            CriarMenuDinamico();
            // Rotas podem ser registradas aqui se forem naveg�veis
            Routing.RegisterRoute(nameof(Page_Login_Inicial), typeof(Page_Login_Inicial));

        }

        private void Button_Logout_Clicked(object sender, EventArgs e)
        {
            Application.Current.MainPage = new Page_Login_Inicial();
        }

        private void CriarMenuDinamico()
        {
            int nivel = Preferences.Get("NivelAcesso", 0); // padr�o: OPERADOR

            // Opera��o (todos t�m acesso)
            var itemOperacao = new FlyoutItem
            {
                Title = "Opera��o",
                Icon = "factory.png",
                FlyoutDisplayOptions = FlyoutDisplayOptions.AsSingleItem
            };

            itemOperacao.Items.Add(new ShellContent
            {
                Title = "Opera��o Autom�tica",
                Icon = "head_gear.png",
                ContentTemplate = new DataTemplate(typeof(Page_Operacao_Automatica)),
                Route = "Page_Operacao_Automatica"
            });

            itemOperacao.Items.Add(new ShellContent
            {
                Title = "Supervis�o dos Tempos",
                Icon = "hour_glass.png",
                ContentTemplate = new DataTemplate(typeof(Page_Operacao_SupervisaodosTempos)),
                Route = "Page_Operacao_SupervisaodosTempos"
            });

            itemOperacao.Items.Add(new ShellContent
            {
                Title = "Opera��o Manual",
                Icon = "front_hand.png",
                ContentTemplate = new DataTemplate(typeof(Page_Operacao_Manual)),
                Route = "Page_Operacao_Manual"
            });

            Items.Add(itemOperacao);



        }




    }
}
