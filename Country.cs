using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject_Part1_DanielScholtz
{
    public class Country
    {
        public string Name { get; set; }
        public string Code { get; set; }

        public Country() { }
        public Country(string name, string code)
        {
            Name = name;
            Code = code;
        }
    }
}
