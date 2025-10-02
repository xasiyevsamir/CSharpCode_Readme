using CSharpCeneric.Models;

namespace CSharpCeneric
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // NON-GENERIC
            #region NON-GENERIC example
            MyIntClass myInt = new MyIntClass();
            myInt.Add(10);
            myInt.AddRange(new int[] { 30, 40, 50 });
            myInt.Add(20);
            myInt.GetAll();

            #endregion


            // GENERIC
            #region GENERIC example
            CustomList<int> myGenericInt = new CustomList<int>();
            myGenericInt.Add(10);
            myGenericInt.AddRange(new int[] { 30, 40, 50 });
            myGenericInt.Add(20);
            myGenericInt.GetAll();

            CustomList<string> myGenericString = new CustomList<string>();
            myGenericString.Add("Hello");
            myGenericString.AddRange(new string[] { "World", "!" });
            myGenericString.Add("C# Generics");
            myGenericString.GetAll();

            CustomList<double> myGenericDouble = new CustomList<double>();
            myGenericDouble.Add(10.5);         
            myGenericDouble.AddRange(new double[] { 20.5, 30.5 });
            myGenericDouble.Add(40.5);
            myGenericDouble.GetAll();

            CustomList<Student> myGenericStudent = new CustomList<Student>();
            myGenericStudent.Add(new Student { Id = 1, Age=27, Name = "Alice" });
            myGenericStudent.AddRange(new Student[] {
                new Student { Id = 2, Age=25, Name = "Bob" },
                new Student { Id = 3, Age=33, Name = "Charlie" }
            });
            myGenericStudent.Add(new Student { Id = 4, Name = "Diana" });
            myGenericStudent.GetAll();

            #endregion
          
        }
    }
}
