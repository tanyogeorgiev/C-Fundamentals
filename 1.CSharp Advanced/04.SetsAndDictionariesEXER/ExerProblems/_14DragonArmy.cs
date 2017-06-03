using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerProblems
{
    class _14DragonArmy
    {
        public static void Run()
        {
            Dictionary<string, SortedDictionary<string, Dictionary<string, int>>> dragons = new Dictionary<string, SortedDictionary<string, Dictionary<string, int>>>();

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] data = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
                if (data.Length != 5)
                {
                    continue;
                }

                string type = data[0];
                string name = data[1];
                int damage = data[2] == "null" ? 45 : int.Parse(data[2]);
                int health = data[3] == "null" ? 250 : int.Parse(data[3]);
                int armor = data[4] == "null" ? 10 : int.Parse(data[4]);

                if (!dragons.ContainsKey(type))
                {
                    dragons.Add(type, new SortedDictionary<string, Dictionary<string, int>>());
                    dragons[type].Add(name, new Dictionary<string, int>());
                    dragons[type][name].Add("damage", damage);
                    dragons[type][name].Add("health", health);
                    dragons[type][name].Add("armor", armor);
                }
                else
                {
                    if (!dragons[type].ContainsKey(name))
                    {
                        dragons[type].Add(name, new Dictionary<string, int>());
                        dragons[type][name].Add("damage", damage);
                        dragons[type][name].Add("health", health);
                        dragons[type][name].Add("armor", armor);
                    }

                    else
                    {
                        dragons[type][name]["damage"] = damage;
                        dragons[type][name]["health"] = health;
                        dragons[type][name]["armor"] = armor;

                    }
                }

            }

            foreach (var type in dragons)
            {
                Console.WriteLine($"{type.Key}::({String.Format("{0:0.00}", type.Value.Average(s => s.Value["damage"]))}/{String.Format("{0:0.00}", type.Value.Average(s => s.Value["health"]))}/{String.Format("{0:0.00}", type.Value.Average(s => s.Value["armor"]))})");
                foreach (var dragon in type.Value)
                {
                    Console.WriteLine($"-{dragon.Key} -> damage: {dragon.Value["damage"]}, health: {dragon.Value["health"]}, armor: {dragon.Value["armor"]}");
                }
            }
        }
    }
}
