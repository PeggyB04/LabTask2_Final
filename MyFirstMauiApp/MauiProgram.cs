using Microsoft.Extensions.Logging;
using MyFirstMauiApp.ViewModels.Pages;
using Prism;

namespace MyFirstMauiApp
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();
            _ = builder
                .UseMauiApp<App>()
                .UsePrism(static (prism) =>
                {
                    prism.RegisterTypes(container =>
                    {
                        container.RegisterForNavigation<MainPage, MainPageViewModel>();
                    });
                    prism.OnAppStart(app =>
                    {
                        app.NavigateAsync("/NavigationPage/MainPage");
                    });
                })
                .ConfigureFonts(fonts =>
                {
                    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                    fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
                });

            return builder.Build();
        }
    }
}
