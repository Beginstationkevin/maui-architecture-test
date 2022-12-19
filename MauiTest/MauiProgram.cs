using MauiTest.Services.Navigation;
using MauiTest.Services.Settings;
using MauiTest.Services.SuperHero;
using MauiTest.ViewModels;
using MauiTest.Views;
using Microsoft.Maui.Hosting;

namespace MauiTest;

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
			});

		builder.Services.AddSingleton<ISuperHeroService, SuperHeroService>();
		builder.Services.AddSingleton<SuperHeroViewModel>();
		builder.Services.AddSingleton<SuperHeroView>();
        builder.Services.AddSingleton<AboutViewModel>();
        builder.Services.AddSingleton<AboutPage>();
        builder.Services.AddSingleton<INavigationService, NavigationService>();
        builder.Services.AddSingleton<ISettingsService, SettingsService>();



        return builder.Build();
	}
}
