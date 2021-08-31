using System;
using System.Collections.Generic;

namespace Cats
{
    class Program
    {
        public Cat Cat { get; set; } //check this out in diagram
        public List<Cat> Cats { get; set; } //check this out in diagram
        static void Main(string[] args)
        {
            // Try out your skills with inheritance here!
            HouseCat garfield = new HouseCat("Garfield", 12.0);
            garfield.Eat();
            Console.WriteLine(garfield.Tired);   // prints true

            HouseCat spike = new HouseCat("Spike");
            Console.WriteLine(spike.Weight);   // prints 13

            Cat plainCat = new Cat(8.6);
            HouseCat cheshireCat = new HouseCat("Cheshire Cat", 26.0);

            Console.WriteLine(plainCat.Noise()); // prints "Meow!"
            Console.WriteLine(cheshireCat.Noise()); // prints "Hello, my name is Cheshire Cat!"
        }
        public void Method(Cat cat)
        {
            Tabby tabby = cat as Tabby;
            tabby.Snuggle();
        }
    }
}