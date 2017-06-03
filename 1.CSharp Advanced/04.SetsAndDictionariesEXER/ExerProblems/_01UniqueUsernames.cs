using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerProblems
{
    class _01UniqueUsernames
    {
        public static void Run()
        {
            int n = int.Parse(Console.ReadLine());
            HashSet<string> hSe = new HashSet<string>();
            for (int i = 0; i < n; i++)
            {
                hSe.Add(Console.ReadLine());
            }

            foreach (var name in hSe)
            {
                Console.WriteLine(name);
            }
        }
    }
}
