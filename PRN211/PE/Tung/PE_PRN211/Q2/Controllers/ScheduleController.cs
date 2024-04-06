using Microsoft.AspNetCore.Mvc;

namespace Q2.Controllers
{
    public class ScheduleController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult ByDate()
        {
            return View();
        }

        [HttpPost]
        public IActionResult ByDate(string? date)
        {

            return View();
        }
    }
}
