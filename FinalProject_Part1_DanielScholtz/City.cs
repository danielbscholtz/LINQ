using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject_Part1_DanielScholtz
{
    public class City
    {
        public string Name { get; set; }
        public string Country { get; set; }
        public City() { }
        public City(string name, string country)
        {
            Name = name;
            Country = country;
        }

    }
}
