using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabProblems
{
    class _03GroupNumbers
    {
        public static void Run()
        {
            //Algotirthm group in jagged matrice numbers by their remainders when divide to n
            int n = 10;
            int[] numbers = Console.ReadLine().Split(new string[] { ", " }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            int[] indexes = new int[n];
            int[] offset =new int[n];


            foreach (var num in numbers)
            {
                int index = Math.Abs(num % n);
                indexes[index]++;

            }
            int[][] jagged = new int[n][];
            for (int i = 0; i < n; i++)
            {
                jagged[i] = new int[indexes[i]];
            }
           
            foreach (var num in numbers)
            {
                int index = Math.Abs(num % n);
                jagged[index][offset[index]] = num;
                offset[index]++;
            }

            foreach (var item in jagged)
            {
                if (item.Length>0)
                Console.WriteLine(string.Join(" ", item));
            }


        }
    }
}
