using OrmPractice.Data;
using OrmPractice.Entities;
namespace OrmPractice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            OrmDbContext dbContext = new OrmDbContext();

            // ORM ilə Data Add etmək..
            //dbContext.Groups.Add(new Group() { Name = "PB507", Limit = 27 });
            //dbContext.SaveChanges();


            // ORM ilə bir neçə Data Add etmək..
            //dbContext.Groups.AddRange(new Group() { Name = "PB507", Limit = 27 }, new Group() { Name = "PB508", Limit = 28 });
            //dbContext.SaveChanges();


            // ORM ilə bütün dataya baxmaq..
            //foreach (var group in dbContext.Groups.ToList())
            //    Console.WriteLine($"Id:{group.Id} Name:{group.Name}  Limit:{group.Limit}");


            // ORM ilə search yazmaq..
            //var groups = dbContext.Groups
            //    .Where(g => g.Name.Contains("2"))
            //    .ToList();
            //foreach (var group in groups)
            //    Console.WriteLine($"Id:{group.Id} Name:{group.Name}  Limit:{group.Limit}");


            // ORM ilə Find methodu yazmaq.
            //var groupfind = dbContext.Groups.Find(2002);//Burada 2002 Id-dir.
            //Console.WriteLine(groupfind.Name);


        }
    }
}
