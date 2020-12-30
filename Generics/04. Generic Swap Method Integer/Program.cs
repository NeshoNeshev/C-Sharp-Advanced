using System;
using System.Linq;

namespace GenericBoxOfString
{
    public class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Box<int> box = new Box<int>();
            for (int i = 0; i < n; i++)
            {
                int number = int.Parse(Console.ReadLine());
                box.Value.Add(number);
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
