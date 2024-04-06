using Microsoft.AspNetCore.Mvc;

namespace Q3.Controllers
{
    public class ServicesController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
