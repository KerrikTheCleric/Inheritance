using Inheritance.Animals;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance {
    internal class Wolfman : Wolf, IPerson {
        public Wolfman(string name, Colour colour, int age, double weight, double biteStrength) : base(name, colour, age, weight, biteStrength) {
        }

        public void Talk() {
            Console.WriteLine("Such a fine moon tonight.");
        }
    }
}
