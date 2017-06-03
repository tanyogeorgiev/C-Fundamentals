using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerProblems
{
    class _12LegendaryFarming
    {
        public static void Run()
        {
            Dictionary<string, int> mainMaterials = new Dictionary<string, int>();
            Dictionary<string, int> junkMaterials = new Dictionary<string, int>();
            Dictionary<string, string> legendary = new Dictionary<string, string>();
            legendary.Add("shards", "Shadowmourne");
            legendary.Add("fragments", "Valanyr");
            legendary.Add("motes", "Dragonwrath");

            mainMaterials.Add("shards", 0);
            mainMaterials.Add("fragments", 0);
            mainMaterials.Add("motes", 0);
            bool itemGet = false;
            string materialGained = "";
            while (true)
            {
                string[] inputLine = Console.ReadLine().Split().ToArray();

                for (int i = 0; i < inputLine.Length; i += 2)
                {
                    int qty = int.Parse(inputLine[i]);
                    string material = inputLine[i + 1].ToLower();

                    if (legendary.ContainsKey(material))
                    {
                        if (!mainMaterials.ContainsKey(material))
                        {
                            mainMaterials.Add(material, qty);
                            if (mainMaterials[material] >= 250)
                            {
                                itemGet = true;
                                materialGained = material;
                                mainMaterials[material] -= 250;
                                break;
                            }
                        }
                        else
                        {
                            mainMaterials[material] += qty;
                            if (mainMaterials[material] >= 250)
                            {
                                itemGet = true;
                                materialGained = material;
                                mainMaterials[material] -= 250;
                                break;
                            }
                        }
                    }
                    else
                    {
                        if (!junkMaterials.ContainsKey(material))
                        {
                            junkMaterials.Add(material, qty);
                        }
                        else
                        {
                            junkMaterials[material] += qty;

                        }
                    }

                }

                if (itemGet)
                {
                    break;
                }
            }
            string legendaryObtained = legendary.Where(a => a.Key.ToLower() == materialGained).Select(l => l.Value).First();


            Console.WriteLine($"{legendaryObtained} obtained!");
            foreach (var mat in mainMaterials.OrderByDescending(a => a.Value).ThenBy(a => a.Key))
            {
                Console.WriteLine($"{mat.Key}: {mat.Value}");
            }

            foreach (var mat in junkMaterials.OrderBy(a => a.Key))
            {
                Console.WriteLine($"{mat.Key}: {mat.Value}");
            }

        }
    }
}
