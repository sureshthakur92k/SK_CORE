using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SK_CORE.Models;
using Microsoft.AspNetCore.Http;

namespace SK_CORE.Controllers
{
    public class EmployeeController : Controller
    {
        private readonly EmployeeDBContext employeeDB;
        private readonly IConfiguration configuration_;

        public EmployeeController(EmployeeDBContext employeeDB, IConfiguration configuration)
        {
            this.employeeDB = employeeDB;
            this.configuration_ = configuration;
        }
        public async Task<IActionResult> Index()
        {
           // ViewBag.Connection = configuration_["connectionString"];
            HttpContext.Session.SetString("MySessionNameKye","MySessionValues");
            var empData= await employeeDB.Employees.ToListAsync();
            return View(empData);
        }
        public IActionResult Create()
        {
            
            return View();
        }
        public IActionResult Create1Test()
        {

            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Employee employeeObj)
        {
            if(ModelState.IsValid)
            {
              await  employeeDB.Employees.AddAsync(employeeObj);
              await  employeeDB.SaveChangesAsync();
                TempData["Inserted"] = "Inserted Successfully..";
                return RedirectToAction("Index","Employee");
            }

            return View(employeeObj);
        }

        public async Task<IActionResult> Details(int ? Id)
        {
            if(HttpContext.Session.GetString("MySessionNameKye") !=null)
            {
                ViewBag.MySessionVal =  HttpContext.Session.GetString("MySessionNameKye").ToString();
                ViewBag.MySessionId = HttpContext.Session.Id;
            }
            
            if(Id == null || employeeDB.Employees == null)
            {
                return NotFound();

            }
            var empData = await employeeDB.Employees.FirstOrDefaultAsync(x => x.Id == Id);
            if(empData == null)
            {
                return NotFound();
            }
            return View(empData);
        }

        public async Task<IActionResult> Edit(int? Id)
        {
            if (Id == null || employeeDB.Employees == null)
            {
                return NotFound();

            }
            var empData = await employeeDB.Employees.FindAsync(Id);
            if (empData == null)
            {
                return NotFound();
            }
            return View(empData);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int ? Id,Employee employeeObj)
        {
            if(Id != employeeObj.Id)
            {
                return NotFound();
            }
            if (ModelState.IsValid)
            {
                 employeeDB.Employees.Update(employeeObj);
                 employeeDB.SaveChanges();
                TempData["Update"] = "Updated Successfully..";
                return RedirectToAction("Index", "Employee");
            }

            return View(employeeObj);
        }

        public async Task< IActionResult> Delete(int ? Id)
        {
            if (Id == null || employeeDB.Employees == null)
            {
                return NotFound();

            }
            var empData = await employeeDB.Employees.FirstOrDefaultAsync(x => x.Id == Id);
            if (empData == null)
            {
                return NotFound();
            }
            return View(empData);
        }
        [HttpPost,ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteById(int? Id)
        {
            var empData = await employeeDB.Employees.FindAsync(Id);
            if(empData !=null)
            {
                employeeDB.Employees.Remove(empData);
               await employeeDB.SaveChangesAsync ();
                TempData["Delete"] = "Deleted Successfully..";

            }
            return RedirectToAction("Index", "Employee");
        }
    }
}
