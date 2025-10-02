using D2_MVC_Task.Data.DbContexts;
using D2_MVC_Task.Models;
using D2_MVC_Task.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;



namespace D2_MVC_Task.Controllers
{
    public class StudentController : Controller
    {
        StudentBL studentBL = new StudentBL();
        DepartmentBL departmentBL = new DepartmentBL();
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

        // Add (GET)
        [HttpGet]
        public IActionResult Add()
        {
            StudentAddVM vm = new StudentAddVM()
            {
                DeptList = departmentBL.GetAll()
            };
            return View("Add", vm);
        }

        // Add (POST)
        [HttpPost]
        public IActionResult Add(StudentAddVM stu)
        {
            if (ModelState.IsValid )
            {
                Student student = new Student()
                {
                    Name = stu.Name,
                    Age = stu.Age,
                    DepartmentId = stu.DepartmentId
                };
                studentBL.Add(student);
                return RedirectToAction(nameof(ShowAll));
            }
            stu.DeptList = departmentBL.GetAll();
            return View("Add", stu);
        }

        // Edit (GET)
        [HttpGet]
        public IActionResult Edit(int id)
        {
            Student student = studentBL.GetById(id);
            List<Department> DeptList = departmentBL.GetAll();
            
            if (student == null) return NotFound();
            StudentEditVM vm = new StudentEditVM()
            {
                Id = student.Id,
                Name = student.Name,
                Age = student.Age,
                DepartmentId = student.DepartmentId,
                DeptList = DeptList
            };
            return View("Edit", vm);
        }

        // Edit (POST)
        [HttpPost]
        public IActionResult SaveEdit(StudentEditVM newstudent,int id)
        {
            if (ModelState.IsValid)
            {
               Student oldstudent = studentBL.GetById(id);

                oldstudent.Name = newstudent.Name;
                oldstudent.Age = newstudent.Age;
                oldstudent.DepartmentId = newstudent.DepartmentId;

                studentBL.Save();
                return RedirectToAction(nameof(ShowAll));
            }
            return View("Edit", newstudent);
        }


        // Delete (GET) → Warning View
        [HttpGet]
        public IActionResult Delete(int id)
        {
            var student = studentBL.GetById(id);
            if (student == null) return NotFound();
            return View("Delete", student);
        }

        // Delete (POST)
        [HttpPost]
        public IActionResult ConfirmDelete(int id)
        {
            studentBL.Delete(id);
            return RedirectToAction("ShowAll");
        }


        public IActionResult Search(string search, int? departmentId, int page = 1, int pageSize = 5)
        {
            var students = studentBL.GetAll();

            // 🔎 Search by name
            if (!string.IsNullOrEmpty(search))
            {
                students = students.Where(s => s.Name.Contains(search)).ToList();
            }

            // 🎯 Filter by department
            if (departmentId.HasValue && departmentId.Value > 0)
            {
                students = students.Where(s => s.DepartmentId == departmentId.Value).ToList();
            }

            // 📄 Pagination
            int totalStudents = students.Count();
            var data = students
                .OrderBy(s => s.Id)
                .Skip((page - 1) * pageSize)
                .Take(pageSize)
                .ToList();

            // نجهز ViewModel للعرض
            var vm = new StudentListVM
            {
                Students = data,
                Search = search,
                DepartmentId = departmentId,
                Departments = departmentBL.GetAll(),
                CurrentPage = page,
                TotalPages = (int)Math.Ceiling(totalStudents / (double)pageSize)
            };

            return View("Search", vm);
        }

    }
}
