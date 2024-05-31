using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance.Animals
{
    internal class Dog : Animal
    {
        private string? _breed;

        public Dog(string name, Colour colour, int age, double weight, string breed) : base(name, colour, age, 4, weight){
            Breed = breed;
        }

        public string Breed { get; set; }

        public override void DoSound(){
            Console.WriteLine("Bark! Bark! Bark!");
        }

        public string Whimper() {
            return "*Whiiiiine*";
        }

        public override string Stats() {
            return $"{Name} - {Colour} - Age: {Age} - Legs: {Legs} - Weight: {Weight} - Breed: {Breed}";
        }
    }
}
