using System;
using System.Collections.Generic;



namespace Advanced
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Dictionary<string, Dictionary<string, int>> clothes = new Dictionary<string, Dictionary<string, int>>();
            for (int i = 0; i < n; i++)
            {
                var input = Console.ReadLine().Split(new string[] { " -> ", "," }, StringSplitOptions.RemoveEmptyEntries);
                if (!clothes.ContainsKey(input[0]))
                {
                    clothes.Add(input[0], new Dictionary<string, int>());
                    for (int j = 1; j < input.Length; j++)
                    {
                        if (!clothes[input[0]].ContainsKey(input[j]))
                        {
                            clothes[input[0]].Add(input[j], 1);
                        }
                        else
                        {
                            clothes[input[0]][input[j]] += 1;
                        }
                    }
                }
                else
                {
                    for (int j = 1; j < input.Length; j++)
                    {
                        if (!clothes[input[0]].ContainsKey(input[j]))
                        {
                            clothes[input[0]].Add(input[j], 1);
                        }
                        else
                        {
                            clothes[input[0]][input[j]] += 1;
                        }
                    }
                }
            }
            var dress = Console.ReadLine().Split();
            foreach (var item in clothes)
            {
                Console.WriteLine($"{item.Key} clothes:");
                foreach (var dres in item.Value)
                {
                    if (item.Key == dress[0])
                    {
                        if (dres.Key == dress[1])
                        {
                            Console.WriteLine($"* {dres.Key} - {dres.Value} (found!)");
                        }
                        else
                        {
                            Console.WriteLine($"* {dres.Key} - {dres.Value}");
                        }
                    }
                    else
                    {
                        Console.WriteLine($"* {dres.Key} - {dres.Value}");
                    }
                }
            }
        }
    }
}
