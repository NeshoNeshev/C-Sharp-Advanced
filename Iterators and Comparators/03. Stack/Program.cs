using System;
using System.Linq;

namespace Stack
{
    public class Program
    {
        static void Main(string[] args)
        {
            CustoStack<string> myStack = new CustoStack<string>();
            while (true)
            {
                var input = Console.ReadLine();
                string[] command = input.Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries);
                if (command[0] == "END")
                {
                    break;
                }
                if (command[0] == "Push")
                {
                    foreach (var item in command.Skip(1))
                    {
                        myStack.Push(item);
                    }
                }
                else if (command[0] == "Pop")
                {
                    try
                    {
                        myStack.Pop();
                    }
                    catch (InvalidOperationException e)
                    {

                        Console.WriteLine(e.Message);
                    }
                }
            }
            if (myStack.count > 0)
            {
                for (int i = 0; i < 2; i++)
                {
                    foreach (var item in myStack)
                    {
                        Console.WriteLine(item);
                    }
                }
            }
            else
            {
                Console.WriteLine("No elements");
            }
        }
    }
}
