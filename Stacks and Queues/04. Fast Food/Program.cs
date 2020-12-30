using System;
using System.Collections.Generic;
using System.Linq;

namespace Advanced
{
    class Program
    {
        static void Main(string[] args)
        {
            int food = int.Parse(Console.ReadLine());
            var order = Console.ReadLine().Split().Select(int.Parse).ToArray();
            Queue<int> orders = new Queue<int>(order);

            if (orders.Count > 0)
            {
                Console.WriteLine(orders.Max());
            }
            while (orders.Count > 0)
            {

                if (orders.Peek() <= food)
                {
                    food -= orders.Dequeue();
                }
                else
                {
                    break;
                }
                if (food <= 0)
                {
                    break;
                }

            }
            if (orders.Count > 0)
            {
                Console.WriteLine($"Orders left: {string.Join(" ", orders)}");
            }
            else
            {
                Console.WriteLine("Orders complete");
            }
        }
    }
}
