using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabProblems
{
    class _04BasicQueueOperations
    {
        public static void Run()
        {
            int[] commands = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            Queue<int> mainQUeue = new Queue<int>();

            int[] nums = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            for (int i = 0; i < commands[0]; i++)
            {
                mainQUeue.Enqueue(nums[i]);
            }

            for (int i = 0; i < commands[1]; i++)
            {
                mainQUeue.Dequeue();
            }

            if (mainQUeue.Contains(commands[2]))
            {
                Console.WriteLine("true");
            }
            else
            {
                if (mainQUeue.Count == 0)
                {
                    Console.WriteLine(0);
                }
                else
                {
                    Console.WriteLine(mainQUeue.Min());

                }
            }
        }
    }
}
