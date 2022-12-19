using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using MauiTest.Services.Navigation;
using MauiTest.Services.Settings;
using MauiTest.Validations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiTest.ViewModels
{
    public partial class AboutViewModel : ViewModelBase
    {
        public ValidatableObject<string> Name { get; private set; }
        public ValidatableObject<string> LastName { get; private set; }

        public AboutViewModel(INavigationService navigationService, ISettingsService settingService) : base(navigationService, settingService)
        {
            Title = "About";
            Name = new ValidatableObject<string>();
            LastName = new ValidatableObject<string>();
            AddValidations();
        }

        [RelayCommand]
        async Task GoToSuperHero()
        {
            await NavigationService.NavigateToAsync("SuperHero");
        }

        [RelayCommand]
        private void Validate()
        {
            Name.Validate();
            LastName.Validate();
        }

        private void AddValidations()
        {
            Name.Validations.Add(new IsNotNullOrEmptyRule<string> { ValidationMessage = "A name is required." });
            LastName.Validations.Add(new IsNotNullOrEmptyRule<string> { ValidationMessage = "A lastname is required." });
        }
    }
}
