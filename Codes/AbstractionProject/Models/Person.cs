namespace AbstractionProject.Models
{
    public abstract class Person
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }

        public abstract void Work();

        public virtual string Detail()
        {
           return$"Id: {Id}  Name: {Name}  Surname: {Surname}";
        }
    }
}
