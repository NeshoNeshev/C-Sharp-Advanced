using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Exersize
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] symbol = new char[] { '-', ',', '.', '!', '?'};

            using (var reader = new StreamReader("../../../text.txt"))
            {
                using (var writer = new StreamWriter("../../../output.txt"))
                {
                    string line = reader.ReadLine();
                    //int index = 0;
                    while (line != null)
                    {
                        
                        string lineReplace = Replace(line);
                        string lineReverse = Reverse(lineReplace);
                        writer.WriteLine(lineReverse);
                        Console.Write(lineReverse);
                        //writer.WriteLine($"{index}. {line}");
                        //Console.WriteLine($"{index}. {line}");
                        //index++;
                        line = reader.ReadLine();
                    }
                }
            }
            

        }
        public static string Replace(string line)
        {

            List<char> replaceChars = new List<char>() { '-', ',', '.', '!', '?' };
            foreach (char c in replaceChars)
                line = line.Replace(c, '@');

            return line;
        }
        public static string Reverse(string line)
        {
            var reverse = line.Split();
            Stack<string> stack = new Stack<string>();
            StringBuilder sb = new StringBuilder();
            foreach (var item in reverse)
            {
                stack.Push(item);
            }
            while (stack.Count!=0)
            {
                sb.Append(stack.Pop()+ " ");
            }
            return sb.ToString();
        }

    }
}

