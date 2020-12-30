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
            int bulet = int.Parse(Console.ReadLine());
            int sizeBarel = int.Parse(Console.ReadLine());
            var buletsSize = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var locks = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int intelligence = int.Parse(Console.ReadLine());
            Stack<int> bulets = new Stack<int>(buletsSize);
            Queue<int> lockses = new Queue<int>(locks);
            int size = sizeBarel;
            int shots = 0;
            while (true)
            {

                if (size == 0 && bulets.Count > 0)
                {
                    Console.WriteLine("Reloading!");
                    size = sizeBarel;

                }
                if (bulets.Count == 0)
                {
                    break;
                }
                if (lockses.Count == 0)
                {
                    break;
                }
                size--;
                int shot = bulets.Pop();
                int loock = lockses.Peek();

                if (shot <= loock)
                {
                    Console.WriteLine("Bang!");
                    lockses.Dequeue();
                    shots++;
                }
                else
                {
                    Console.WriteLine("Ping!");
                    shots++;
                }
            }
            int moneyEarned = intelligence - (shots * bulet);
            if (bulets.Count == 0 && moneyEarned > 0 && lockses.Count == 0)
            {
                Console.WriteLine($"{bulets.Count} bullets left. Earned ${moneyEarned}");
            }
            else if (bulets.Count == 0)
            {
                Console.WriteLine($"Couldn't get through. Locks left: {lockses.Count}");
            }
            else if (lockses.Count == 0)
            {

                Console.WriteLine($"{bulets.Count} bullets left. Earned ${moneyEarned}");
            }
        }
    }
}
