using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabProblems
{
    class _01ReverseNumbers
    {
        public static void Run()
        {
            int[] inputLine = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(s => int.Parse(s.Trim())).ToArray();
            Stack<int> reversedStack = new Stack<int>();
            for (int i = 0; i < inputLine.Count(); i++)
            {
                reversedStack.Push(inputLine[i]);
            }

            for (int i = 0; i < inputLine.Count(); i++)
            {
                Console.Write(reversedStack.Pop() + " ");
            }
        }
    }
}
