using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance.Animals {

    internal class Hedgehog : Animal {

        private int _spikeCount;

        public Hedgehog(string name, Colour colour, int age, double weight, int spikeCount) : base(name, colour, age, 4, weight) {
            SpikeCount = spikeCount;
        }

        public int SpikeCount { get; set; }

        public override void DoSound() {
            Console.WriteLine("Sniff Sniff!");
        }
    }
}
