using OrmPractice.Enum;

namespace OrmPractice.Entities
{
    internal class Student
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Surname { get; set; }

        public int Age { get; set; }

        public Gender Gender { get; set; }

        public int GroupId { get; set; }

        public Group Group { get; set; }

        public Detail Detail { get; set; }

        public override string ToString()
        {
            return $"Id:{Id}\nName:{Name}\nSurname:{Surname}\nAge:{Age}\nGender:{Gender}\nGroup:{Group.Name}\n=========================";
        }
    }
}
