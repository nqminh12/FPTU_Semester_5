using Microsoft.AspNetCore.Mvc;
using Question2.Models;

namespace Question2.Controllers
{
    public class StudentController : Controller
    {
        PE_PRN_Spr23_B5Context context = new PE_PRN_Spr23_B5Context();

        public IActionResult List()
        {
            List<Student> students = context.Students.ToList();
            
            List<Major> majors = context.Majors.ToList();

            ViewBag.Major = majors;

            foreach (Student s in students)
            {
                foreach (Major major in majors)
                {
                    if (s.Major == major.MajorCode)
                    {
                        s.Major = major.MajorName;
                    }
                }
            }
            return View(students);
        }

        [HttpPost]
        public IActionResult List(string majorcode, int gender, int sort)
        {
            List<Student> students;
            List<Major> majors = context.Majors.ToList();
            ViewBag.SelectedCode = majorcode;
            ViewBag.Major = majors;
            ViewBag.sort = sort;
            ViewBag.gender = gender;

            bool checkgender = true;
            if(gender == 0)
            {
                checkgender = false;
            }

            switch (sort)
            {
                case 1:
                    students = context.Students
                       . Where(p => p.Male == checkgender && p.Major == majorcode)
                       .OrderBy(p => p.StudentId)
                        .ToList();
                    break;
                case 3:
                    students = context.Students
                       .Where(p => p.Male == checkgender && p.Major == majorcode)
                       .OrderBy(p => p.FullName)
                        .ToList();
                    break;
                case 2:
                    students = context.Students
                       .Where(p => p.Male == checkgender && p.Major == majorcode)
                       .OrderBy(p => p.Dob)
                       .ToList();
                    break;
                default:
                    students = context.Students
                        .Where(p => p.Male == checkgender && p.Major == majorcode)
                        .ToList();
                    break;
            }
            foreach (Student s in students)
            {
                foreach (Major major in majors)
                {
                    if (s.Major == major.MajorCode)
                    {
                        s.Major = major.MajorName;
                    }
                }
            }
            return View(students);
        }
    }
}
