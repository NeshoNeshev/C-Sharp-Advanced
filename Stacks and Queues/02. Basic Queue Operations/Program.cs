using System;
using System.Collections.Generic;
using System.Linq;

namespace Advanced
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int push = input[0];
            int pop = input[1];
            int check = input[2];
            var numbers = new Queue<int>();

            var arr = Console.ReadLine().Split().Select(int.Parse).ToArray();
            for (int i = 0; i < push; i++)
            {
                numbers.Enqueue(arr[i]);
            }
            for (int i = 0; i < pop; i++)
            {
                numbers.Dequeue();
            }
            if (numbers.Contains(check))
            {
                Console.WriteLine("true");
            }
            else if (numbers.Count == 0)
            {
                Console.WriteLine("0");
            }
            else
            {
                Console.WriteLine(numbers.Min());
            }
        }
    }
}
