using System.Diagnostics;
using D1_MVC_Task.Models;
using Microsoft.AspNetCore.Mvc;

namespace D1_MVC_Task.Controllers
{
    public class HomeController : Controller
    {

        // /Home/ShowMsg
        public ContentResult ShowMsg()
        {
            ContentResult result = new ContentResult();
            result.Content = "Hello Tamer !";
            return result;
        }

        // /Home/ShowView
        public ViewResult ShowView()
        {
            ViewResult result = new ViewResult();
            result.ViewName = "View1";
            return result;
        }

        public ViewResult view(string ViewName)
        {
            //declare
            ViewResult result = new ViewResult();
            //initial
            result.ViewName = "ViewName";
            // return
            return result;
        }

        // /Home/ShowMix?id=4
        // Query string
        public IActionResult ShowMix(int id)
        {
            if (id % 2 == 0)
            {
                return View("View1");
            }
            else
            {
                return Content("Hello Tamer !");
            }
        }





        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
