using MAUI_Opcua.Services.Drivers.Opcua;

using CommunityToolkit.Maui;

using Serilog;
using Serilog.Extensions.Logging;
using App_UI_Mobile_Laminado.Services.Alarms;
using App_UI_Mobile_Laminado.Services.StandartTests;
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
                    .WriteTo.File(
                        Path.Combine(FileSystem.Current.AppDataDirectory, "AppLogs/log.txt"),
                        rollingInterval: RollingInterval.Day,
                        fileSizeLimitBytes: 50 * 1024 * 1024,
                        retainedFileCountLimit: 31)
                    .CreateLogger()
            );

            #region Serviços (DI)

            builder.Services.AddSingleton<StandartTests_Services>();
            builder.Services.AddSingleton<Opcua_Client>();   // continua valendo, o cliente existe
            builder.Services.AddSingleton<AlarmEngine>();
            builder.Services.AddSingleton<AlarmConfig>();
            builder.Services.AddSingleton<AlarmsSupervisory.OpcUaAlarmAdapter>(sp =>
            {
                var engine = sp.GetRequiredService<AlarmEngine>();
                var cfg = sp.GetRequiredService<AlarmConfig>();

                engine.RegisterMany(cfg.GetDefinitions());
                return new AlarmsSupervisory.OpcUaAlarmAdapter(engine, cfg.BuildReaders());
            });


            #endregion

            // Constrói o app
            var app = builder.Build();

            // FORÇA a criação do adaptador na partida (assim ele já assina o evento do OPC)
            _ = app.Services.GetRequiredService<AlarmsSupervisory.OpcUaAlarmAdapter>();


            return app;
        }
    }
}