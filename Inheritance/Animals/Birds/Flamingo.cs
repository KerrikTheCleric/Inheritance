using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance.Animals.Birds {
    internal class Flamingo : Bird {

        private bool _isFabulous;

        public Flamingo(string name, Colour colour, int age, double weight, bool loud, bool isFabulous) : base(name, colour, age, weight, loud) {
            IsFabulous = isFabulous;
        }

        public bool IsFabulous { get; set; }
    }
}
