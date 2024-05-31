using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance.Animals {
    internal class Wolf : Animal {

        private double _biteStrength;

        public Wolf(string name, Colour colour, int age, double weight, double biteStrength) : base(name, colour, age, 4, weight) {
            BiteStrength = biteStrength;
        }

        public double BiteStrength { get; set; }

        public override void DoSound() {
            Console.WriteLine("Awooooo!");
        }

        public override string Stats() {
            return $"{Name} - {Colour} - Age: {Age} - Legs: {Legs} - Weight: {Weight} - Bite Strength: {BiteStrength}";

        }
    }
}
