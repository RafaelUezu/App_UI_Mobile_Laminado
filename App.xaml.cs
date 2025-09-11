using MAUI_Opcua.Services.Drivers.Opcua;
using App_UI_Mobile_Laminado.MVVM.View.Pages;
using App_UI_Mobile_Laminado.MVVM.View.Pages.Login;
using App_UI_Mobile_Laminado.MVVM.View.Pages.Manutencao;
using System;
using System.Threading.Tasks;
using Microsoft.Maui.Controls;
using App_UI_Mobile_Laminado.Services.db.db_ConfSuper;
using MAUI_Opcua.Services.Communication.Variable;
using App_UI_Mobile_Laminado.Services.StandartTests;

namespace App_UI_Mobile_Laminado
{
    public partial class App : Application
    {
        private readonly Opcua_Client _driver;
        private readonly StandartTests_Services _StandartTests;
        public static IServiceProvider Services { get; set; } = default!;
        public App(Opcua_Client driver, StandartTests_Services standartTests)
        {
            InitializeComponent();
            _ = InitializeAppAsync();
         
            _driver = driver;
            _StandartTests = standartTests;
            MainPage = new AppShell();


            // MainPage = new Page_Manutencao_Manual();
            // MainPage = new Page_Login_Inicial();
            _driver.Start(); // Inicia driver ao abrir o app
            _StandartTests.Start(); // Inicia testes padroes ao abrir o app
        }

        private async Task InitializeAppAsync()
        {
            await InicializarVariaveisPermanentes();
        }

        private async Task InicializarVariaveisPermanentes()
        {
            var _db_ConfSuper = new db_ConfSuper();
            await _db_ConfSuper.CopyFromPackageIfNotExistsAsync();
            ConfSuperConfig confSuperConfig = await _db_ConfSuper.LoadConfigAsync();
            GVL.ConfSuper.sUrlOpcUa.ReadWrite = confSuperConfig.sUrlOpcUa;
            GVL.ConfSuper.iTimeOutPing.ReadWrite = confSuperConfig.iTimeOutPing;
            GVL.ConfSuper.iTimeRequest.ReadWrite = confSuperConfig.iTimeRequest;
            GVL.ConfSuper.iMaxAgeOpcUa.ReadWrite = confSuperConfig.iMaxAgeOpcUa;
            GVL.ConfSuper.iMedAgeOpcUa.ReadWrite = confSuperConfig.iMedAgeOpcUa;
            GVL.ConfSuper.iMinAgeOpcUa.ReadWrite = confSuperConfig.iMinAgeOpcUa;
            GVL.ConfSuper.iZeroAgeOpcUa.ReadWrite = confSuperConfig.iZeroAgeOpcUa;
            GVL.ConfSuper.iMaxTempRecipe.ReadWrite = confSuperConfig.iMaxTempRecipe;
            GVL.ConfSuper.iMinTempRecipe.ReadWrite = confSuperConfig.iMinTempRecipe;
            GVL.ConfSuper.iMaxTempOperation.ReadWrite = confSuperConfig.iMaxTempOperation;
            GVL.ConfSuper.iMinTempOperation.ReadWrite = confSuperConfig.iMinTempOperation;
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
            if (!_StandartTests.IsRunning)
                _StandartTests.Start();
        }

        private async Task StopDriverAsync()
        {
            try
            {
                await _driver.StopAsync();
                await _StandartTests.StopAsync();
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
