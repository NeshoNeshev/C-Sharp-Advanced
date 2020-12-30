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
            var inputCups = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var inputBottles = Console.ReadLine().Split().Select(int.Parse).ToArray();
            Queue<int> cups = new Queue<int>(inputCups);
            Stack<int> bottles = new Stack<int>(inputBottles);

            int wastedLiters = 0;
            while (cups.Count > 0 && bottles.Count > 0)
            {
                int cupCapacity = cups.Peek();
                int botlleCapacity = bottles.Peek();

                if (cupCapacity <= botlleCapacity)
                {
                    cups.Dequeue();
                    bottles.Pop();
                    wastedLiters += (botlleCapacity - cupCapacity);
                }
                else
                {
                    cupCapacity -= botlleCapacity;

                    Queue<int> newQueue = new Queue<int>();
                    cups.Dequeue();
                    newQueue.Enqueue(cupCapacity);
                    foreach (var item in cups)
                    {
                        newQueue.Enqueue(item);
                    }
                    cups = newQueue;
                    bottles.Pop();
                }
            }
            if (cups.Count > 0)
            {
                Console.WriteLine($"Cups: {string.Join(" ", cups)}");
                Console.WriteLine($"Wasted litters of water: {wastedLiters}");
            }
            if (bottles.Count > 0)
            {
                Console.WriteLine($"Bottles: {string.Join(" ", bottles)}");
                Console.WriteLine($"Wasted litters of water: {wastedLiters}");
            }
        }
    }
}
