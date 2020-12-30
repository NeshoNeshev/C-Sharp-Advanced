using System;
using System.Linq;

namespace GenericBoxOfString
{
    public class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Box<double> box = new Box<double>();
            for (int i = 0; i < n; i++)
            {
                double number = double.Parse(Console.ReadLine());
                box.Value.Add(number);
            }
            double input = double.Parse(Console.ReadLine());
            box.Counters(input);
            Console.WriteLine(box.Counter);
        }
    }
}
