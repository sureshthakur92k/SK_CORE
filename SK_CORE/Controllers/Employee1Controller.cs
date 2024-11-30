using Microsoft.AspNetCore.Mvc;
using SK_CORE.Models;

namespace SK_CORE.Controllers
{
    public class Employee1Controller : Controller
    {
        private readonly EmployeeDBContext employeeDB;
        private readonly IConfiguration configuration_;

        public Employee1Controller(EmployeeDBContext employeeDB, IConfiguration configuration)
        {
            this.employeeDB = employeeDB;
            this.configuration_ = configuration;
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Create()
        {

            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Employee employeeObj)
        {
            if (ModelState.IsValid)
            {
                await employeeDB.Employees.AddAsync(employeeObj);
                await employeeDB.SaveChangesAsync();
                TempData["Inserted"] = "Inserted Successfully..";
                return RedirectToAction("Index", "Employee");
            }

            return View(employeeObj);
        }
    }
}
