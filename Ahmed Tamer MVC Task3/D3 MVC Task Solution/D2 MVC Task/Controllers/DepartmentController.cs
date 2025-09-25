using D2_MVC_Task.Data.DbContexts;
using D2_MVC_Task.Models;
using D2_MVC_Task.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace D2_MVC_Task.Controllers
{
    public class DepartmentController : Controller
    {
         DepartmentBL departmentBL = new DepartmentBL();

        // /Department/ShowAll
        public IActionResult ShowAll()
        {
            List<Department> depts = departmentBL.GetAll();
            return View("ShowAll", depts);
        }

        // /Department/ShowDetails?id=3
        public IActionResult ShowDetails(int id)
        {
            Department dept = departmentBL.GetById(id);
            if (dept == null) return NotFound();
            return View("ShowDetails", dept);
        }

        // /Department/Summary?id=1
        public IActionResult Summary(int id)
        {
            Department dept = departmentBL.GetById(id);
            if (dept == null) return NotFound();

            DepartmentDetailsVM vm = new DepartmentDetailsVM()
            {
                DepName = dept.Name,
                StuAbove25 = dept.Students
                                      .Where(s => s.Age > 25)
                                      .Select(s => s.Name)
                                      .ToList(),
                DepState = dept.Students.Count > 50 ? "Main" : "Branch"
            };

            return View("Summary", vm);
        }

        // /Department/Add
        [HttpGet]
        public IActionResult Add()
        {
            return View("Add");
        }

        [HttpPost]
        public IActionResult SaveAdd(Department DeptSent)
        {
            if (DeptSent.Name != null && DeptSent.MgrName !=null)
            {
                departmentBL.Add(DeptSent);
                return RedirectToAction(nameof(ShowAll));
            }
            return View("Add", DeptSent);
        }
    }
}
