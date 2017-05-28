using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabProblems
{
    public class _10SampleTextEditor
    {
        public string textString = String.Empty;
        public Stack<string> stringState;
        public void Run()
        {
            int commandCount = int.Parse(Console.ReadLine());
            stringState = new Stack<string>();
            stringState.Push(textString);
            for (int i = 0; i < commandCount; i++)
            {
                string[] command = Console.ReadLine().Split(' ').ToArray();
                switch (command[0])
                {
                    case "1":
                        AppendString(command[1]);
                        break;
                    case "2":
                        TrimString(int.Parse(command[1]));
                        break;
                    case "3":
                        GetElementByIndex(int.Parse(command[1]));
                        break;
                    case "4":
                        Undo();
                        break;
                }
            }


        }
        public string AppendString(string str)
        {
            string newString = textString + str;
            stringState.Push(newString);
            return textString = newString;
        }

        public string TrimString(int charToErase)
        {
            string newString = textString.Substring(0, textString.Length - charToErase);
            stringState.Push(newString);
            return textString = newString;
        }

        public void GetElementByIndex(int index)
        {

            Console.WriteLine(textString[index - 1]);
        }

        public void Undo()
        {
            stringState.Pop();
            textString = stringState.Peek();

        }
    }
}

