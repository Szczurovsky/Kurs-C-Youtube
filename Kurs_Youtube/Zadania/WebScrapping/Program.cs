using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kurs_Youtube.Zadania.WebScrapping
{
    internal class Program
    {
        public static void ProgramStart()
        {
            var countryScraper = new CountryScraper();
            var countries = countryScraper.GetCountries();
            var cityScraper = new cityScraper();
            var result = new List<countryDetails>();    
            foreach (var country in countries)
            {
                Console.WriteLine("Getting cities for: " +  country.Name);
               var cities = cityScraper.GetCities(country).ToList();

                result.Add(new countryDetails()
                {
                    Code = country.Code,
                    Name = country.Name,
                    Cities = cities
                });
            }
            Console.WriteLine("Finished");
            var json = JsonConvert.SerializeObject(result);
            File.WriteAllText(@"C:\JSON\result.json", json);
        }
    }
}
