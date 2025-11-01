using Core.Interfaces;
using Core.Models;
using Infrastructure.Data.DbContexts;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Repositories
{
    public class CourseRepository : ICourseRepository
    {
        LearningSystemDbContext _context;
        public CourseRepository(LearningSystemDbContext context)
        {
            _context = context;
        }
        public List<Course> GetAll()
        {
            return _context.Courses
                          .Include(c => c.Department)
                          .ToList();
        }
        public Course? GetById(int id)
        {
            return _context.Courses
                          .Include(c => c.Department)
                          .FirstOrDefault(c => c.Id == id);
        }
        public void Add(Course course)
        {
            _context.Courses.Add(course);
            _context.SaveChanges();
        }

        // Edit
        public void Save()
        {
            _context.SaveChanges();
        }

        public void Delete(int id)
        {
            var course = _context.Courses.Find(id);
            if (course != null)
            {
                _context.Courses.Remove(course);
                _context.SaveChanges();
            }
        }
    }
}
