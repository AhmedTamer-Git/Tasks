using D3_Task_Linq_EF.Configuration_Classes;
using D3_Task_Linq_EF.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace D3_Task_Linq_EF.DbContect
{
    internal class CompanyDbContext : DbContext
    {
        // Connection Data
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=.;Database=Company;Trusted_Connection=True;");
        }

        public DbSet<Project> Projects { get; set; }
       
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new ProjectConfiguration());
        }

    }
}
