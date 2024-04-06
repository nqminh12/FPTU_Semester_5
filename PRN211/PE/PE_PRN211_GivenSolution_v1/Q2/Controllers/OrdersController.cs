using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Q2.Models;

namespace Q2.Controllers
{
    public class OrdersController : Controller
    {
        PE_PRN_23SumContext context = new PE_PRN_23SumContext();
        public IActionResult ListByEmployee(string id)
        {
            
            if(id == null)
            {
                ViewBag.Employees = context.Employees.ToList();
                var data = context.Orders
                    .Include(p => p.Employee)
                    .ToList();
                return View(data);
            }
            else
            {
                ViewBag.Employees = context.Employees.ToList();
                var data = context.Orders
                    .Where(p => p.EmployeeId == Convert.ToInt32(id))
                    .Include(p => p.Employee)
                    .ToList();
                return View(data);
            }
            
        }

        public IActionResult Details(string id)
        {
            ViewBag.Orders = context.Orders.Include(p => p.Employee).Where(p => p.OrderId == Convert.ToInt32(id)).FirstOrDefault();
            var data = context.OrderDetails
                .Include(p => p.Product)
                .ThenInclude(r => r.Category)
                .Where(p => p.OrderId == Convert.ToInt32(id)).ToList();
            return View(data);
        }
    }
}
