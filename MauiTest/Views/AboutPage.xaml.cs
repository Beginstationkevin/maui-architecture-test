using MauiTest.Models.About;
using MauiTest.ViewModels;

namespace MauiTest.Views;

public partial class AboutPage : ContentPage
{
	public AboutPage(AboutViewModel vm)
	{
		InitializeComponent();
		BindingContext= vm;
	}

	private async void LearnMore_Clicked(object sender, EventArgs e)
	{
		if (BindingContext is About about)
		{
			// Navigate to the specified URL in the system browser.
			await Launcher.Default.OpenAsync("https://aka.ms/maui");
		}
	}
}