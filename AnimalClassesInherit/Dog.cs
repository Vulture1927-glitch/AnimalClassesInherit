using System;
using System.Collections.Generic;
using System.Text;
using AnimalClass;

namespace DogClass
{
    internal class Dog : Animal
    {
        public void Bark()
        {
            Console.WriteLine(Name + " is barking");
        }
    }
}
