using Core.Interfaces;
using Core.Models;
using D2_MVC_Task.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace D2_MVC_Task.Controllers
{
    public class StudentController : Controller
    {
        private readonly IStudentRepository _studentRepo;
        private readonly IDepartmentRepository _departmentRepo;
        private readonly IStuCrsResRepository _stuCrsResRepo;

        public StudentController(IStudentRepository studentRepo,
                                 IDepartmentRepository departmentRepo,
                                 IStuCrsResRepository stuCrsResRepo)
        {
            _studentRepo = studentRepo;
            _departmentRepo = departmentRepo;
            _stuCrsResRepo = stuCrsResRepo;
        }

        public IActionResult ShowAll()
        {
            var students = _studentRepo.GetAll();
            return View("ShowAll", students);
        }

        public IActionResult ShowDetails(int id)
        {
            var student = _studentRepo.GetById(id);
            if (student == null)
                return NotFound();
            return View("ShowDetails", student);
        }

        [HttpGet]
        public IActionResult Add()
        {
            var vm = new StudentFormVM
            {
                DeptList = _departmentRepo.GetAll()
            };
            return View("Add", vm);
        }

        [HttpPost]
        public IActionResult Add(StudentFormVM stu)
        {
            if (ModelState.IsValid)
            {
                var student = new Student
                {
                    Name = stu.Name,
                    Age = stu.Age,
                    DepartmentId = stu.DepartmentId
                };

                _studentRepo.Add(student);
                return RedirectToAction(nameof(ShowAll));
            }
            stu.DeptList = _departmentRepo.GetAll();
            return View("Add", stu);
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            var student = _studentRepo.GetById(id);
            if (student == null) return NotFound();

            var vm = new StudentFormVM
            {
                Id = student.Id,
                Name = student.Name,
                Age = student.Age,
                DepartmentId = student.DepartmentId,
                DeptList = _departmentRepo.GetAll()
            };
            return View("Edit", vm);
        }

        [HttpPost]
        public IActionResult SaveEdit(StudentFormVM newstudent, int id)
        {
            if (ModelState.IsValid)
            {
                var oldstudent = _studentRepo.GetById(id);
                if (oldstudent == null) return NotFound();

                oldstudent.Name = newstudent.Name;
                oldstudent.Age = newstudent.Age;
                oldstudent.DepartmentId = newstudent.DepartmentId;

                _studentRepo.Save();
                return RedirectToAction(nameof(ShowAll));
            }
            newstudent.DeptList = _departmentRepo.GetAll();
            return View("Edit", newstudent);
        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
            var student = _studentRepo.GetById(id);
            if (student == null) return NotFound();
            return View("Delete", student);
        }

        [HttpPost]
        public IActionResult ConfirmDelete(int id)
        {
            _studentRepo.Delete(id);
            return RedirectToAction(nameof(ShowAll));
        }

        public IActionResult Search(string search, int? departmentId, int page = 1, int pageSize = 5)
        {
            var students = _studentRepo.GetAll();

            if (!string.IsNullOrEmpty(search))
                students = students.Where(s => s.Name.Contains(search)).ToList();

            if (departmentId.HasValue && departmentId.Value > 0)
                students = students.Where(s => s.DepartmentId == departmentId.Value).ToList();

            int totalStudents = students.Count;
            var data = students.Skip((page - 1) * pageSize).Take(pageSize).ToList();

            var vm = new StudentListVM
            {
                Students = data,
                Search = search,
                DepartmentId = departmentId,
                Departments = _departmentRepo.GetAll(),
                CurrentPage = page,
                TotalPages = (int)Math.Ceiling(totalStudents / (double)pageSize)
            };

            return View("Search", vm);
        }

        public IActionResult ShowAllResults(int studentId)
        {
            var results = _stuCrsResRepo.GetResultsForStudent(studentId);
            if (results == null || results.Count == 0)
                return NotFound("No results found for this student.");

            return View("ShowAllResults", results);
        }
    }
}
