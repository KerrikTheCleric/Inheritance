namespace Inheritance {
    internal class Program {
        static void Main(string[] args) {

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
        }
    }
}
