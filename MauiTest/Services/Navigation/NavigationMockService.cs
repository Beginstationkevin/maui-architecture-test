using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiTest.Services.Navigation
{
    public class NavigationMockService : INavigationService
    {
        public Task NavigateToAsync(string route, IDictionary<string, object>? routeParameters = null)
        {
            return Task.CompletedTask;
        }

        public Task PopAsync()
        {
            return Task.CompletedTask;
        }
    }
}
