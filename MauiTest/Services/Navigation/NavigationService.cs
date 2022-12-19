using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiTest.Services.Navigation
{
    internal class NavigationService : INavigationService
    {
        public NavigationService() { 
            
        }

        public async Task InitializeAsync() { return; } /*=>
        NavigateToAsync(
            string.IsNullOrEmpty(_settingsService.AuthAccessToken)
                ? "//Login"
                : "//Main/Catalog");*/

        public Task NavigateToAsync(string route, IDictionary<string, object> routeParameters = null)
        {
            var shellNavigation = new ShellNavigationState(route);

            return routeParameters != null
                ? Shell.Current.GoToAsync(shellNavigation, routeParameters)
                : Shell.Current.GoToAsync(shellNavigation);
        }

        public Task PopAsync() =>
            Shell.Current.GoToAsync("..");
    }
}
