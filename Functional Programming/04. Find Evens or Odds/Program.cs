using System;
using System.Collections.Generic;
using System.Linq;


namespace Advanced
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            string command = Console.ReadLine();
            int start = numbers[0];
            int end = numbers[1];

            Predicate<int> create = EvenOrOdd(command, start, end);
            List<int> nums = new List<int>();
            if (start > end)
            {
                int n = end;
                end = start;
                start = n;
            }
            for (int i = start; i <= end; i++)
            {
                if (create(i))
                {
                    nums.Add(i);
                }
            }
            Console.WriteLine(string.Join(" ", nums));

        }
        public static Predicate<int> EvenOrOdd(string command, int start, int end)
        {

            if (command == "even")
            {
                return x => x % 2 == 0;
            }
            else if (command == "odd")
            {
                return x => x % 2 != 0;

            }
            else
            {
                return null;
            }
        }
    }
}
