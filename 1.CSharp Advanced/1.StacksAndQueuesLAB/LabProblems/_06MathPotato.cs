using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabProblems
{
    class _06MathPotato
    {
        public void Run()
        {
            var children = Console.ReadLine().Split(' ');
            var number = int.Parse(Console.ReadLine());
            Queue<string> queue = new Queue<string>(children);
            int cycle = 1;
            while (queue.Count != 1)
            {
                for (int i = 1; i < number; i++)
                {
                    queue.Enqueue(queue.Dequeue());
                }
                if (IsPrime(cycle))
                {
                    Console.WriteLine($"Prime {queue.Peek()}");
                }
                else
                {
                    Console.WriteLine($"Removed {queue.Dequeue()}");
                }
                cycle++;
            }
            Console.WriteLine($"Last is {queue.Dequeue()}");

        }
        public static bool IsPrime(int num)
        {
            bool prime = true;

            if (num < 2)
            {
                prime = false;
            }


            else if (num == 2)
            {
                prime = true;
            }
            else if (num % 2 == 0)
            {
                prime = false;
            }
            else
            {

                for (int i = 2; i < num; i++)
                {
                    if (num % i == 0)
                    {
                        prime = false;
                        break;
                    }
                }

            }

            return prime;
        }
    }
}

