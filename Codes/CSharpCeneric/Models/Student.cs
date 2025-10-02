

namespace CSharpCeneric.Models
{
    internal class Student : BaseClass
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }

        public override string ToString()
        {
            return $"Id: {Id}, Name: {Name}, Age: {Age}";
        }

        public override void MyMethod()
        {
            throw new NotImplementedException();
        }
    }

    internal abstract class  BaseClass
    {
        public int Id { get; set; }
        public abstract void MyMethod();
    }
}
