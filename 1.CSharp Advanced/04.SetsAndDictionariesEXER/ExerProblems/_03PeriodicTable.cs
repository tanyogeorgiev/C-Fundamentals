using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerProblems
{
    class _03PeriodicTable
    {
        public static void Run ()
        {
            int inputCount = int.Parse(Console.ReadLine());

            HashSet<string> result = new HashSet<string>();
            for (int i = 0; i < inputCount; i++)
            {
                string[] input = Console.ReadLine().Split(' ');

                foreach (var el in input)
                {
                    result.Add(el);
                }


            }

            Console.WriteLine(String.Join(" ", result.OrderBy(a => a)));
        }
    }
}
