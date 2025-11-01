using Core.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace D2_MVC_Task.Controllers
{
    public class InstructorController : Controller
    {
        private readonly ICourseRepository _courseRepo;

        public InstructorController(ICourseRepository courseRepo)
        {
            _courseRepo = courseRepo;
        }

        // ============================================
        // Index - Authorized for Authenticated Users only
        // ============================================
        [Authorize] // Only authenticated users
        public IActionResult Index()
        {
            var courses = _courseRepo.GetAll();
            return View(courses);
        }

        // ============================================
        // Details - Authorized for Authenticated Users
        // ============================================
        [Authorize]
        public IActionResult Details(int id)
        {
            var course = _courseRepo.GetById(id);
            if (course == null)
                return NotFound();

            return View(course);
        }
    }
}