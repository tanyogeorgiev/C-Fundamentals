using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerProblems
{
    class _10PopulationCounter
    {
        public static void Run()
        {
            SortedDictionary<string, Dictionary<string, long>> population = new SortedDictionary<string, Dictionary<string, long>>();
            while (true)
            {
                string[] inputLine = Console.ReadLine().Split('|').ToArray();
                if (inputLine.Length == 1 && inputLine[0] == "report")
                {
                    break;
                }


                string city = inputLine[0].Trim();
                string country = inputLine[1].Trim();
                long pop = long.Parse(inputLine[2].Trim());

                if (!population.ContainsKey(country))
                {
                    population.Add(country, new Dictionary<string, long>());
                }

                if (!population[country].ContainsKey(city))
                {
                    population[country].Add(city, 0);
                }

                population[country][city] = pop;


            }

            foreach (var country in population.OrderByDescending(b => b.Value.Sum(a => a.Value)))
            {
                Console.WriteLine($"{country.Key} (total population: {country.Value.Sum(a => a.Value)})");
                foreach (var city in country.Value.OrderByDescending(b => b.Value))
                {
                    Console.WriteLine($"=>{city.Key}: {city.Value}");
                }

            }
        }
    }
}
