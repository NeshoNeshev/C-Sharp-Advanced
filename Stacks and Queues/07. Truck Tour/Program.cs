using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Advanced
{
    class Program
    {
        static void Main(string[] args)
        {
            int numbersOfpomps = int.Parse(Console.ReadLine());
            Queue<string> circle = new Queue<string>();
            for (int i = 0; i < numbersOfpomps; i++)
            {
                string input = Console.ReadLine();
                input += $" {i}";
                circle.Enqueue(input);
            }
            int totalFuel = 0;
            for (int i = 0; i < numbersOfpomps; i++)
            {
                string currentInput = circle.Dequeue();
                var info = currentInput.Split().Select(int.Parse).ToArray();
                var fuel = info[0];
                var distance = info[1];
                totalFuel += fuel;
                if (totalFuel >= distance)
                {
                    totalFuel -= distance;
                }
                else
                {
                    totalFuel = 0;
                    i = -1;

                }
                circle.Enqueue(currentInput);
            }
            var firstElement = circle.Dequeue().Split().ToArray();
            Console.WriteLine(firstElement[2]);
        }
    }
}
