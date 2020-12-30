using System;

namespace DefiningClasses
{
    public class StartUp
    {
        static void Main(string[] args)
        {

            Person firstP = new Person //inline initialisation with {}
            {
                Name = "Pesho",
                Age = 20
            };
            Person firstP2 = new Person(20);

            Person firstP1 = new Person("Pesho", 20);


        }
    }
}
