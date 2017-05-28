using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabProblems
{
    class _08RecursiveFibonacci

    {
        public static long[] fib;

        public static void Run()
        {
            int num = int.Parse(Console.ReadLine());
            fib = new long[num];
            long result = GetFibonacci(num);

            Console.WriteLine(result);

        }

        public static long GetFibonacci(int num)
        {
            if (num <= 2) return 1;

            if (fib[num - 1] != 0)
            {
                return fib[num - 1];
            }
            return fib[num - 1] = GetFibonacci(num - 1) + GetFibonacci(num - 2);

        }
    }
}
