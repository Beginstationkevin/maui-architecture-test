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

        private const string AuthKeyDefault = "eyJhbGciOiJodHRwOi8vd3d3LnczLm9yZy8yMDAxLzA0L3htbGRzaWctbW9yZSNobWFjLXNoYTUxMiIsInR5cCI6IkpXVCJ9.eyJodHRwOi8vc2NoZW1hcy54bWxzb2FwLm9yZy93cy8yMDA1LzA1L2lkZW50aXR5L2NsYWltcy9uYW1lIjoic3RyaW5nIiwiaHR0cDovL3NjaGVtYXMubWljcm9zb2Z0LmNvbS93cy8yMDA4LzA2L2lkZW50aXR5L2NsYWltcy9yb2xlIjoiYWRtaW4iLCJleHAiOjE2NzE1NDg5NjB9.LM-h0HcwO-z3B-Nb4qGMZHh48YWHflWOHbYzml395DhK3jUmOUQuDGzOaelzWmkjcQjWGUjNRr27dqYJSQepuw";
        public string AuthKey
        {
            get => AuthKeyDefault;
        }
    }
}
