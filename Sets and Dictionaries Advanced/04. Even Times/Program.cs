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

            Dictionary<int, int> nums = new Dictionary<int, int>();

            for (int i = 0; i < n; i++)
            {
                int number = int.Parse(Console.ReadLine());
                if (!nums.ContainsKey(number))
                {
                    nums.Add(number, 1);
                }
                else
                {
                    nums[number]++;
                }

            }
            foreach (var item in nums)
            {
                if (item.Value % 2 == 0)
                {
                    Console.WriteLine(item.Key);
                    break;
                }
            }
        }
    }
}
