using Data.Models;
using Microsoft.AspNetCore.Mvc;

namespace Presentation.Controllers
{
    public class EmployeeController : Controller
    {
        NorthwindDbCotext _context = new NorthwindDbCotext();
        public IActionResult Index()
        {
            List<Employee> employes = _context.Employees.ToList();
            return View(employes);
        }

        [HttpGet]
        public IActionResult AddEmployee()
        {

            return View();
        }
        [HttpPost]
        public IActionResult AddEmployee(Employee employee)
        {
            _context.Employees.Add(employee);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
