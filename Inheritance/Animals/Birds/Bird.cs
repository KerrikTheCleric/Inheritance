using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance.Animals.Birds
{
    internal class Bird : Animal
    {

        private bool _loud;

        public Bird(string name, Colour colour, int age, double weight, bool loud) : base(name, colour, age, 2, weight)
        {
            Loud = loud;
        }

        public bool Loud { get; set; }

        public override void DoSound()
        {
            Console.WriteLine("Chirp Chirp!");
        }
    }
}
