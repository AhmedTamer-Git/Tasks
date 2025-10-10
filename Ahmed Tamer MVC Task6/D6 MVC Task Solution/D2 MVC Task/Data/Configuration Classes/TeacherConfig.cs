using D2_MVC_Task.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace D2_MVC_Task.Data.Configuration_Classes
{
    public class TeacherConfig : IEntityTypeConfiguration<Teacher>
    {
        public void Configure(EntityTypeBuilder<Teacher> builder)
        {
            builder.HasKey(t => t.Id);

            builder.Property(t => t.Name)
                   .IsRequired()
                   .HasMaxLength(100);

            builder.Property(t => t.Salary)
                   .HasColumnType("decimal(18,2)");

            builder.Property(t => t.Address)
                   .HasMaxLength(200);

            builder.HasOne(t => t.Department)
                   .WithMany(d => d.Teachers)
                   .HasForeignKey(t => t.DepartmentId);

            builder.HasOne(t => t.Course)
                   .WithMany(c => c.Teachers)
                   .HasForeignKey(t => t.CourseId);
        }
    }
}
