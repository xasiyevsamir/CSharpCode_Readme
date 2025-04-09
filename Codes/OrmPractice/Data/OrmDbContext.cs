using Microsoft.EntityFrameworkCore;
using OrmPractice.Entities;

namespace OrmPractice.Data
{
    internal class OrmDbContext:DbContext
    {
        public DbSet<Group> Groups { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<Detail> Details { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=.; Database=ORM; User=sa; Password=Salam123;TrustServerCertificate=True");
        }


    }
}
