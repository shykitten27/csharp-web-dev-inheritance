using System;
using System.Collections.Generic;
using System.Text;

namespace Cats
{
    class Tabby : HouseCat //Tabby extends HouseCat
    {
        public Tabby(string name, double weight) : base(name, weight)
        {
        }
        public override string Noise()
        {
            return "Hello, my name is " + Name + " and I am drunk again."; //Scott's cat
        }

        public void Snuggle()
        {

        }
    }
}