using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabProblems
{
    class _07BalancedParenthesis
    {
       public static void Run ()
        {
            string line = Console.ReadLine();
            Stack<char> openQUeue = new Stack<char>();

            if (line.Length % 2 == 0)
            {
                for (int i = 0; i < line.Length; i++)
                {
                    switch (line[i])
                    {
                        case '(':
                            openQUeue.Push('(');
                            break;
                        case '{':
                            openQUeue.Push('{');
                            break;
                        case '[':
                            openQUeue.Push('[');
                            break;
                        case ')':
                            if (openQUeue.Pop() != '(')
                            {
                                Console.WriteLine("NO");
                                return;
                            };
                            break;
                        case '}':
                            if (openQUeue.Pop() != '{')
                            {
                                Console.WriteLine("NO");
                                return;
                            };
                            break;
                        case ']':
                            if (openQUeue.Pop() != '[')
                            {
                                Console.WriteLine("NO");
                                return;
                            };
                            break;
                    };

                }
                if (openQUeue.Count == 0)
                {
                    Console.WriteLine("YES");
                }
                else
                {
                    Console.WriteLine("NO");
                }
            }

            else
            {
                Console.WriteLine("NO");
            }
        }
    }
}
