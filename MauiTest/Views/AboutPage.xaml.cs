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
}