using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using MauiTest.Models;
using MauiTest.Services.Navigation;
using MauiTest.Services.Settings;
using MauiTest.Services.SuperHero;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiTest.ViewModels
{
    public partial class SuperHeroViewModel : ViewModelBase
    {
        [ObservableProperty]
        IEnumerable<SuperHeroModel> superHeroes;

        ISuperHeroService Service;


        public SuperHeroViewModel(ISuperHeroService superHeroService, INavigationService navigationService, ISettingsService settingsService) : base(navigationService, settingsService)
        {
            Title = "SuperHero";
            Service = superHeroService;
        }

        [RelayCommand]
        async Task Get() 
        { 
            SuperHeroes = await Service.GetSuperHeroes();
        }

        [RelayCommand]
        async Task GoToAbout() {
            await NavigationService.NavigateToAsync("About");
        }
    }
}
