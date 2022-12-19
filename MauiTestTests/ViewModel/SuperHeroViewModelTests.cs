using MauiTest.Services.Navigation;
using MauiTest.Services.Settings;
using MauiTest.Services.SuperHero;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MauiTestTests.Services;
using MauiTest.ViewModels;

namespace MauiTestTests.ViewModel
{
    public class SuperHeroViewModelTests
    {
        private readonly ISuperHeroService _superHeroService;
        private readonly INavigationService _navigationService;
        private readonly ISettingsService _settingsService;

        public SuperHeroViewModelTests()
        {
            _superHeroService = new SuperHeroMockService();
            _navigationService = new NavigationMockService();
            _settingsService = new SettingsMockService();
        }

        [Fact]
        public async Task AddCatalogItemCommandSendsAddProductMessageTest()
        {
            var superHeroViewModel = new SuperHeroViewModel(_superHeroService, _navigationService, _settingsService);
            await superHeroViewModel.GetCommand.ExecuteUntilComplete();
            Assert.NotEmpty(superHeroViewModel.SuperHeroes);
        }
    }
}
