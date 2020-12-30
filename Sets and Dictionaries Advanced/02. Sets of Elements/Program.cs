using System;
using System.Collections.Generic;
using System.Linq;


namespace Advanced
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            HashSet<string> firstElements = new HashSet<string>();
            HashSet<string> secondElements = new HashSet<string>();
            HashSet<string> finalElements = new HashSet<string>();
            for (int i = 0; i < numbers[0]; i++)
            {
                string elemnet = Console.ReadLine();
                firstElements.Add(elemnet);
            }
            for (int i = 0; i < numbers[1]; i++)
            {
                string elemnet = Console.ReadLine();
                secondElements.Add(elemnet);
            }
            foreach (var item in firstElements)
            {
                if (secondElements.Contains(item))
                {
                    finalElements.Add(item);
                }
            }
            Console.Write($"{string.Join(" ", finalElements)}");
        }
    }
}
