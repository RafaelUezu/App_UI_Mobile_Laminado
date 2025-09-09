using MAUI_Opcua.Services.Drivers.Opcua;

using CommunityToolkit.Maui;

using Serilog;
using Serilog.Extensions.Logging;

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


            builder.Logging.AddSerilog(
                new LoggerConfiguration()
                    .WriteTo.File(Path.Combine(FileSystem.Current.AppDataDirectory, "AppLogs//log.txt"),
                        rollingInterval: RollingInterval.Day,
                        fileSizeLimitBytes: 50*1024*1024,
                        retainedFileCountLimit: 31)
                    .CreateLogger()
            );

            #region Serviços
            builder.Services.AddSingleton<Opcua_Client>();
            #endregion

            return builder.Build();
        }
    }
}