using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerProblems
{
    class _09UserLogs
    {
        public static void Run()
        {
            SortedDictionary<string, Dictionary<string, int>> logyt = new SortedDictionary<string, Dictionary<string, int>>();

            while (true)
            {

                string[] inputLog = Console.ReadLine().Split(' ').ToArray();
                if (inputLog.Length == 1 && inputLog[0] == "end")
                {
                    break;
                }
                string ip = inputLog[0].Substring(3, inputLog[0].Length - 3);
                string user = inputLog[2].Substring(5, inputLog[2].Length - 5);


                if (!logyt.ContainsKey(user))
                {
                    logyt.Add(user, new Dictionary<string, int>());
                    logyt[user].Add(ip, 1);

                }

                else
                {
                    if (!logyt[user].ContainsKey(ip))
                    {
                        logyt[user].Add(ip, 1);
                    }
                    else
                    {
                        logyt[user][ip]++;
                    }
                }

            }



            foreach (var user in logyt)
            {
                Console.WriteLine(user.Key + ':');
                string result = "";
                foreach (var ip in user.Value)
                {
                    result += $"{ip.Key} => {ip.Value}, ";


                }
                Console.WriteLine(result.TrimEnd(new char[] { ' ', ',' }) + '.');
            }
        }
    }
}
