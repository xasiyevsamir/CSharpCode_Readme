namespace Association
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Book book1 = new Book();
            book1.Name= "Test1";

            Book book2 = new Book();
            book2.Name = "Test2";


            Library library = new Library();
            library.Name = "Library 1";
            library.Address = "Baku";
            library.Books = new Book[] { book1, book2 };

            foreach (Book book in library.Books)
            {
                Console.WriteLine($"Kitab ad:{book.Name}");
            }

            
        }
    }
}
