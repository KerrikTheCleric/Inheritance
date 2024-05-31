using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance.Animals.Birds {
    internal class Pelican : Bird {

        private double _beakWaterVolume;

        public Pelican(string name, Colour colour, int age, double weight, bool loud, double beakWaterVolume) : base(name, colour, age, weight, loud) {
            BeakWaterVolume = beakWaterVolume;
        }

        public double BeakWaterVolume { get; set; }
    }
}
