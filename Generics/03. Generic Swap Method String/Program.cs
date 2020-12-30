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
            var swapedIndex = Console.ReadLine().Split().Select(int.Parse).ToArray();
            box.Swap(swapedIndex[0], swapedIndex[1]);
            foreach (var item in box.Value)
            {
                Console.WriteLine($"{item.GetType()}: {item}");
            }
        }
    }
}
