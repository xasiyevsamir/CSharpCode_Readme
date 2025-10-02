namespace Indexer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CustomList list = new CustomList(3);
            list[0] = new Book { Name = "Book Zero", Author = "Author A" };
            list[1] = new Book { Name = "Book One", Author = "Author B" };
            list[2] = new Book { Name = "Book Two", Author = "Author C" };

            Console.WriteLine(list[0].Name);
        }
    }
}
