using Microsoft.AspNetCore.Mvc;
using SK_CORE.Models;

namespace SK_CORE.Controllers
{
    public class StudentController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public string SaveStudent(Student student_)
        {
            return "ID:" + student_.Id_ + "Name:" + student_.Name_ + "Class:" + student_.Class_;
        }
    }
}
