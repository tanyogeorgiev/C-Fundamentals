using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace LabProblems
{
    class _02MaxSumSubMatrix
    {
        public static void Run()
        {
            /*
                 * Implementet algorithm search for max sum of platform in matrix.
                 * Size of platform is hardcoded, but will work for every entered size (except bigger than matrix size):
                     int rowPlatformSize = 2;
                     int colPlatformSize = 2;
             */
            int[,] matrix = ReadMatrix(); // Method that read matrice from console.

            int rowPlatformSize = 2; // Hardcoded for current problem
            int colPlatformSize = 2; // Hardcoded for current problem
            int theSum = int.MinValue;
            int theRow = 0;
            int theCol = 0;


            // Search in matrice
            if (matrix.GetLength(0) < rowPlatformSize || matrix.GetLength(1) < colPlatformSize)
            {
                Console.WriteLine("Platform size is bigger than matrix");
                return;
            }
            for (int row = 0; row < matrix.GetLength(0) - rowPlatformSize + 1; row++)
            {
                for (int col = 0; col < matrix.GetLength(1) - colPlatformSize + 1; col++)
                {
                    int currentSum = 0;
                    for (int platformRow = row; platformRow < row + rowPlatformSize; platformRow++)
                    {
                        for (int platformCol = col; platformCol < col + colPlatformSize; platformCol++)
                        {
                            currentSum += matrix[platformRow, platformCol];
                        }
                    }
                    if (currentSum > theSum)
                    {
                        theSum = currentSum;
                        theRow = row;
                        theCol = col;
                    }
                }
            }

            //Print Matrice
            for (int row = theRow; row < theRow + rowPlatformSize; row++)
            {
                for (int col = theCol; col < theCol + colPlatformSize; col++)
                {
                    Console.Write($"{matrix[row, col]} ");
                }
                Console.WriteLine();
            }

            Console.WriteLine(theSum);

        }

        private static int[,] ReadMatrix()
        {
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

            return matrix;
        }
    }
}
