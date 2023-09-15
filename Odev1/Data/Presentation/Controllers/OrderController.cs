using Data.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Presentation.Controllers
{
    public class OrderController : Controller
    {
        NorthwindDbCotext _context = new NorthwindDbCotext();
        public IActionResult Index()
        {
            var result = _context.Orders.ToList();

            return View(result);
        }

        public IActionResult OrderDetails(int id)
        {
            var result = _context.Orders.Where(x => x.EmployeeId == id).Include(x => x.Employee).ToList();

            var name = _context.Employees.FirstOrDefault(x => x.EmployeeId == id)
                .FirstName;

            ViewBag.employeeFullName = name + " " + _context.Employees
                .FirstOrDefault(x => x.EmployeeId == id).LastName;

            return View(result);
        }
    }
}
