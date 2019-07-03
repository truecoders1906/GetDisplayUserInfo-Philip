using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Cat
    {
        public string Name { get; set; }
        public string Color { get; set; }

        public void Meow()
        {
            Console.WriteLine("MEEEEOOOOW!!! I'm " + Name + "...");
        }
    }
}
