using D3_Task_Linq_EF.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D3_Task_Linq_EF.Configuration_Classes
{
   internal class ProjectConfiguration : IEntityTypeConfiguration<Project>
    {
        public void Configure(EntityTypeBuilder<Project> P)
        {
            // 1- Id PK with identity (10,10)
            P.ToTable("Project");
            P.HasKey(P => P.Id);
            P.Property(P => P.Id)
                    .UseIdentityColumn(10, 10);
            // 2- Name: varchar(50), default value "OurProject", Required
            P.Property(P => P.Name)
                    .IsRequired(true)
                    .HasColumnType("varchar")
                    .HasColumnName("ProName")
                    .HasDefaultValue("OurProject")
                    .HasMaxLength(50);
            // 3- Cost: Money + Range(500,000 - 3,500,000)
            P.Property(p => p.Cost)
                   .IsRequired(true)
                   .HasColumnType("money")
                   .HasColumnName("Cost");
            P.HasCheckConstraint("CK_Project_Cost_Range", "[Cost] >= 500000 AND [Cost] <= 3500000");

        }
    }
}
