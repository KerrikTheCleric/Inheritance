using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance.Animals
{
    internal class Horse : Animal
    {
        private int _topSpeed;

        public Horse(string name, Colour colour, int age, double weight, int topSpeed) : base(name, colour, age, 4, weight){
            TopSpeed = topSpeed;
        }

        public int TopSpeed { get; set; }

        public override void DoSound(){
            Console.WriteLine("Neeeeheeeheee!"); 
        }

        public override string Stats() {
            return $"{Name} - {Colour} - Age: {Age} - Legs: {Legs} - Weight: {Weight} - Top Speed: {TopSpeed}";
        }
    }
}
