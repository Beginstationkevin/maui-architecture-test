using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiTest.Services.Settings
{
    public class SettingsService : ISettingsService
    {
        private const string ApiBaseUrlDefault = "http://10.0.2.2:5273";
        public string ApiBaseUrl 
        {
            get => ApiBaseUrlDefault;
        }

        private const string AuthKeyDefault = "Place Your API key here!";
        public string AuthKey
        {
            get => AuthKeyDefault;
        }
    }
}
