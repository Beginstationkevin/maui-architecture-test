using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiTest.Services.Settings
{
    public class SettingsMockService : ISettingsService
    {
        private const string ApiBaseUrlDefault = "base url";
        public string ApiBaseUrl
        {
            get => ApiBaseUrlDefault;
        }

        private const string AuthKeyDefault = "auth key";
        public string AuthKey
        {
            get => AuthKeyDefault;
        }
    }
}
