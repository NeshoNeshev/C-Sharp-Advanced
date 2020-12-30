using System;
using System.Linq;


namespace Advanced
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            Func<int[], int> minNumbers = x => x.Min();
            Console.WriteLine(minNumbers(numbers)); 
        }
    }
}
