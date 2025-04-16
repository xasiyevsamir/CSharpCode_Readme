using Academy.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Academy.DataAccess.Data.Configurations
{
    internal class GroupConfiguration : IEntityTypeConfiguration<Group>
    {
        public void Configure(EntityTypeBuilder<Group> builder)
        {
            builder.Property(g=>g.No).IsRequired().HasMaxLength(10);
            builder.Property(g=>g.Limit).IsRequired().HasDefaultValue(10);
            builder.HasIndex(g=>g.No).IsUnique();
        }
    }
}
