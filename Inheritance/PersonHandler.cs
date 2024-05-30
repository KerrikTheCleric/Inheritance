using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance {
    internal class PersonHandler {

        public Person CreatePerson(int age, string fname, string lname, double height, double weight) {
            return new Person(age, fname, lname, height, weight);
        }

        public void SetAge(Person pers, int age) {
            pers.Age = age;
        }

        public int GetAge(Person pers) {
            return pers.Age;
        }

        public void SetFirstName(Person pers, string fname) {
            pers.FName = fname;
        }

        public string GetFirstName(Person pers) {
            return pers.FName;
        }


        public void SetLastName(Person pers, string lname) {
            pers.LName = lname;
        }

        public string GetLastName(Person pers) {
            return pers.LName;
        }


        public void SetHeight(Person pers, double height) {
            pers.Height = height;
        }

        public double GetHeight(Person pers) {
            return pers.Height;
        }


        public void SetWeight(Person pers, double weight) {
            pers.Weight = weight;
        }

        public double GetWeight(Person pers) {
            return pers.Weight;
        }


        public void PrintPerson (Person pers) {
            Console.WriteLine(pers.ToString());
        }

    }
}
