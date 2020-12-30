using System;
using System.Linq;


namespace Advanced
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split(", ").Select((number) =>
            {
                return int.Parse(number);
            }).ToArray();

            PrintResults(numbers, SumNumbers, CountArray);
        }
        public static int SumNumbers(int[] arr)
        {
            return arr.Sum();
        }
        public static int CountArray(int[] arr)
        {
            return arr.Length;
        }
        static void PrintResults(int[] array, Func<int[], int> count, Func<int[], int> sum)
        {
            Console.WriteLine(string.Join("\n", sum(array), count(array)));

        }
    }
}
