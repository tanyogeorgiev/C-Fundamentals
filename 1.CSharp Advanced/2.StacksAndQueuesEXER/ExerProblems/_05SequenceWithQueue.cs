using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabProblems
{
    class _05SequenceWithQueue
    {
        private static void Run ()
        {

            long num = long.Parse(Console.ReadLine());
            Queue<long> mainQueue = new Queue<long>();
            Queue<long> nextNumber = new Queue<long>();

            nextNumber.Enqueue(num);
            nextNumber.Enqueue(num + 1);
            mainQueue.Enqueue(num);
            mainQueue.Enqueue(num + 1);


            for (int i = 0; i < 16; i++)
            {
                long currentNextNumber = nextNumber.Dequeue();

                mainQueue.Enqueue(2 * currentNextNumber + 1);
                mainQueue.Enqueue(currentNextNumber + 2);
                mainQueue.Enqueue(nextNumber.Peek() + 1);

                nextNumber.Enqueue(2 * currentNextNumber + 1);
                nextNumber.Enqueue(currentNextNumber + 2);
                nextNumber.Enqueue(nextNumber.Peek() + 1);


            }

            Console.WriteLine(String.Join(" ", mainQueue));
        }
    }
}
