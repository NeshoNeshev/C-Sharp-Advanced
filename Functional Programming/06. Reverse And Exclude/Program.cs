using System;
using System.Collections.Generic;
using System.Linq;


namespace Advanced
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
            List<int> reverse = new List<int>();
            int n = int.Parse(Console.ReadLine());
            Predicate<int> divide = x => x % n == 0;
            foreach (var item in numbers)
            {
                if (!divide(item))
                {
                    reverse.Add(item);
                }

            }
            reverse.Reverse();
            Console.WriteLine(string.Join(" ", reverse));
        }
        
    }
}
