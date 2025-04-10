using Academy.Core.Entities;
using Microsoft.EntityFrameworkCore;

namespace Academy.DataAccess.Data
{
    public class AcademyDbContext:DbContext
    {

        DbSet<Student> Students { get; set; }

        DbSet<Group> Groups { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=.; Database=AcademyDb; User=sa; Password=Salam123;TrustServerCertificate=True");
        }
    }
}
