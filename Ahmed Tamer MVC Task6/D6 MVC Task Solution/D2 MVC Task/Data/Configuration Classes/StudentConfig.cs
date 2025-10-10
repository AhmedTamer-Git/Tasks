using D2_MVC_Task.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace D2_MVC_Task.Data.Configuration_Classes
{
    public class StudentConfig : IEntityTypeConfiguration<Student>
    {
        public void Configure(EntityTypeBuilder<Student> builder)
        {
            builder.HasKey(s => s.Id);

            builder.Property(s => s.Name)
                   .IsRequired()
                   .HasMaxLength(100);

            builder.Property(s => s.Age)
                   .IsRequired();

            builder.HasOne(s => s.Department)
                   .WithMany(d => d.Students)
                   .HasForeignKey(s => s.DepartmentId);
        }
    }
}
