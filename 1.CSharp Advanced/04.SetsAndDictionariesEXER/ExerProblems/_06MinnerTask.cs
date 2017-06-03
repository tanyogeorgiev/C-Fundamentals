using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerProblems
{
    class _06MinnerTask
    {
        public static void Run ()

        {
            Dictionary<string, int> minners = new Dictionary<string, int>();

            while (true)
            {
                string line = Console.ReadLine();
                if (line.ToLower() == "stop")
                {
                    break;
                }
                int line2 = int.Parse(Console.ReadLine());
                if (!minners.ContainsKey(line))
                {
                    minners.Add(line, line2);
                }
                else
                {
                    minners[line] += line2;
                }
            }

            foreach (var vkp in minners)
            {
                Console.WriteLine($"{vkp.Key} -> {vkp.Value}");
            }
         }
    }
}
