using System;
using System.Linq;


namespace Advanced
{
    class Program
    {
        static void Main(string[] args)
        {

            var numbers = Console.ReadLine().Split(", ")
                .Select((number) =>
                {
                    return int.Parse(number);

                })
                .Where(x => x % 2 == 0)
                .OrderBy((int x) =>
                {
                    return x;
                })
                .ToArray();
            Console.WriteLine(string.Join(", ", numbers));
        }
    }
}
