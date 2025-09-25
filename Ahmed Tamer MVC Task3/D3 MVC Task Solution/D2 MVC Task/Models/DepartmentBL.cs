using D2_MVC_Task.Data.DbContexts;
using Microsoft.EntityFrameworkCore;

namespace D2_MVC_Task.Models
{
    public class DepartmentBL
    {
        
           LearningSystemDbContext context = new LearningSystemDbContext();

            // Get all departments 
            public List<Department> GetAll()
            {
                return context.Departments
                              .Include(d => d.Students)
                              .ToList();
            }

            // Get department by Id 
            public Department GetById(int id)
            {
                return context.Departments
                              .Include(d => d.Students)
                              .FirstOrDefault(d => d.Id == id);
            }

            // Add new department
            public void Add(Department dept)
            {
                context.Departments.Add(dept);
                context.SaveChanges();
            }
        
    }
}
