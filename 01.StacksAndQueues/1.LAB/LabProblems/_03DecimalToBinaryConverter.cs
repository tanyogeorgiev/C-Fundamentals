using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabProblems
{
    class _03DecimalToBinaryConverter
    {
        public static void Run()
        {
            var decimalNumber = int.Parse(Console.ReadLine());
            var stack = new Stack<int>();
            if (decimalNumber != 0)
            {
                while (decimalNumber != 0)
                {
                    stack.Push(decimalNumber % 2);
                    decimalNumber /= 2;
                }
                while (stack.Count != 0)
                {
                    Console.Write(stack.Pop());
                }
            }
            else
            {
                Console.WriteLine(0);

            }
        }
    }
}
