using Microsoft.EntityFrameworkCore;
using OrmPractice.Data;
using OrmPractice.Entities;
using OrmPractice.Enum;
using System.Globalization;
namespace OrmPractice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            OrmDbContext dbContext = new OrmDbContext();

            Console.OutputEncoding = System.Text.Encoding.UTF8;

            #region 1.ORM ilə Data Add etmək
            // ORM ilə Data Add etmək..
            //dbContext.Groups.Add(new Group() { Name = "PB507", Limit = 27 });
            dbContext.SaveChanges();
            #endregion

            #region 2.ORM ilə bir neçə Data Add etmək
            // ORM ilə bir neçə Data Add etmək..
            //dbContext.Groups.AddRange(new Group() { Name = "PB508", Limit = 27 }, new Group() { Name = "PB509", Limit = 28 });
            //dbContext.SaveChanges();
            #endregion

            #region 3.ORM ilə bütün dataya baxmaq
            // ORM ilə bütün dataya baxmaq..
            //foreach (var group in dbContext.Groups.ToList())
            //    Console.WriteLine($"Id:{group.Id} Name:{group.Name}  Limit:{group.Limit}");
            #endregion

            #region 4. ORM ilə search yazmaq
            // ORM ilə search yazmaq..
            //var groups = dbContext.Groups
            //    .Where(g => g.Name.Contains("2"))
            //    .ToList();
            //foreach (var group in groups)
            //    Console.WriteLine($"Id:{group.Id} Name:{group.Name}  Limit:{group.Limit}");
            #endregion

            #region 5.ORM ilə Find methodu yazmaq
            // ORM ilə Find methodu yazmaq.
            //var groupfind = dbContext.Groups.Find(2002);//Burada 2002 Id-dir.
            //Console.WriteLine(groupfind.Name);
            #endregion

            #region 6.ORM ilə Single methodu yazmaq.
            // ORM ilə Single methodu yazmaq.
            //var groupSingle = dbContext.Groups.Single(g=>g.Id==2002);//Burada 2002 Id-dir.
            //Console.WriteLine(groupSingle.Name);
            #endregion

            #region 7.ORM ilə Remove methodu yazmaq.
            // ORM ilə Remove methodu yazmaq.
            //var groupRemove = dbContext.Groups.SingleOrDefault(g => g.Id == 2003);//Burada 2002 Id-dir.
            //dbContext.Groups.Remove(groupRemove);
            //dbContext.SaveChanges();
            #endregion

            #region 8.ORM ilə SaveChanges methodu yazmaq.
            // ORM ilə SaveChanges methodu yazmaq.
            //var group = dbContext.Groups.SingleOrDefault(g => g.Id == 2002);//Burada 2002 Id-dir.
            //group.Name = "Samir";
            //var data = dbContext.ChangeTracker.Entries(); // Nə qədər table varsa State göstərir
            //var data1 = dbContext.Entry(group).State;     // Yalnız təyin etdiyimiz table State göstərir


            //Qeyd: Əgər gətirilən data üzərində hec bir dəyişiklik etmiriksə izləməni dayandırırıq

            //var groups = dbContext.Groups.AsNoTracking().ToList();
            // var data = dbContext.ChangeTracker.Entries(); // İzləmə dayanıb.

            //dbContext.SaveChanges();
            #endregion

            #region 9.ORM ilə CanConnect methodu yazmaq.
            // ORM ilə CanConnect methodu yazmaq.

            //if (dbContext.Database.CanConnect())
            //{
            //    Console.WriteLine("qosulub");
            //}
            #endregion

            #region 10.ORM ilə AddRange methodu yazmaq.
            // ORM ilə AddRange methodu yazmaq.

            //Group groupPB500 = new Group() 
            //{ 
            //    Name = "PB500", 
            //    MinCount = 22,
            //    MaxCount=50, 
            //    ActivCount=23,
            //    StartDate = DateTime.Now.AddMonths(1),
            //    EndDate =DateTime.Now.AddMonths(7),                
            //};

            //Group groupPB501 = new Group()
            //{
            //    Name = "PB501",
            //    MinCount = 22,
            //    MaxCount = 50,
            //    ActivCount = 23,
            //    StartDate = DateTime.Now.AddMonths(2),
            //    EndDate = DateTime.Now.AddMonths(8),
            //};

            //dbContext.Groups.AddRange(groupPB500, groupPB501);
            //dbContext.SaveChanges();

            //Student studentHesen = new Student()
            //{
            //    Name = "Hesen",
            //    Surname = "Sariyev",
            //    Age = 24,
            //    Gender = Gender.Male,
            //    GroupId = 1002
            //};
            //Student studentNigar = new Student()
            //{
            //    Name = "Nigar",
            //    Surname = "Ağalarova",
            //    Age = 14,
            //    Gender = Gender.Female,
            //    GroupId = 1003
            //};

            //dbContext.Students.AddRange(studentHesen, studentNigar);
            //dbContext.SaveChanges();
            #endregion

            #region 11.ORM ilə Include methodu yazmaq.
            // ORM ilə Include methodu yazmaq.

            // List<Student> students=dbContext.Students.AsNoTracking().Include(g=>g.Group).ToList();

            //foreach (var student in students)
            //{
            //    Console.WriteLine(student);
            //}



            //List<Group> groups=dbContext.Groups.AsNoTracking().Include(g=>g.Students).ToList();
            //foreach (var group in groups)
            //{
            //    Console.WriteLine(group);
            //    foreach (var student in group.Students)
            //     Console.WriteLine(student);
            //    Console.WriteLine("=========================");
            //}

            //List<Detail> details = dbContext.Details.AsNoTracking()
            //    .Include(g => g.Student)
            //    .ThenInclude(s=>s.Group)
            //    .ToList();
     
            //foreach (var detail in details)
            //{
            //    Console.WriteLine(detail.Student.Name);
            //    Console.WriteLine(detail.Student.Group.Name);
            //    Console.WriteLine(detail);             
                
            //}

            #endregion
        }
    }
}
