using AbstractionProject.Models;

namespace AbstractionProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            return;
            ProgrammerEngineer programmerEnginer = new ProgrammerEngineer();

            programmerEnginer.Name = "ProgrammerEngineer";
            programmerEnginer.Surname = "ProgrammerEngineer";
            programmerEnginer.Id = 1;
            programmerEnginer.Knowledges = new string[] { "ProgrammerEngineer 1", "ProgrammerEngineer 2" };
            programmerEnginer.Language = "C#";
            Console.WriteLine(programmerEnginer.Detail());
            programmerEnginer.Work();


            Console.WriteLine();
            Console.WriteLine("===============================================================================================");
            Console.WriteLine();

            DesingEngineer desingEngineer = new DesingEngineer();

            desingEngineer.Name = "DesingEngineer";
            desingEngineer.Surname = "DesingEngineer";
            desingEngineer.Id = 2;
            desingEngineer.Knowledges = new string[] { "DesingEngineer 1", "DesingEngineer 2" };
            desingEngineer.MarkUpLanguage = "Htnl";
            Console.WriteLine(desingEngineer.Detail());
            desingEngineer.Work();

            //Person[] persons =   { programmerEnginer, desingEngineer };

            //foreach (Person person in persons)
            //{
            //    Console.WriteLine(person.Name);
            //}



            FrontEnd frontEnd = new FrontEnd();
            frontEnd.Name = "FrontEnd";
            frontEnd.Surname = "FrontEnd";
            frontEnd.Id = 2;
            frontEnd.Knowledges = new string[] { "FrontEnd 1", "FrontEnd 2" };
            frontEnd.Language = "Fr";
            Console.WriteLine(frontEnd.Detail());



        }
    }
    

}
