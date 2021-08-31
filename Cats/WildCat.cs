using System;
using System.Collections.Generic;
using System.Text;

namespace Cats
{
    class WildCat : Cat //WildCat extends Cat
    {
        public string Region { get; set; }
        public string Climate { get; set; }
        public WildCat(double weight) : base(weight)
        {
        }

    }
}