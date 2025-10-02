

namespace OperatorOverloading
{
    internal class Student : IComparable
    {
        public Student(int ıd, string name)
        {
            Id = ıd;
            Name = name;
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public static bool operator >(Student student1, Student student2)
        {
            return student1.Id > student2.Id;
        }

        public static bool operator <(Student student1, Student student2)
        {
            return student1.Id < student2.Id;
        }


        public override bool Equals(object? obj)
        {
            if (obj is null || obj is not Student) return false;

            Student? student = obj as Student;
            return student.Name == Name;
        }

        public int CompareTo(object? obj)
        {
            if (obj is null || obj is not Student) return -1;

            Student? student = obj as Student;
            return Id.CompareTo(student.Id);
        }

        
    }
}
