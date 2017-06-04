using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabProblems
{
    class _01SumMatrixElement
    {
        public static void Run()
        {
            /*
             * Read size and matrix from console. Split by {", "}
             *
             *   3, 6
             *   7, 1, 3, 3, 2, 1
             *   1, 3, 9, 8, 5, 6
             *   4, 6, 7, 9, 1, 0
             *
             */

            int[] size = Console.ReadLine().Split(new string[] { ", " }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            
            int[,] matrix = new int[size[0], size[1]];
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                int[] input = Console.ReadLine().Split(new string[] { ", " }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = input[j];

                }
            }

            int matrixSum = 0;
            foreach (var row in matrix)
            {
                matrixSum += row;
            }
            Console.WriteLine(size[0]);
            Console.WriteLine(size[1]);
            Console.WriteLine(matrixSum);

        }
    }
}
