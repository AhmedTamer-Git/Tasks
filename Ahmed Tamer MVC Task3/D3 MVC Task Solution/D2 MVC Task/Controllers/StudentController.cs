using D2_MVC_Task.Data.DbContexts;
using D2_MVC_Task.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;


namespace D2_MVC_Task.Controllers
{
    public class StudentController : Controller
    {
        StudentBL studentBL = new StudentBL();

        // /student/ShowAll
        public IActionResult ShowAll()
        {
            List<Student> students = studentBL.GetAll();
            return View("ShowAll", students);
        }

        // /student/ShowDetails?id=3
        public IActionResult ShowDetails(int id)
        {
            Student student = studentBL.GetById(id);
            if (student == null)
                return NotFound();

            return View("ShowDetails", student);
        }

    }
}
