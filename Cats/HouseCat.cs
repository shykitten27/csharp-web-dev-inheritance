﻿using System;

namespace Cats
{
    public class HouseCat : Cat //HouseCat extends Cat
    {
        public string Name { get; set; }
        public string Species { get; } = "Felis catus";


        public HouseCat(string name, double weight) : base(weight) // passing the weight to the base aka parent class
        {
            Name = name;
        }

        // On this line, write a constructor that uses the no-arg constructor in the Cat class.
        public HouseCat(string name)
        {
            Name = name;
        }

        public bool IsSatisfied()
        {
            return !Hungry && !Tired;
        }

        public override string Noise()
        {
            if (IsSatisfied())
            {
                return "Hello, my name is " + Name + "!";
            }
            else
            {
                return base.Noise(); // prints "Meow!"
            }
        }

        public string Purr()
        {
            return "I'm a housecat";
        }
    }
}