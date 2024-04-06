using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Q2.Models;

namespace Q2.Controllers
{
    public class ScheduleController : Controller
    {
        PE_PRN_Fall2023B1Context context = new PE_PRN_Fall2023B1Context();

        [HttpGet]
        public IActionResult ByDate()
        {
            DateTime t = DateTime.Parse("10/24/2023");
            var rls = context.Schedules
                                .Include(x => x.Movie)
                                .Include(x => x.Room)
                                .Include(x => x.TimeSlot)
                                .ToList();
            var r = context.Rooms.ToList();
            var slotList = context.TimeSlots.ToList();
            ViewBag.roomList = r;
            ViewBag.timeSlotList = slotList;
            ViewBag.Date = t;
            return View("Index", rls);
        }

        [HttpPost]
        public IActionResult ByDate(string? time)
        {
            DateTime t = DateTime.Parse("10/24/2023");
            if (time != "")
            {
                t = DateTime.Parse(time);
            }
            var rls = context.Schedules
                             .Include(x => x.Movie)
                             .Include(x => x.Room)
                             .Include(x => x.TimeSlot)
                             .ToList();
            var r = context.Rooms.ToList();
            var slotList = context.TimeSlots.ToList();
            ViewBag.roomList = r;
            ViewBag.timeSlotList = slotList;
            ViewBag.Date = t;
            return View("Index", rls);
        }


    }
}
