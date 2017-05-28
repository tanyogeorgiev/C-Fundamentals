using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabProblems
{
    class _11PoisonousPlants
    {
        public static void Run()
        {
            int nums = int.Parse(Console.ReadLine());

            int[] plants = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            Stack<int> toIndex = new Stack<int>();
            int[] days = new int[nums];

            toIndex.Push(0);

            for (int i = 1; i < plants.Length; i++)
            {
                int maxDays = 0;
                while (toIndex.Count > 0 && plants[toIndex.Peek()] >= plants[i])
                {
                    maxDays = Math.Max(maxDays, days[toIndex.Pop()]);
                }

                if (toIndex.Count > 0)
                {
                    days[i] = maxDays + 1;
                }
                toIndex.Push(i);

            }
            Console.WriteLine(days.Max());

        }
    }
}
