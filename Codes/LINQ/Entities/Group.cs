namespace LINQ.Entities
{
    public class Group
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Limit { get; set; }
        
       
        public override string ToString()
        {
            return $"Id:{Id} Name:{Name} Limit:{Limit}";
        }
    }
}
