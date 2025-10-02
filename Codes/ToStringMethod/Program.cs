namespace ToStringMethod
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product
            {
                Id = 1,
                Name = "Laptop",
                Price = 1000
            };
            Product product2 = new Product
            {
                Id = 1,
                Name = "Laptop",
                Price = 1000
            };

            Console.WriteLine(product1);
            Console.WriteLine(product2);
            Console.WriteLine(product1.Equals(product2));
            Console.WriteLine(product1.GetHashCode()==product2.GetHashCode());
        }
    }
}
