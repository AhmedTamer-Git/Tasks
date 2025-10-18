using Core.Interfaces;
using Core.Models;
using Infrastructure.Data.DbContexts;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Repositories
{
    public class StuCrsResRepository : IStuCrsResRepository
    {
        private readonly LearningSystemDbContext _context;

        public StuCrsResRepository(LearningSystemDbContext context)
        {
            _context = context;
        }

        // ==========================================================
        // ✅ Get all results for a specific student (Model-based)
        // ==========================================================
        public List<StuCrsRes> GetResultsForStudent(int studentId)
        {
            // التأكد إن الطالب موجود
            var student = _context.Students.Find(studentId);
            if (student == null)
                return new List<StuCrsRes>();

            // جلب كل النتائج الخاصة بالطالب
            var studentCourses = _context.StuCrsRes
                .Include(sc => sc.Course)
                .Include(sc => sc.Student)
                .Where(sc => sc.StudentId == studentId)
                .ToList();

            return studentCourses;
        }

        // ==========================================================
        // ✅ Get all student-course results in the system
        // ==========================================================
        public List<StuCrsRes> GetAllResults()
        {
            return _context.StuCrsRes
                .Include(sc => sc.Course)
                .Include(sc => sc.Student)
                .ToList();
        }
    }
}
