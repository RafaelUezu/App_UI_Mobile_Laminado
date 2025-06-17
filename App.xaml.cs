using MAUI_Opcua.Services.Drivers.Opcua;
using App_UI_Mobile_Laminado.MVVM.View.Pages;
using App_UI_Mobile_Laminado.MVVM.View.Pages.Login;
using App_UI_Mobile_Laminado.MVVM.View.Pages.Manutencao;
using System;
using System.Threading.Tasks;
using Microsoft.Maui.Controls;

namespace App_UI_Mobile_Laminado
{
    public partial class App : Application
    {
        private readonly Opcua_Client _driver;

        public App(Opcua_Client driver)
        {
            InitializeComponent();
            _driver = driver;
            _driver.Start(); // Inicia driver ao abrir o app
            //MainPage = new Page_Manutencao_Manual();
            //MainPage = new Page_Login_Inicial();
            MainPage = new AppShell();
        }

        protected override void OnSleep()
        {
            // Dispara async sem bloquear o ciclo de vida
            StopDriverAsync().FireAndForgetSafeAsync();
        }

        protected override void OnResume()
        {
            // Reativa driver ao retornar do fundo
            if (!_driver.IsRunning)
                _driver.Start();
        }

        private async Task StopDriverAsync()
        {
            try
            {
                await _driver.StopAsync();
            }
            catch (Exception ex)
            {
                // Logue se necessário
                System.Diagnostics.Debug.WriteLine($"Erro ao parar o driver: {ex.Message}");
            }
        }
    }

    // Extensão auxiliar para ignorar exceções de métodos async void
    public static class TaskExtensions
    {
        public static async void FireAndForgetSafeAsync(this Task task)
        {
            try
            {
                await task;
            }
            catch (Exception ex)
            {
                // Logue se necessário
                System.Diagnostics.Debug.WriteLine($"Exceção suprimida: {ex.Message}");
            }
        }
    }
}
