using Microsoft.Extensions.Logging;

namespace PassXYZ.Vault
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();
            builder
                .UseMauiApp<App>()
                .ConfigureFonts(fonts =>
                {
                    fonts.AddFont("fa-regular-400.woff2", "FontAwesomeRegular");
                    fonts.AddFont("fa-solid-900.woff2", "FontAwesomeSolid");
                    fonts.AddFont("fa-brands-400.woff2", "FontAwesomeBrands");
                    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                    fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
                });

#if DEBUG
    		builder.Logging.AddDebug();
#endif

            return builder.Build();
        }
    }
}
