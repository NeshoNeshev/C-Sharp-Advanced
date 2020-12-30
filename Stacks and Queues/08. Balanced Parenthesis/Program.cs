using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Advanced
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();

            var elements = new Stack<char>();
            var balanced = true;

            if (input != null)
                foreach (var item in input)
                {
                    switch (item)
                    {
                        case '(':
                            elements.Push(item);
                            break;
                        case '[':
                            elements.Push(item);
                            break;
                        case '{':
                            elements.Push(item);
                            break;
                        case ')':
                            if (!elements.Any() || elements.Pop() != '(')
                            {
                                balanced = false;
                            }
                            break;
                        case ']':
                            if (!elements.Any() || elements.Pop() != '[')
                            {
                                balanced = false;
                            }
                            break;
                        case '}':
                            if (!elements.Any() || elements.Pop() != '{')
                            {
                                balanced = false;
                            }
                            break;
                    }
                }

            Console.WriteLine(balanced ? "YES" : "NO");
        }
    }
}
