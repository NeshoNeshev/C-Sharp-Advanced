using System;
using System.Linq;

namespace GenericBoxOfString
{
    public class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Box<string> box = new Box<string>();
            for (int i = 0; i < n; i++)
            {
                string text = Console.ReadLine();
                box.Value.Add(text);
            }
            string input = Console.ReadLine();
            box.Counters(input);
            Console.WriteLine(box.Counter);
        }
    }
}
