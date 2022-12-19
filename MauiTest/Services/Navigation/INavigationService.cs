using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiTest.Services.Navigation
{
    public interface INavigationService
    {
        public Task InitializeAsync();

        public Task NavigateToAsync(string route, IDictionary<string, object> routeParameters = null);

        public Task PopAsync();
    }
}
