using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerProblems
{
    class _07FixEmails
    {
        public static void Run()
        {
            Dictionary<string, string> emailBook = new Dictionary<string, string>();

            while (true)
            {
                string line = Console.ReadLine();
                if (line.ToLower() == "stop")
                {
                    break;
                }
                string line2 = Console.ReadLine();
                string endChars = line2.Substring(line2.Length - 2, 2);
                if (endChars.ToLower() != "uk" && endChars.ToLower() != "us")
                    emailBook.Add(line, line2);

            }

            foreach (var vkp in emailBook)
            {
                Console.WriteLine($"{vkp.Key} -> {vkp.Value}");
            }
        }
    }
}
