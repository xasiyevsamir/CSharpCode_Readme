using Academy.Core.Entities;
using Academy.DataAccess.Data.Configurations;
using Microsoft.EntityFrameworkCore;

namespace Academy.DataAccess.Data
{
    public class AcademyDbContext:DbContext
    {

      public  DbSet<Student> Students { get; set; }

      public  DbSet<Group> Groups { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=.; Database=AcademyDb; User=sa; Password=Salam123;TrustServerCertificate=True");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(StudentConfiguration).Assembly);
        }
    }
}
