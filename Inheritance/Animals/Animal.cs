using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Inheritance.Animals
{
    internal abstract class Animal
    {
        private string? _name;
        private Colour _colour;
        private int _age;
        private int legs;
        private double weight;



        public Animal(string name, Colour colour, int age, int legs, double weight)
        {
            Name = name;
            Colour = colour;
            Age = age;
            Legs = legs;
            Weight = weight;
        }

        public string Name { get; set; }

        public Colour Colour { get; set; }

        public int Age { get; set; }

        public int Legs { get; set; }

        public double Weight { get; set; }

        public abstract void DoSound();

    }
}
