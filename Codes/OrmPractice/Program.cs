﻿using Microsoft.EntityFrameworkCore;
using OrmPractice.Data;
using OrmPractice.Entities;
namespace OrmPractice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            OrmDbContext dbContext = new OrmDbContext();


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
            var group = dbContext.Groups.SingleOrDefault(g => g.Id == 2002);//Burada 2002 Id-dir.
            var data = dbContext.ChangeTracker.Entries();
            dbContext.SaveChanges();
            #endregion

           
        }
    }
}
