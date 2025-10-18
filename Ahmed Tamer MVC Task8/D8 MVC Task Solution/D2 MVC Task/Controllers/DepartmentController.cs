using Core.Interfaces;
using Core.Models;
using D2_MVC_Task.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace D2_MVC_Task.Controllers
{
    public class DepartmentController : Controller
    {
        private readonly IDepartmentRepository _departmentRepo;

        public DepartmentController(IDepartmentRepository departmentRepo)
        {
            _departmentRepo = departmentRepo;
        }

        public IActionResult ShowAll()
        {
            var depts = _departmentRepo.GetAll();
            return View("ShowAll", depts);
        }

        public IActionResult ShowDetails(int id)
        {
            var dept = _departmentRepo.GetById(id);
            if (dept == null) return NotFound();
            return View("ShowDetails", dept);
        }

        public IActionResult Summary(int id)
        {
            var dept = _departmentRepo.GetById(id);
            if (dept == null) return NotFound();

            var vm = new DepartmentDetailsVM
            {
                DepName = dept.Name,
                StuAbove25 = dept.Students.Where(s => s.Age > 25).Select(s => s.Name).ToList(),
                DepState = dept.Students.Count > 50 ? "Main" : "Branch"
            };

            return View("Summary", vm);
        }

        [HttpGet]
        public IActionResult Add() => View("Add");

        [HttpPost]
        public IActionResult SaveAdd(Department dept)
        {
            if (ModelState.IsValid)
            {
                _departmentRepo.Add(dept);
                return RedirectToAction(nameof(ShowAll));
            }
            return View("Add", dept);
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            var dept = _departmentRepo.GetById(id);
            if (dept == null) return NotFound();
            return View("Edit", dept);
        }

        [HttpPost]
        public IActionResult SaveEdit(Department dept)
        {
            if (ModelState.IsValid)
            {
                _departmentRepo.Update(dept);
                return RedirectToAction(nameof(ShowAll));
            }
            return View("Edit", dept);
        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
            var dept = _departmentRepo.GetById(id);
            if (dept == null) return NotFound();
            return View("Delete", dept);
        }

        [HttpPost]
        public IActionResult SaveDelete(int id)
        {
            var dept = _departmentRepo.GetById(id);
            if (dept == null) return NotFound();
            _departmentRepo.Delete(dept);
            return RedirectToAction(nameof(ShowAll));
        }
    }
}
