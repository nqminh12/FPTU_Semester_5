using Microsoft.AspNetCore.Mvc;
using WebAppMVC.Models;

namespace WebAppMVC.Controllers
{
    public class SubjectController : Controller
    {
        //Khai bao 1 danh sach Subject 
        static List<Subjects> data = new List<Subjects>()
        {
            new Subjects("S01", "JavaWeb", 20),
            new Subjects("S02", "WebDesign", 6)
        };
        // đây chính là 1 action trong 1 controller
        public IActionResult Index(Subjects S)
        {
            //Xử lí code ở đây
            //Chuyển dữ liệu từ controller sang View
            //C1: Sử dụng ViewBag
            ViewBag.message = "Information of Subject:";
            //Subjects S = new Subjects("s01", "Minh", 20);
            ViewBag.subject = S;
            //C2: Sử dụng Model
            return View(data);
        }

        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Add(Subjects s)
        {
            if (ModelState.IsValid) //truyền object thành công 
            {
                //add vào data
                var s1 = data.FirstOrDefault(item => item.Code.Equals(s.Code));
                if (s1 == null)
                {
                    data.Add(s);
                    return RedirectToAction("Index", s);
                }
            }
            //trả về trang Add
            return View();
        }

        public IActionResult Delete(String code)
        {
            //tim subject cần xóa 
            Subjects s = data.FirstOrDefault(item => item.Code.Equals(code));
            //xóa khỏi data
            if(s != null)
            {
                data.Remove(s);
            }
            //di chuyen ve trang home
            return RedirectToAction("Index", s);
        }

        public IActionResult Update(String code)
        {
            //tìm subject cần update
            Subjects s = data.FirstOrDefault(item => item.Code.Equals(code));
            //chuyern subject đó sang 1 trang update
            return View(s);

        }
        [HttpPost]
        public IActionResult Update(Subjects sub)
        {
            //tìm subject cần update
            Subjects s = data.FirstOrDefault(item => item.Code.Equals(sub.Code));

            data.Remove(s);
            data.Add(sub);
            //chuyern subject đó sang 1 trang update
            return RedirectToAction("Index", sub);

        }
    }
}
