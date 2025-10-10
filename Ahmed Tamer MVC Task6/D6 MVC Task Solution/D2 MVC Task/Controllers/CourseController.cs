using D2_MVC_Task.Models;
using D2_MVC_Task.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis.Elfie.Diagnostics;

namespace D2_MVC_Task.Controllers
{
    public class CourseController : Controller
    {
              CourseBL courseBL = new CourseBL();
              DepartmentBL departmentBL = new DepartmentBL();

        // ShowAll
        public IActionResult ShowAll()
        {
            var courses = courseBL.GetAll();
            return View(courses);
        }

        public IActionResult Details(int id)
        {
            var course = courseBL.GetById(id);

            if (course == null)
                return NotFound();

            return View("Details", course);
        }

        // Add (GET)
        [HttpGet]
        public IActionResult Add()
        {
            CourseVM cvm = new CourseVM()
            {
                DeptList = departmentBL.GetAll()
            };
            return View("Add", cvm);
        }

        // Add (POST)
        [HttpPost]
        public IActionResult SaveAdd(CourseVM coursevm)
        {
            if (ModelState.IsValid)
            {
                Course course = new Course()
                {
                    Name = coursevm.Name,
                    Degree = coursevm.Degree,
                    MinDegree = coursevm.MinDegree,
                    DepartmentId = coursevm.DepartmentId
                };

                courseBL.Add(course);
                return RedirectToAction(nameof(ShowAll));
            }
            ViewBag.Departments = departmentBL.GetAll();
            return View("Add",coursevm);
        }

        // Edit (GET)
        [HttpGet]
        public IActionResult Edit(int id)
        {
            Course coursse = courseBL.GetById(id);
            List<Department> DeptList = departmentBL.GetAll();
            if (coursse == null) return NotFound();
            CourseVM cvm = new CourseVM()
            {
                Id = coursse.Id,
                Name = coursse.Name,
                Degree = coursse.Degree,
                MinDegree = coursse.MinDegree,
                DepartmentId = coursse.DepartmentId,
                DeptList = DeptList
            };       
            return View("Edit",cvm);
        }

        // Edit (POST)
        [HttpPost]
        public IActionResult SaveEdit(CourseVM newcourse,int id)
        {
            if (ModelState.IsValid)
            {
                Course oldcourse = courseBL.GetById(id);

                oldcourse.Name = newcourse.Name;
                oldcourse.Degree = newcourse.Degree;
                oldcourse.MinDegree = newcourse.MinDegree;
                oldcourse.DepartmentId = newcourse.DepartmentId;

                courseBL.Save();
                return RedirectToAction(nameof(ShowAll));
            }
            ViewBag.Departments = departmentBL.GetAll();
            return View("Edit", newcourse);
        }

        // Delete (GET) → Warning View
        [HttpGet]
        public IActionResult Delete(int id)
        {
            var Course = courseBL.GetById(id);
            if (Course == null) return NotFound();
            return View("Delete", Course);
        }
        // Delete
        public IActionResult ConfirmDelete(int id)
        {
            courseBL.Delete(id);
            return RedirectToAction(nameof(ShowAll));
        }
    }
}
