using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerProblems
{
    class _04CountSymbols
    {
        public static void Run()
        {
            string input = Console.ReadLine();
            SortedDictionary<char, int> gotIt = new SortedDictionary<char, int>();

            foreach (var cr in input)
            {
                if (!gotIt.ContainsKey(cr))
                {
                    gotIt.Add(cr, 1);
                }

                else gotIt[cr]++;
            }

            foreach (var line in gotIt)
            {
                Console.WriteLine(line.Key + ": " + line.Value + " time/s");
            }
        }
    }
}
