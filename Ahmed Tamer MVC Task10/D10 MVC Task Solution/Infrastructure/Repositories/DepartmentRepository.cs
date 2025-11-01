using Core.Interfaces;
using Core.Models;
using Infrastructure.Data.DbContexts;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Repositories
{
    public class DepartmentRepository : IDepartmentRepository
    {
        
        LearningSystemDbContext _context;
        public DepartmentRepository(LearningSystemDbContext context)
        {
            _context = context;
        }

        // Get all departments 
        public List<Department> GetAll()
            {
                return _context.Departments
                              .Include(d => d.Students)
                              .ToList();
            }

            // Get department by Id 
            public Department GetById(int id)
            {
                return _context.Departments
                              .Include(d => d.Students)
                              .FirstOrDefault(d => d.Id == id);
            }

            // Add new department
            public void Add(Department dept)
            {
                   _context.Departments.Add(dept);
                   _context.SaveChanges();
            }
      
        // Update department
        public void Update(Department department)
            {
                  _context.Departments.Update(department);
                  _context.SaveChanges();
            }

        // Delete department
        public void Delete(Department dept)
        {
            _context.Departments.Remove(dept);
            _context.SaveChanges();
        }
    }
}
