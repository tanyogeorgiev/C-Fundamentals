using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabProblems
{
    class _09FibonacciStack
    {
        public static void Run()
        {
            int num = int.Parse(Console.ReadLine());

            Stack<long> fiboStack = new Stack<long>();

            fiboStack.Push(0);
            fiboStack.Push(1);

            for (int i = 0; i < num - 1; i++)
            {
                long n1 = fiboStack.Pop();
                long n2 = fiboStack.Peek();
                fiboStack.Push(n1);
                fiboStack.Push(n1 + n2);
            }

            Console.WriteLine(fiboStack.Peek());
        }
    }
}
