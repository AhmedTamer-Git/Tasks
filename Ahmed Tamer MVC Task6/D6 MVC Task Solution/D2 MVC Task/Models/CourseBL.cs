using D2_MVC_Task.Data.DbContexts;
using Microsoft.EntityFrameworkCore;

namespace D2_MVC_Task.Models
{
    public class CourseBL
    {
        LearningSystemDbContext context = new LearningSystemDbContext();

        public List<Course> GetAll()
        {
            return context.Courses
                          .Include(c => c.Department)
                          .ToList();
        }
        public Course? GetById(int id)
        {
            return context.Courses
                          .Include(c => c.Department)
                          .FirstOrDefault(c => c.Id == id);
        }
        public void Add(Course course)
        {
            context.Courses.Add(course);
            context.SaveChanges();
        }

        // Edit
        public void Save()
        {
            context.SaveChanges();
        }

        public void Delete(int id)
        {
            var course = context.Courses.Find(id);
            if (course != null)
            {
                context.Courses.Remove(course);
                context.SaveChanges();
            }
        }
    }
}
