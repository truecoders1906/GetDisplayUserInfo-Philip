using System;

namespace ConsoleApp1
{
    class Dog
    {
        public Dog(string dogName)
        {
            Name = dogName;
            Console.WriteLine("Instantiating Dog....");
        }

        public string Name { get; set; }
        public int NumberOfLegs { get; set; }

        public void Speak()
        {
            Console.WriteLine("Ruff my name is " + Name + "!") ;
        {

        }
        }
    }
}
