using D2_MVC_Task.Data.DbContexts;
using Microsoft.EntityFrameworkCore;
using D2_MVC_Task.ViewModels;

namespace D2_MVC_Task.Models
{
    public class StuCrsResBL
    {
        LearningSystemDbContext context = new LearningSystemDbContext();

        public List<StudentCourseResultVM> GetResultsForStudent(int studentId)
        {
            var student = context.Students.Find(studentId);
            var studentCourses = context.StuCrsRes
                .Include(sc => sc.Course)
                .Where(sc => sc.StudentId == studentId)
                .ToList();

            var result = studentCourses.Select(sc => new StudentCourseResultVM
            {
                StudentName = student.Name,
                CourseName = sc.Course.Name,
                Degree = sc.Grade,
                Color = sc.Grade >= sc.Course.MinDegree ? "green" : "red"
            }).ToList();

            return result;
        }
    }
}
