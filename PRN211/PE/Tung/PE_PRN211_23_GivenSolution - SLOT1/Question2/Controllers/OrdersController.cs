using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Question2.Models;

namespace Question2.Controllers
{
    public class OrdersController : Controller
    {
        public PE_PRN_23SumContext context = new PE_PRN_23SumContext();
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult ListByEmployee()
        {
            List<Employee> employees = new List<Employee>();
            employees = context.Employees.ToList();
            var Orders = context.Orders.Include(e => e.Employee).ToList();
            ViewBag.Orders = Orders;

            return View(employees);
        }
    }
}
