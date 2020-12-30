using System;
using System.Collections.Generic;
using System.Linq;

namespace Advanced
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            var numbers = new Stack<int>();
            for (int i = 0; i < n; i++)
            {
                var arr = Console.ReadLine().Split().Select(int.Parse).ToArray();
                if (arr[0] == 3)
                {
                    if (numbers.Count != 0)
                    {
                        Console.WriteLine(numbers.Max());
                    }
                }
                if (arr[0] == 4)
                {
                    if (numbers.Count != 0)
                    {
                        Console.WriteLine(numbers.Min());
                    }
                }
                if (arr[0] == 1)
                {
                    int num = arr[1];
                    numbers.Push(num);
                }
                if (arr[0] == 2)
                {
                    if (numbers.Count > 0)
                    {
                        numbers.Pop();
                    }

                }
            }
            if (numbers.Count != 0)
            {
                Console.WriteLine(string.Join(", ", numbers));
            }
        }
    }
}
