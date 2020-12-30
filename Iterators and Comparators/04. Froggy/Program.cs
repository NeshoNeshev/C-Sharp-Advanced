using System;
using System.Linq;

namespace Froggy
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();
            Frog lake = new Frog(numbers);
            Console.WriteLine(string.Join(", ", lake));
        }
    }
}
