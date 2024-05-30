using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance {

    
    internal class Person {

        private int _age;
        private string? _fName;
        private string? _lName;
        private double _height;
        private double _weight;

        public Person(int age, string fName, string lName, double height, double weight) {
            Age = age;
            FName = fName;
            LName = lName;
            Height = height;
            Weight = weight;
        }

        public int Age {
            get { return _age; }
            set {
                if (value > 0) {
                    _age = value;
                } else {
                    throw new ArgumentException("Age must be over 0!");
                }
            }
        }

        public string FName {

            get { return _fName; }
            set {
                if (value.Length >= 2 && value.Length <= 10) {
                    _fName = value;
                } else {
                    throw new ArgumentException("Length of FName must be 2-10 characters long!");
                }
            }
        }

        public string LName {
            get { return _lName; }
            set {
                if (value.Length >= 3 && value.Length <= 15) {
                    _lName = value;
                } else {
                    throw new ArgumentException("Length of LName must be 3-15 characters long!");
                }
            }

        }

        public double Height { get; set; }

        public double Weight { get; set; }

        public override string ToString() {

            if (Age == 1) {
                return $"{FName} {LName} - {Age} year old, height is {Height} and weight is {Weight}";
            } else {
                return $"{FName} {LName} - {Age} years old, height is {Height} and weight is {Weight}";
            }
        }


    }
}
