using System;
using System.Collections.Generic;
using System.Text;

namespace AnimalClass

{
    internal class Animal
    {
        public string Name { get; set; }

        public void Eat()
        {
            Console.WriteLine(Name + " is eating");
        }
        public void Sleep()
        {
            Console.WriteLine(Name + " is sleeping");
        }
    }
}
