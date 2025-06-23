using MAUI_Opcua.Services.Drivers.Opcua;
using Microsoft.Extensions.Logging;
using CommunityToolkit.Maui;
using Microsoft.Maui.Handlers;

#if ANDROID
using Android.Text;
#endif

namespace App_UI_Mobile_Laminado
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();
            builder
                .UseMauiApp<App>()
                .UseMauiCommunityToolkit()
                .ConfigureFonts(fonts =>
                {
                    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                    fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
                });

            // 🔥 Configuração do NumericEntry para Android — aceitar ponto, vírgula e negativo
            EntryHandler.Mapper.AppendToMapping("AllowDecimal", (handler, view) =>
            {
#if ANDROID
                handler.PlatformView.InputType =
                    InputTypes.ClassNumber |
                    InputTypes.NumberFlagDecimal |
                    InputTypes.NumberFlagSigned;
#endif
            });

            // 🔗 Serviço OPC UA
            builder.Services.AddSingleton<Opcua_Client>();

#if DEBUG
            builder.Logging.AddDebug();
#endif

            return builder.Build();
        }
    }
}
