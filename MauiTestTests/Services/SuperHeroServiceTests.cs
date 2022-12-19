using MauiTest.Services.SuperHero;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiTestTests.Services
{
    public class SuperHeroServiceTests
    {
        [Fact]
        public async Task GetFakeCatalogTest()
        {
            SuperHeroMockService catalogMockService = new SuperHeroMockService();
            var catalog = await catalogMockService.GetSuperHeroes();

            Assert.NotEmpty(catalog);
        }
    }
}
