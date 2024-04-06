using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebApp.Models;

namespace WebApp.Controllers
{
    public class ContractController : Controller
    {
        PE_PRN_Sum21Context context = new PE_PRN_Sum21Context();
        public IActionResult Index()
        {
            List<Contract> con = context.Contracts
                .Include(p => p.Customer)
                .Include(q => q.Employee)
                .ToList();
            ViewBag.Customer = context.Customers.ToList();
            return View(con);
        }
        [HttpPost]
        public IActionResult Index(int customerid)
        {
            List<Contract> con = new List<Contract> ();
            if (customerid == 0)
            {
                return RedirectToAction("Index");
            }
            else
            {
                con = context.Contracts
                .Where(r => r.CustomerId == customerid)
                .Include(p => p.Customer)
                .Include(q => q.Employee)
                .ToList();
            }
            
            ViewBag.Customer = context.Customers.ToList();
            return View(con);
        }
    }


}
