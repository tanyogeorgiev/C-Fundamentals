using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabProblems
{
    class _04PascalTriangle
    {
        public static void Run()
        {
            int triangleSize = int.Parse(Console.ReadLine());

            long[][] triangle = new long[triangleSize][];

            for (int row = 0; row < triangleSize; row++)
            {
                triangle[row] = new long[row + 1];
                for (int col = 0; col < triangle[row].Length; col++)
                {
                    if (row - 1 >= 0 && col < triangle[row - 1].Length)
                    {
                        if (col - 1 >= 0)
                        {
                            triangle[row][col] = triangle[row - 1][col - 1] + triangle[row - 1][col];
                        }
                        else
                        {
                            triangle[row][col] = triangle[row - 1][col];
                        }

                    }
                    else
                    {
                        triangle[row][col] = 1;
                    }
                }
            }

            foreach (var row in triangle)
            {
                Console.WriteLine(String.Join(" ", row));
            }

        }

    }
}
}
