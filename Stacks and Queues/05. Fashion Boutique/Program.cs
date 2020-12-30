using System;
using System.Collections.Generic;
using System.Linq;

namespace Advanced
{
    class Program
    {
        static void Main(string[] args)
        {
            var clothesInBox = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int boxCapacity = int.Parse(Console.ReadLine());
            Stack<int> clothes = new Stack<int>(clothesInBox);
            int a = 0;
            int n = 0;

            while (true)
            {
                int af = clothes.Peek();

                n += clothes.Pop();
                if ((n) > boxCapacity)
                {
                    clothes.Push(af);
                    a++;
                    n = 0;

                }
                if (clothes.Count == 0)
                {
                    a++;
                    break;
                }
            }
            Console.WriteLine(a);
        }
    }
}
