namespace OperatorOverloading
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student student1 = new Student(1, "Samir");
            Student student2 = new Student(33, "Elmar");

            //Console.WriteLine(student1>student2);

            Student[] students= {student1,student2,new Student(5,"Asif")};
            Array.Sort(students);
            foreach (var item in students)
            {
                Console.WriteLine(item.Name);
            }
        }
    }
}
