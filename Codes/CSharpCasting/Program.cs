using CSharpCasting.Models;

namespace CSharpCasting
{
    internal class Program
    {
        static void Main(string[] args)
        {

           
            Manat manat = new Manat(510);
            Dollar dollar = manat; // implicit conversion
            Console.WriteLine(dollar.USD);


            return;

            // Upcasting,boxing,implicit conversion

            ProgrammerEngineer programmerEngineer = new ProgrammerEngineer();
            programmerEngineer.Id = 1;
            programmerEngineer.Name = "John";
            programmerEngineer.Languages = new string[] { "C#", "Java", "Python" };
            programmerEngineer.Knowledges = new string[] { "OOP", "Design Patterns", "Algorithms" };
            //programmerEngineer.Detail();

            

            DesingEngineer desingEngineer = new DesingEngineer();
            desingEngineer.Id = 2;
            desingEngineer.Name = "Jane";
            desingEngineer.Tools = new string[] { "AutoCAD", "SolidWorks", "SketchUp" };
            desingEngineer.Knowledges = new string[] { "Project Management", "Agile", "Scrum" };
            //desingEngineer.Detail();

          


            Person[] person = new Person[] { programmerEngineer, desingEngineer};

            foreach (var item in person)
            {
                Console.WriteLine(item.Name);
            }


            // Downcasting,unboxing,explicit conversion

            foreach (var item in person) // Etap 1
            {
                ProgrammerEngineer programmer = (ProgrammerEngineer)item; // Exception ola biler
                Console.WriteLine(string.Join(',', programmer.Languages));

            }

            foreach (var item in person) // Etap 2
            {
                if (item is ProgrammerEngineer)
                {
                    ProgrammerEngineer programmer = (ProgrammerEngineer)item; // Exception ola bilmez
                    Console.WriteLine(string.Join(',', programmer.Languages));
                }
            }

            foreach (var item in person) // Etap 3
            {
                if (item is ProgrammerEngineer p)
                {
                    Console.WriteLine(string.Join(',', p.Languages));
                }
            }

            foreach (var item in person) // Etap 4
            {
                ProgrammerEngineer programmer = item as ProgrammerEngineer;
                if (programmer != null)
                {
                    Console.WriteLine(string.Join(',', programmer.Languages));
                }
            }
        }
    }
}
