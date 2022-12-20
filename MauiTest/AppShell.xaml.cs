using MauiTest.Services.Navigation;
using MauiTest.Views;

namespace MauiTest;

public partial class AppShell : Shell
{
    private readonly INavigationService _navigationService;
	public AppShell(INavigationService navigationService)
	{
        _navigationService = navigationService;
        InitializeRouting();
        InitializeComponent();
    }

    private static void InitializeRouting()
    {
        Routing.RegisterRoute("SuperHero", typeof(SuperHeroView));
        Routing.RegisterRoute("About", typeof(AboutPage));
    }
}
