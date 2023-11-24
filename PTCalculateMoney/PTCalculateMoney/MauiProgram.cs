using FFImageLoading.Maui;
using Microsoft.Extensions.Logging;

namespace PTCalculateMoney
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();
            MauiAppBuilder mauiAppBuilder = builder
                .UseMauiApp<App>()
                .UseFFImageLoading()
                .ConfigureFonts(fonts =>
                {
                    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                    fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
                    fonts.AddFont("Robotica.ttf", "RoboticaRegular");
                    fonts.AddFont("Font-Awesome-6-Solid-900.otf", "Solid");
                    fonts.AddFont("Font-Awesome-6-Regular-400.otf", "Regular");
                    fonts.AddFont("Font-Awesome-6-Brands-Regular-400.otf", "FontAwesome");
                });

#if DEBUG
		builder.Logging.AddDebug();
#endif

            return builder.Build();
        }
    }
}