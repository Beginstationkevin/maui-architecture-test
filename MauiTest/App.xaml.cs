using MauiTest.Services.Navigation;

namespace MauiTest;

public partial class App : Application
{
	private readonly INavigationService NavigationService;

    public App(INavigationService navigationService)
	{
		NavigationService = navigationService;
		InitializeComponent();

		MainPage = new AppShell(NavigationService);
	}
}
