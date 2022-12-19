using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiTest.Models
{
    internal class SuperHeroJsonContainer
    {
        public SuperHeroModel[] data { get; set; }
        public bool succes { get; set; }
        public string message { get; set; }
    }
}
