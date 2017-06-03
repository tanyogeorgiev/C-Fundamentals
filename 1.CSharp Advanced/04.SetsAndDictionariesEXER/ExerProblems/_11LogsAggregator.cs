using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerProblems
{
    class _11LogsAggregator
    {
        public static void Run()
        {
            SortedDictionary<string, SortedSet<string>> logs = new SortedDictionary<string, SortedSet<string>>();
            Dictionary<string, int> userDuration = new Dictionary<string, int>();
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {


                string[] inputLine = Console.ReadLine().Split(' ').ToArray();

                string ip = inputLine[0];
                string user = inputLine[1];
                int dur = int.Parse(inputLine[2]);

                if (!logs.ContainsKey(user))
                {
                    logs.Add(user, new SortedSet<string>());
                    logs[user].Add(ip);
                    userDuration[user] = dur;
                }

                else
                {
                    logs[user].Add(ip);
                    userDuration[user] += dur;
                }

            }

            foreach (var user in logs)
            {
                Console.WriteLine($"{user.Key}: {userDuration[user.Key]} [{String.Join(", ", user.Value)}]");

            }
        }
    }
}
