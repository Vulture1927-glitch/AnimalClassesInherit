using System;
using System.Collections.Generic;
using System.Text;
using AnimalClass;

namespace BirdClass
{
    internal class Bird : Animal
    {
        public void Fly()
        {
            Console.WriteLine(Name +" is flying");
        }
    }
}
