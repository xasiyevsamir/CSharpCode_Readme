namespace Inheritance
{
    internal class Humman
    {
        public string Name;
        public string Surname;
        public byte Age;
        public Humman(string name)
        {
            this.Name = name;
        }
        public void Info()
        {
            Console.WriteLine($"{Name}  {Surname}");
        }
        public void FullInfo()
        {
            Console.WriteLine($"{Name}  {Surname}  {Age}");
        }
    }
}
