using System;
using System.Collections.Generic;
using System.Text;
using AnimalClass;

namespace CatClass
{
    internal class Cat : Animal
    {
        public void Meow()
        {
            Console.WriteLine(Name + " is meowing");
        }
    }
}
