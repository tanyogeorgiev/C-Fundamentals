using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamPREP
{
    class _1SecretNature
    {
        public static void Run()
        {
            Stack<int> flowStack = new Stack<int>(Console.ReadLine().Split(' ').Select(int.Parse).ToArray().Reverse());
            Stack<int> watStack = new Stack<int>(Console.ReadLine().Split(' ').Select(int.Parse).ToArray());
            Queue<int> WTF = new Queue<int>();

            while (flowStack.Any() && watStack.Any())
            {
                int currFlower = flowStack.Pop();
                int currWat = watStack.Pop();

                if (currFlower == currWat)
                {
                    WTF.Enqueue(currFlower);

                }
                else if (currWat >= currFlower)
                {
                    int newWat = currWat - currFlower;
                    if (watStack.Count == 0)
                    {
                        watStack.Push(newWat);
                    }
                    else
                    {
                        int toAdd = watStack.Pop() + newWat;
                        watStack.Push(toAdd);
                    }
                }

                else
                {
                    flowStack.Push(currFlower - currWat);
                }

            }

            Console.WriteLine(watStack.Any() ? string.Join(" ", watStack) : string.Join(" ", flowStack));
            Console.WriteLine(WTF.Any() ? string.Join(" ", WTF) : "None");
        }
    }
}
