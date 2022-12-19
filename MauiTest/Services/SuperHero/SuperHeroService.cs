//using Bumptech.Glide.Load.Model.Stream;
using MauiTest.Models;
using MauiTest.Services.Settings;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using System.Net.Http.Headers;

namespace MauiTest.Services.SuperHero
{
    internal class SuperHeroService : ISuperHeroService
    {
        HttpClient Client;
        ISettingsService SettingsService;
        public SuperHeroService(ISettingsService settingsService)
        {
            SettingsService = settingsService;
            try
            {
                Client = new HttpClient { BaseAddress = new Uri(SettingsService.ApiBaseUrl) };
                Client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", settingsService.AuthKey);
            }
            catch
            {

            }
        }

        public async Task<IEnumerable<SuperHeroModel>> GetSuperHeroes()
        {
            var json = await Client.GetStringAsync("api/superhero");
            SuperHeroJsonContainer test = JsonConvert.DeserializeObject<SuperHeroJsonContainer>(json);
            return test.data;
        }
    }
}
