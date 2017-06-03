using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerProblems
{
    class _05Phonebbok
    {
        public static void Run()
        {
            Dictionary<string, string> phoneBook = new Dictionary<string, string>();
            while (true)
            {
                string[] input = Console.ReadLine().Split('-').ToArray();
                if (input.Length == 2)
                {
                    if (!phoneBook.ContainsKey(input[0]))
                    {
                        phoneBook.Add(input[0], input[1]);
                    }
                    else
                    {
                        phoneBook[input[0]] = input[1];
                    }
                }
                else if (input.Length == 1 && input[0] == "search")
                {
                    while (true)
                    {
                        string name = Console.ReadLine();
                        if (name == "stop")
                        {
                            return;
                        }
                        if (phoneBook.ContainsKey(name))
                        {
                            Console.WriteLine(name + " -> " + phoneBook[name]);

                        }
                        else
                        {
                            Console.WriteLine($"Contact {name} does not exist.");
                        }
                    }
                }
            }

        }
    }
}
