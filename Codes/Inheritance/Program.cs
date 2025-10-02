namespace Inheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Worker worker = new Worker("Samir");          
            worker.Surname = "Xasiyev";
            worker.Age = 25;
            worker.Profession = "Programmer";
            worker.Info();
            Console.WriteLine("------------------------------------");
            worker.FullInfo();

            Console.WriteLine();
            Console.WriteLine();

            Student student = new Student("Elnur");
            student.Surname = "Eliyev";
            student.Age = 23;
            student.Point = 99;
            student.Info();
            Console.WriteLine("------------------------------------");
            student.FullInfo();
        }
    }
}
