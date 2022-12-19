using MauiTest.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiTest.Services.SuperHero
{
    public class SuperHeroMockService : ISuperHeroService
    {
        private readonly IEnumerable<SuperHeroModel> MockSuperHeroes =
        new[]
        {
            new SuperHeroModel { id = 1, name = "Batman", firstName = "Bruce", lastName = "Wayne", place = "Gotham", superPower = new SuperPowerModel { id = 1, name = "Tech" } },
            new SuperHeroModel { id = 2, name = "Spiderman", firstName = "Peter", lastName = "Parker", place = "New York", superPower = new SuperPowerModel { id = 2, name = "Web slinging" } }
        };

        public async Task<IEnumerable<SuperHeroModel>> GetSuperHeroes()
        {
            await Task.Delay(10);

            return MockSuperHeroes;
        }
    }
}
