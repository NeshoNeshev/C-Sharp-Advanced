using System;
using System.Collections.Generic;
using System.Linq;


namespace Advanced
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            var array = text.ToCharArray();
            SortedDictionary<char, int> countSymbol = new SortedDictionary<char, int>();
            for (int i = 0; i < array.Length; i++)
            {
                if (!countSymbol.ContainsKey(array[i]))
                {
                    countSymbol.Add(array[i], 1);
                }
                else
                {
                    countSymbol[array[i]]++;
                }
            }
            foreach (var item in countSymbol)
            {
                Console.WriteLine($"{item.Key}: {item.Value} time/s");
            }
        }
    }
}
