using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Q2.Models;

namespace Q2.Controllers
{
    public class ServicesController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        PRN211_Spr22Context context = new PRN211_Spr22Context();
        public IActionResult Search()
        {
            var rooms = context.Rooms
                               .Include(r => r.Services)
                                   .ThenInclude(s => s.EmployeeNavigation)
                               .ToList();
            return View(rooms);
        }

        [HttpPost]
        public IActionResult Search(string? room, string? month)
        {
            IQueryable<Room> query = context.Rooms
                                            .Include(r => r.Services)
                                                .ThenInclude(s => s.EmployeeNavigation);

            if (!string.IsNullOrWhiteSpace(room))
            {
                query = query.Where(r => r.Title.Contains(room));
            }

            var rooms = query.ToList();

            ViewBag.searchRoom = room;
            ViewBag.searchMonth = month;

            return View(rooms);
        }
    }
}
