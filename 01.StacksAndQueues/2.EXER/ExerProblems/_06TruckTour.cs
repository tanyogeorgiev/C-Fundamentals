using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabProblems
{
    class _06TruckTour
    {
        public static void Run()
        {
            int n = int.Parse(Console.ReadLine());
            int[] pacha = new int[n];
            for (int i = 0; i < n; i++)
            {
                var line = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
                pacha[i] = line[0] - line[1];

            }

            int indix = 0;
            for (int i = 0; i < pacha.Length - 1; i++)
            {
                if (pacha[i] < 0)
                {
                    indix = i + 1;
                }

                if (pacha[i] > 0)
                {
                    pacha[i + 1] = pacha[i] + pacha[i + 1];
                }

            }

            Console.WriteLine(indix);

        }

    }
}


