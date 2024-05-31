using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance.Animals {
    internal class Worm : Animal {

        private bool canDance;

        public Worm(string name, Colour colour, int age, double weight, bool canDance) : base(name, colour, age, 0, weight) {
            CanDance = canDance;
        }

        public bool CanDance { get; set; }

        public override void DoSound() {
            Console.WriteLine("...");
        }
    }
}
