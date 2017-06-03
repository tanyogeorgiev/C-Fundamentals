using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerProblems
{
    class _08HandsOfCards
    {
        public static void Run()
        {
            Dictionary<string, int> cardSet = new Dictionary<string, int>();
            cardSet.Add("2", 2);
            cardSet.Add("3", 3);
            cardSet.Add("4", 4);
            cardSet.Add("5", 5);
            cardSet.Add("6", 6);
            cardSet.Add("7", 7);
            cardSet.Add("8", 8);
            cardSet.Add("9", 9);
            cardSet.Add("10", 10);
            cardSet.Add("J", 11);
            cardSet.Add("Q", 12);
            cardSet.Add("K", 13);
            cardSet.Add("A", 14);
            cardSet.Add("S", 4);
            cardSet.Add("H", 3);
            cardSet.Add("D", 2);
            cardSet.Add("C", 1);

            Dictionary<string, HashSet<string>> people = new Dictionary<string, HashSet<string>>();

            while (true)
            {
                string[] input = Console.ReadLine().Split(new char[] { ':', ',' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
                string name = input[0];
                if (name == "JOKER")
                {
                    break;
                }
                if (!people.ContainsKey(input[0]))
                {
                    people.Add(name, new HashSet<string>());

                }
                for (int i = 1; i < input.Length; i++)
                {
                    people[name].Add(input[i].Trim());
                }

            }

            foreach (var p in people)
            {
                int cardSum = 0;
                foreach (var card in p.Value)
                {
                    string power = card[0].ToString();
                    string type = card[1].ToString();
                    if (card.Length > 2)
                    {
                        power = card.Substring(0, 2);
                        type = card[2].ToString();
                    }

                    cardSum += cardSet[power] * cardSet[type];
                }
                Console.WriteLine($"{p.Key}: {cardSum}");

            }


        }
    }
}
