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
            SortedSet<string> uniqueElements = new SortedSet<string>();

            for (int i = 0; i < n; i++)
            {
                var elements = Console.ReadLine().Split();
                for (int j = 0; j < elements.Length; j++)
                {
                    uniqueElements.Add(elements[j]);
                }
            }
            Console.WriteLine(string.Join(" ", uniqueElements));
        }
    }
}
