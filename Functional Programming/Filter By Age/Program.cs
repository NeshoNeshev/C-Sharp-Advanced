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
            Dictionary<string, int> people = new Dictionary<string, int>();
            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries);
                string name = input[0];
                int age = int.Parse(input[1]);
                if (!people.ContainsKey(name))
                {
                    people.Add(name, age);
                }
            }

            string comand = Console.ReadLine();
            int second = int.Parse(Console.ReadLine());
            string secondCommand = Console.ReadLine();
            PrintResults(people, second, comand, secondCommand, YoungerAndOlder);

        }

        public static Dictionary<string, int> YoungerAndOlder(Dictionary<string, int> people, int age, string yearsOld)
        {
            Dictionary<string, int> newDickt = new Dictionary<string, int>();

            if (yearsOld == "younger")
            {
                var dickt = people.Where(x => x.Value < age);
                foreach (var item in dickt)
                {
                    newDickt.Add(item.Key, item.Value);
                }
            }

            if (yearsOld == "older")
            {
                var dickt = people.Where(x => x.Value >= age);
                foreach (var item in dickt)
                {
                    newDickt.Add(item.Key, item.Value);
                }
            }

            return newDickt;
        }

        static void PrintResults(Dictionary<string, int> dickt, int age, string yearsOld, string command,
            Func<Dictionary<string, int>, int, string, Dictionary<string, int>> sorted)
        {
            var sort = sorted(dickt, age, yearsOld);
            if (command == "name")
            {
                Console.WriteLine(string.Join("\n", sort.Keys));
            }

            if (command == "age")
            {
                Console.WriteLine(string.Join("\n", sort.Values));
            }

            if (command == "name age")
            {
                foreach (var item in sort)
                {
                    Console.WriteLine($"{item.Key} - {item.Value}");
                }
            }
        }
    }
}
