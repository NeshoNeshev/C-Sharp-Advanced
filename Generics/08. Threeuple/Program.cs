using System;

namespace Tuple
{
    public class Program
    {
        static void Main(string[] args)
        {
            var firstInput = Console.ReadLine().Split();
            string fullName = $"{firstInput[0]} {firstInput[1]}";
            string adress = firstInput[2];
            string town = string.Empty;
            if (firstInput.Length <= 4)
            {
                town = firstInput[3];
            }
            else
            {
                town = $"{firstInput[3]} {firstInput[4]}";
            }

            Threeuple<string, string, string> nameTownAdres = new Threeuple<string, string, string>(fullName, adress, town);

            var secondInput = Console.ReadLine().Split();
            string name = secondInput[0];
            int litersOfBeers = int.Parse(secondInput[1]);
            string drunkOrNo = secondInput[2];
            

            Threeuple<string, int, bool> drunk = new Threeuple<string, int, bool>(name, litersOfBeers, IsDrunk(drunkOrNo) );

            var thirdInput = Console.ReadLine().Split();
            string anotherName = thirdInput[0];
            double accountBalance = double.Parse(thirdInput[1]);
            string bankName = thirdInput[2];
            Threeuple<string, double, string> bank = new Threeuple<string, double, string>(anotherName, accountBalance, bankName);

            Console.WriteLine(nameTownAdres);
            Console.WriteLine(drunk);
            Console.WriteLine(bank);


        }
        public static bool IsDrunk(string text)
        {

            if (text =="drunk")
            {
                return true;
            }
            else
            {
                return false;
            }
        }
       
    }
}
