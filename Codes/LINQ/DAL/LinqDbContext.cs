using LINQ.Entities;
using Microsoft.EntityFrameworkCore;

namespace LINQ.DAL
{
    public class LinqDbContext:DbContext
    {
        public DbSet<Group> Groups { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=.; Database=ORM; User=sa; Password=Salam123;TrustServerCertificate=True");
        }
    }
}
