using Core.Interfaces;
using Core.Models;
using D2_MVC_Task.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace D2_MVC_Task.Controllers
{
    public class CourseController : Controller
    {
        private readonly ICourseRepository _courseRepo;
        private readonly IDepartmentRepository _departmentRepo;

        public CourseController(ICourseRepository courseRepo, IDepartmentRepository departmentRepo)
        {
            _courseRepo = courseRepo;
            _departmentRepo = departmentRepo;
        }

        public IActionResult ShowAll()
        {
            var courses = _courseRepo.GetAll();
            return View("ShowAll", courses);
        }

        public IActionResult Details(int id)
        {
            var course = _courseRepo.GetById(id);
            if (course == null) return NotFound();
            return View("Details", course);
        }

        [HttpGet]
        public IActionResult Add()
        {
            var vm = new CourseVM
            {
                DeptList = _departmentRepo.GetAll()
            };
            return View("Add", vm);
        }

        [HttpPost]
        public IActionResult SaveAdd(CourseVM vm)
        {
            if (ModelState.IsValid)
            {
                var course = new Course
                {
                    Name = vm.Name,
                    Degree = vm.Degree,
                    MinDegree = vm.MinDegree,
                    DepartmentId = vm.DepartmentId
                };

                _courseRepo.Add(course);
                return RedirectToAction(nameof(ShowAll));
            }
            vm.DeptList = _departmentRepo.GetAll();
            return View("Add", vm);
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            var course = _courseRepo.GetById(id);
            if (course == null) return NotFound();

            var vm = new CourseVM
            {
                Id = course.Id,
                Name = course.Name,
                Degree = course.Degree,
                MinDegree = course.MinDegree,
                DepartmentId = course.DepartmentId,
                DeptList = _departmentRepo.GetAll()
            };
            return View("Edit", vm);
        }

        [HttpPost]
        public IActionResult SaveEdit(CourseVM vm, int id)
        {
            if (ModelState.IsValid)
            {
                var course = _courseRepo.GetById(id);
                if (course == null) return NotFound();

                course.Name = vm.Name;
                course.Degree = vm.Degree;
                course.MinDegree = vm.MinDegree;
                course.DepartmentId = vm.DepartmentId;

                _courseRepo.Save();
                return RedirectToAction(nameof(ShowAll));
            }
            vm.DeptList = _departmentRepo.GetAll();
            return View("Edit", vm);
        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
            var course = _courseRepo.GetById(id);
            if (course == null) return NotFound();
            return View("Delete", course);
        }

        [HttpPost]
        public IActionResult ConfirmDelete(int id)
        {
            _courseRepo.Delete(id);
            return RedirectToAction(nameof(ShowAll));
        }
    }
}
