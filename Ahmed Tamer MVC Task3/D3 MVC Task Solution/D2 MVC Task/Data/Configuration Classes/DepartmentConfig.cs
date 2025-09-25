using D2_MVC_Task.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace D2_MVC_Task.Data.Configuration_Classes
{
    public class DepartmentConfig : IEntityTypeConfiguration<Department>
    {
        public void Configure(EntityTypeBuilder<Department> builder)
        {
            builder.HasKey(d => d.Id);

            builder.Property(d => d.Name)
                   .IsRequired()
                   .HasMaxLength(100);

            builder.Property(d => d.MgrName)
                   .HasMaxLength(100);
        }
    }
}
