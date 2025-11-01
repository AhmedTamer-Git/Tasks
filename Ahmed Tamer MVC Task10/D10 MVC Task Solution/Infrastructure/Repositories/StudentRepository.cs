using Core.Interfaces;
using Core.Models;
using Infrastructure.Data.DbContexts;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Repositories
{
    public class StudentRepository : IStudentRepository
    {
        LearningSystemDbContext _context;
        public StudentRepository(LearningSystemDbContext context)
        {
            _context = context;
        }
        // Get all students مع القسم (Eager Loading)
        public List<Student> GetAll()
        {
            return _context.Students
                          .Include(s => s.Department)
                          .ToList();
        }

        // Get one student by Id
        public Student GetById(int id)
        {
            return _context.Students
                          .Include(s => s.Department)
                          .FirstOrDefault(s => s.Id == id);
        }

        // Add
        public void Add(Student student)
        {
            _context.Students.Add(student);
            _context.SaveChanges();
        }

        // Edit
        public void Save()
        {
            _context.SaveChanges();
        }

        // Delete
        public void Delete(int id)
        {
            var st = _context.Students.Find(id);
            if (st != null)
            {
                _context.Students.Remove(st);
                _context.SaveChanges();
            }
        }


    }
}
