using Inheritance.Errors;
using Inheritance.Animals;
using Inheritance.Animals.Birds;

namespace Inheritance
{
    internal class Program {
        static void Main(string[] args) {

            // Inkapsling

            PersonHandler pHandler = new PersonHandler();
            Person p1;

            try {
                p1 = pHandler.CreatePerson(20, "Belle", "Stevens", 160.5, 67);
                pHandler.PrintPerson(p1);

                pHandler.SetLastName(p1, "Dubois");
                pHandler.SetAge(p1, 44);
                pHandler.PrintPerson(p1);

            } catch (Exception e) {
                Console.WriteLine(e.Message);
            }

            try {
                p1 = pHandler.CreatePerson(1, "Hans", "Glimmer", 30, 15);
                pHandler.PrintPerson(p1);
                pHandler.SetLastName(p1, "bbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbb");
            } catch (Exception e) {
                Console.WriteLine(e.Message);
            }

            // Polymorfism

            Console.WriteLine("");
            List<UserError> errorList = new List<UserError>();
            errorList.Add(new XMLInputError());
            errorList.Add(new TransferProtocolError());
            errorList.Add(new XMLInputError());
            errorList.Add(new NumericInputError());
            errorList.Add(new FileError());
            errorList.Add(new TextInputError());

            foreach (UserError error in errorList) {
                Console.WriteLine(error.UEMessage());
            }

            // Arv

            Hedgehog hedgehog = new Hedgehog("Sonic", Colour.Blue, 20, 55.9, 16);
            Wolf wolf = new Wolf("Ripper", Colour.Brown, 3, 67.4, 250);
            Wolfman wolfman = new Wolfman("Blythe", Colour.Brown, 50, 125.7, 313.5);
            Console.WriteLine("");
            hedgehog.DoSound();
            wolf.DoSound();
            wolfman.DoSound();
            wolfman.Talk();

            // 13. Då lägger vi till ett nytt attribut i Bird.
            // 14. Då lägger vi till ett nytt attribut i Animal.

            // Mer Polymorfism

            Dog dog = new Dog("Scratch", Colour.Orange, 2, 35.7, "Shiba Inu");
            Pelican pelican = new Pelican("Davis", Colour.White, 4, 25.9, true, 13.5);
            Horse horse = new Horse("Rocketeer", Colour.Black, 2, 100.7, 90);
            Worm worm = new Worm("Jim", Colour.White, 1, 0.5, false);
            Flamingo flamingo = new Flamingo("Quixote", Colour.Pink, 3, 33.3, false, true);
            Swan swan = new Swan("Elsa", Colour.White, 4, 45, false, 35);

            List<Animal> animalList = new List<Animal>();
            animalList.Add(hedgehog);
            animalList.Add(wolf);
            animalList.Add(wolfman);
            animalList.Add(dog);
            animalList.Add(pelican);
            animalList.Add(horse);
            animalList.Add(worm);
            animalList.Add(flamingo);
            animalList.Add(swan);

            foreach (var a in animalList) {
                Console.WriteLine(a);
                a.DoSound();

                if (a is IPerson) {
                    IPerson iP = (IPerson)a;
                    iP.Talk();
                }
                Console.WriteLine("");
            }

            List<Dog> dogList = new List<Dog>();

            //dogList.Add(horse);

            // 9. En lista med hundar innebär att objektet som läggs till måste vara en hund eller ärva från hund. Häst gör inte det.
            // 10. Eftersom Person och Animal representerar egna släkter så måste listan bestå av grundtypen Object för att kunna lagra allting.

            foreach (var a in animalList) {
                Console.WriteLine(a.Stats());
            }
            Console.WriteLine("");

            //13. Alla djur gör en en egen override på Stats som returnerar en sträng att skriva ut.
            //    Fågelarterna gör en extra överride på Bird där dom appendar sin unika egenskap på slutet av strängen.

            foreach (Dog d in animalList.OfType<Dog>()) {
                Console.WriteLine(d.Stats());
            }
            Console.WriteLine("");


            //17. Listan vet endast att allting inuti är ett Animal, den har ingen aning vad som är en hund med den metoden om man inte kollar det.

            foreach (var a in animalList) {
                if (a is Dog) {
                    Dog d = (Dog)a;
                    Console.WriteLine(d.Whimper());
                }
            }
        }
    }
}
