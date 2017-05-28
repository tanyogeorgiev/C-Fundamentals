using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabProblems
{
    class _02BasicStackOperation
    {
        public static void Run()
        {
            int[] inputString = Console.ReadLine()
                           .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                           .Select(int.Parse)
                           .ToArray();

            int stackCount = inputString[0];
            int popCount = inputString[1];
            int isExist = inputString[2];

            Stack<int> mainStack = new Stack<int>();

            int[] stackElements = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

            foreach (var e in stackElements)
            {
                mainStack.Push(e);
            }

            for (int i = 0; i < popCount; i++)
            {
                mainStack.Pop();
            }

            if (mainStack.Contains(isExist))
            {
                Console.WriteLine("true");
            }
            else
            {
                if (mainStack.Count > 0)
                {
                    Console.WriteLine(mainStack.Min());

                }

                else
                {
                    Console.WriteLine('0');
                }
            }
        }
    }
}
