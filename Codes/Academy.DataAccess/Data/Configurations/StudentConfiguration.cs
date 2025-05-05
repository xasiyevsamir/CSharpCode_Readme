using Academy.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
namespace Academy.DataAccess.Data.Configurations
{
    internal class StudentConfiguration : IEntityTypeConfiguration<Student>
    {
        public void Configure(EntityTypeBuilder<Student> builder)
        {
            builder.ToTable(s =>s.HasCheckConstraint("CK_Student_Age", "Age >= 1 AND Age <= 150"));
            builder.Property(s=>s.Name).IsRequired().HasMaxLength(15).HasColumnName("Lorem");
            builder.HasIndex(s => s.Name).IsUnique();

            builder.HasOne(a => a.Group)
             .WithMany(s => s.Students)
            .HasForeignKey(a => a.GroupId) 
             .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
