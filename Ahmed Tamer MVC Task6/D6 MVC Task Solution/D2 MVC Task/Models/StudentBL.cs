using D2_MVC_Task.Data.DbContexts;
using D2_MVC_Task.ViewModels;
using Microsoft.EntityFrameworkCore;

namespace D2_MVC_Task.Models
{
    public class StudentBL
    {
        LearningSystemDbContext context = new LearningSystemDbContext();

        // Get all students مع القسم (Eager Loading)
        public List<Student> GetAll()
        {
            return context.Students
                          .Include(s => s.Department)
                          .ToList();
        }

        // Get one student by Id
        public Student GetById(int id)
        {
            return context.Students
                          .Include(s => s.Department)
                          .FirstOrDefault(s => s.Id == id);
        }

        // Add
        public void Add(Student student)
        {
            context.Students.Add(student);
            context.SaveChanges();
        }

        // Edit
        public void Save()
        {
            context.SaveChanges();
        }

        // Delete
        public void Delete(int id)
        {
            var st = context.Students.Find(id);
            if (st != null)
            {
                context.Students.Remove(st);
                context.SaveChanges();
            }
        }


    }
}
