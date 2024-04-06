using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Question2.Models;
namespace Question2.Controllers
{
    public class OrdersController : Controller
    {
        PE_PRN_23SumContext context = new PE_PRN_23SumContext();
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult ListByEmployee()
        {
            List<Employee> employees = new List<Employee>();
            //  lấy list employee
            employees = context.Employees.ToList();
            // sử dụng model
            List<Order> orders = context.Orders.ToList();
            // gan order vào viewBag để view lấy data
            ViewBag.Orders = orders;
            return View(employees);
        }
        public IActionResult Details(int id)
        {
            OrderDetail od = context.OrderDetails
                .Include(x => x.Order.Employee)
                .Include(x => x.Product)
                .Where(x => x.OrderId == id)
                .FirstOrDefault();
            List<OrderDetail> listP = context.OrderDetails
                .Include(x => x.Order.Employee)
                .Include(x => x.Product.Category)
                .Where(x => x.OrderId == id)
                .ToList();
            ViewBag.ListProduct = listP;
            return View(od);
        }
    }
}
