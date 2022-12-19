using MauiTest.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiTest.Services.SuperHero
{
    public interface ISuperHeroService
    {
        Task<IEnumerable<SuperHeroModel>> GetSuperHeroes();
    }
}
