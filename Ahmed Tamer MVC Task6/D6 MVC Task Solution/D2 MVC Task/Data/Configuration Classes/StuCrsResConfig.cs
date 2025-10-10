using D2_MVC_Task.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace D2_MVC_Task.Data.Configuration_Classes
{
    public class StuCrsResConfig : IEntityTypeConfiguration<StuCrsRes>
    {
        public void Configure(EntityTypeBuilder<StuCrsRes> builder)
        {
            builder.HasKey(sc => new { sc.StudentId, sc.CourseId });

            builder.Property(sc => sc.Grade)
                   .IsRequired();

            builder.HasOne(sc => sc.Student)
                   .WithMany(s => s.StuCrsRes)
                   .HasForeignKey(sc => sc.StudentId);

            builder.HasOne(sc => sc.Course)
                   .WithMany(c => c.StuCrsRes)
                   .HasForeignKey(sc => sc.CourseId);
        }
    }
}
