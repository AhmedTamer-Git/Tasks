using D2_MVC_Task.Data.DbContexts;
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
    }
}
