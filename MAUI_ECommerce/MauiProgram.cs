using epj.RouteGenerator;
using MAUI_ECommerce.PageModels;
using MAUI_ECommerce.Pages;
using MAUI_ECommerce.Services;
using Microsoft.Extensions.Logging;

namespace MAUI_ECommerce
{
    [AutoRoutes("Page")]
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();
            builder
                .UseMauiApp<App>()
                .ConfigureFonts(fonts =>
                {
                    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                    fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
                    fonts.AddFont("Poppins-Black.ttf", "PoppinsBlack");
                    fonts.AddFont("Poppins-Bold.ttf", "PoppinsBold");
                    fonts.AddFont("Poppins-Light.ttf", "PoppinsLight");
                    fonts.AddFont("Poppins-Medium.ttf", "PoppinsMedium");
                    fonts.AddFont("Poppins-Regular.ttf", "PoppinsRegular");
                    fonts.AddFont("Poppins-SemiBold.ttf", "PoppinsSemiBold");
                    fonts.AddFont("Poppins-Thin.ttf", "PoppinsThin");
                });

            builder.Services.AddSingleton<HomePage>();
            builder.Services.AddSingleton<HomePageModel>();
            builder.Services.AddSingleton<INavigationService, NavigationService>();


#if DEBUG
            builder.Logging.AddDebug();
#endif

            return builder.Build();
        }
    }
}
