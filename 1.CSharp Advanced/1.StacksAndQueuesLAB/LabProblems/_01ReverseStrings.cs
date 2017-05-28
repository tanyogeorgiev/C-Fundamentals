using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabProblems
{
    class _01ReverseStrings
    {
        public static void Run ()
        {
            var input = Console.ReadLine();
            var stack = new Stack<char>();
            foreach (var ch in input)
            {
                stack.Push(ch);
            }
            while (stack.Count != 0)
            {
                Console.Write(stack.Pop());
            }
            Console.WriteLine();
        }
    }
}
