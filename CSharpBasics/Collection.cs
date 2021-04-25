using System;
using System.Collections.Generic;

namespace NameCollection
{
    public class Collections
    {
        internal void LearnLists()
        {
            List<byte> ages = new List<byte>();

            ages.Add(1);
            ages.Add(4);
            ages.Add(76);
            ages.Add(255);

            ages.Remove(2);
            foreach (byte age in ages)
            {
                Console.WriteLine($"{age}");
            }


            List<Country> countries = new List<Country>();

            Country country = new Country();
            countries.Add(country);
        }

        internal void LearnDictionary()
        {
            
            Dictionary<string, string> countryCapitals = new Dictionary<string, string>()
            {
                ["Nepal"] = "Kathmandu",
                ["India"] = "Kathmandu",
                ["China"] = "Beghing"

            };

            foreach (var country in countryCapitals)
            {
                Console.WriteLine($"Country: {country.Key} Capital City: {country.Value}");
            }
            //countryCapitals.Add("Nepal","Kathmandu");
            //countryCapitals.Add("India", "Delhi");
            //countryCapitals.Add("China", "Beghing");
        }
    }
    public class Country
    {
        public string Name { get; set; }
    }

}