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
            var names = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToList();
            List<string> validNames = new List<string>();
            Predicate<string> namesLenght = x => x.Length <= n;
            foreach (var item in names)
            {
                if (namesLenght(item))
                {
                    validNames.Add(item);
                }
            }

            Console.WriteLine(string.Join("\n", validNames));
        }
    }
}
