using Microsoft.AspNetCore.Mvc;
using SK_CORE.Models;
using SK_CORE.Repository;
using System.Diagnostics;

namespace SK_CORE.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private StudentRepository _studentRepository = null;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
            _studentRepository = new StudentRepository();
        }

        //[Route("")]
        //[Route("Home")]
        //[Route("Home/Index")]
        public IActionResult Index()
        {
            string[] arr = { "Thakur", "Suresh", "Kumar" };
            ViewData["Data1"] = arr;
          ViewBag.data1 = arr;
            return View();
            //return Content("I am Contect Result..");

            //var name = "Suresh";
            //return Json(new {data= name });
           // return new EmptyResult();
        }
        public IActionResult Contact()
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
        public List<Student> GetAllStudent()
        {
           return _studentRepository.GetAllStudent();
        }
        public Student GetStudentById(int id) {
            return _studentRepository.GetStudentById(id);
        }
    }
}
