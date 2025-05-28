using MAUI_Opcua.Services.Drivers.Opcua;
using App_UI_Mobile_Laminado.MVVM.View.Pages;

namespace App_UI_Mobile_Laminado
{
    public partial class App : Application
    {
        private readonly Opcua_Client _driver;

        public App(Opcua_Client driver)
        {
            InitializeComponent();
            _driver = driver;
            _driver.Start();
            MainPage = new AppShell();
        }

        protected override async void OnSleep() => await _driver.StopAsync();
        protected override void OnResume() => _driver.Start();
    }
}
