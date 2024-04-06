using Microsoft.AspNetCore.Mvc;
using Q2.Models;

namespace Q2.Controllers
{
    public class ProjectController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        PE_PRN211_Fall23B5Context context = new PE_PRN211_Fall23B5Context();

        public IActionResult List()
        {
            List<Project> p = context.Projects.ToList();
            return View(p);
        }

         
        public IActionResult Delete(int id) 
        {
            Project p = context.Projects.FirstOrDefault(x => x.Id == id);

            if (p != null)
            {
                context.Projects.Remove(p);
                context.SaveChanges();
            }
            return RedirectToAction("List");
        }
    }
}
