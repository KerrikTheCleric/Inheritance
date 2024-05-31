using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance.Animals.Birds { 
    internal class Swan : Bird{

        private int _divingSpeed;

        public Swan(string name, Colour colour, int age, double weight, bool loud, int divingSpeed) : base(name, colour, age, weight, loud) {
            DivingSpeed = divingSpeed;
        }

        public int DivingSpeed { get; set; }
    }
}
