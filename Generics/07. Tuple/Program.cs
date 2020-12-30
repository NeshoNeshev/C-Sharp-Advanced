using System;

namespace Tuple
{
    class Program
    {
        static void Main(string[] args)
        {
            var firstInput = Console.ReadLine().Split();
            string fullName = $"{firstInput[0]} {firstInput[1]}";
            string adres = firstInput[2];
            Tuple<string, string> nameAndAdres = new Tuple<string, string>(fullName, adres);

            var secondInput = Console.ReadLine().Split();
            string name = secondInput[0];
            int litersOfBeer = int.Parse(secondInput[1]);

            Tuple<string, int> nameLitersBeer = new Tuple<string, int>(name,litersOfBeer);

            var thirdInput = Console.ReadLine().Split();
            int integer = int.Parse(thirdInput[0]);
            double doubled = double.Parse(thirdInput[1]);

            Tuple<int, double> numbers = new Tuple<int, double>(integer,doubled);

            Console.WriteLine(nameAndAdres);
            Console.WriteLine(nameLitersBeer);
            Console.WriteLine(numbers);
        }
    }
}
