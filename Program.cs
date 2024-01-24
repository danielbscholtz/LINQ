using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject_Part1_DanielScholtz
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<City> cities = new List<City>
            {
                new City { Name = "Quebec", Country = "Canada" },
                new City { Name = "Ottawa", Country = "Canada" },
                new City { Name = "Vancouver", Country = "Canada" },
                new City { Name = "São Paulo", Country = "Brazil" },
                new City { Name = "Los Angeles", Country = "United States" },
                new City { Name = "Memphis", Country = "United States" },
                new City { Name = "Ottawa", Country = "Canada" },
                new City { Name = "São Paulo", Country = "Brazil" },
                new City { Name = "Marseille", Country = "France" }
            };
            List<Country> countries = new List<Country>
            {
                new Country { Name = "France", Code = "FR" },
                new Country { Name = "Canada", Code = "CA" },
                new Country { Name = "EUA", Code = "US" },
                new Country { Name = "Brazil", Code = "BR" }
                
                
            };

            Console.WriteLine("City list:");
            foreach (var city in cities)
            {
                Console.WriteLine($"{city.Name}, {city.Country}");
            }
            Console.WriteLine("------------------------------------");

            var canadaAllCity = from city in cities
                                 where city.Country == "Canada"
                                 select city;

            Console.WriteLine("Canadian Cities:");
            foreach (var city in canadaAllCity)
            {
                Console.WriteLine($"{city.Name}, {city.Country}");
            }
            Console.WriteLine("------------------------------------");

            var getCityUs = from city in cities
                            where city.Country == "United States"
                            select city;

            Console.WriteLine("US cities:");
            foreach (var city in getCityUs)
            {
                Console.WriteLine($"{city.Name}, {city.Country}");
            }
            Console.WriteLine("------------------------------------");

            var distinctCities = cities.Select(city => city.Name).Distinct();

            Console.WriteLine("Distinct cities (remove duplicates): "); 
            foreach (var city in distinctCities)
            {
                Console.WriteLine(city);
            }

            Console.ReadKey();
        }
    }
}
