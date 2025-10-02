namespace ToStringMethod
{
    internal class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }

        public override string ToString()
        {
            return $"Id: {Id}, Name: {Name}, Price: {Price}";
        }

        public override bool Equals(object? obj)
        {
            if (obj is not null && obj is Product p)
                return Id == p.Id;
            else
                return false;
        }

        public override int GetHashCode()
        {
            return (Id, Name, Price).GetHashCode();
        }
    }
}
