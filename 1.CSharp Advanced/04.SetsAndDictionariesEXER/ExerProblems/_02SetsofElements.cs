using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerProblems
{
    class _02SetsofElements
    {
        public static void Run()
        {
            int[] ina = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            int n = ina[0];
            int m = ina[1];

            HashSet<int> nHash = new HashSet<int>();
            HashSet<int> mHash = new HashSet<int>();



            for (int i = 0; i < n; i++)
            {
                int a = int.Parse(Console.ReadLine().Trim());
                nHash.Add(a);
            }

            for (int i = 0; i < m; i++)
            {
                int a = int.Parse(Console.ReadLine().Trim());
                mHash.Add(a);
            }

            var mew = mHash.Intersect(nHash);
            foreach (var i in mew)
            {
                Console.WriteLine(i);
            }
        }
    }
}

