using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiTest.Services.Settings
{
    public interface ISettingsService
    {
        string ApiBaseUrl { get; }
        string AuthKey { get; }
    }
}
