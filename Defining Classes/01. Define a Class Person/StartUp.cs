using System;

namespace DefiningClasses
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            //            Name Age
            //Pesho   20
            //Gosho   18
            //Stamat  43
            

            Person firstP = new Person //inline initialisation with {}
            { 
                Name = "Pesho", 
                Age = 20 
            };
           Person firstP1 = new Person("Pesho",20);

            Person secondP = new Person
            {
                Name = "Gosho",
                Age = 18
            };
            Person secondP1 = new Person("Gosho", 18);

            Person thirdP = new Person
            {
                Name = "Stamat",
                Age = 43
            };
            Person thirdP1 = new Person("Stamat", 43);

            //Console.WriteLine($"{firstP.Name} -> {firstP.Age}");
        }
    }
}
