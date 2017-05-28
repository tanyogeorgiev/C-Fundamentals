using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabProblems
{
    public class _03MaximumElement
    {

       public static void Run()
        {
            int queryCount = int.Parse(Console.ReadLine());
            Stack<int> mainStack = new Stack<int>();
            Stack<int> maxStack = new Stack<int>();
            int currentMaxNumber = int.MinValue;
            maxStack.Push(currentMaxNumber);
            for (int i = 0; i < queryCount; i++)
            {
                int[] query = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
                if (query.Count() == 2)
                {
                    mainStack.Push(query[1]);
                    if (query[1] >= currentMaxNumber)
                    {
                        currentMaxNumber = query[1];
                        maxStack.Push(query[1]);
                    }

                }
                else if (query[0] == 2)
                {

                    if (mainStack.Pop() == currentMaxNumber)
                    {
                        maxStack.Pop();

                        currentMaxNumber = maxStack.Peek();

                    }
                }
                else if (query[0] == 3)
                {

                    Console.WriteLine(currentMaxNumber);
                }

            }
        }


    }
}
