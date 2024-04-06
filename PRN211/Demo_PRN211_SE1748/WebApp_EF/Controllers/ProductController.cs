using Microsoft.AspNetCore.Mvc;
using WebApp_EF.Models;

namespace WebApp_EF.Controllers
{
    public class ProductController : Controller
    {
        MysaleDBContext context = new MysaleDBContext();
        public IActionResult Index()
        {
            // Lấy danh sách category
            var category = context.Categories.ToList();
            ViewBag.Categories = category;

            var data = context.Products.ToList();   

            return View(data);
        }

        [HttpPost]
        public IActionResult Index(int cateid)
        {
            // Lấy danh sách category
            var category = context.Categories.ToList();
            ViewBag.Categories = category;

            var data = context.Products.ToList();
            if(cateid != 0)
            {
                data = context.Products
                    .Where(p => p.CategoryId == cateid)
                    .ToList();
            }

            //truyenf lại cai cateid đã select 
            ViewBag.SelectedId = cateid;

            return View(data);
        }

        public IActionResult Update(int code)
        {
            //tìm product cần update 
            Product p = context.Products.FirstOrDefault(p => p.ProductId == code);
            

            //Lấy danh sach cate
            var category = context.Categories.ToList();
            ViewBag.Categories = category;

            return View(p);
        }

        [HttpPost]
        public IActionResult Update(Product product)
        {
            //tìm product cần update 
            Product p = context.Products.FirstOrDefault(p => p.ProductId == product.ProductId);


            p.ProductName = product.ProductName;
            p.UnitPrice = product.UnitPrice;
            p.UnitsInStock = product.UnitsInStock;
            p.Image = product.Image;
            p.Category = product.Category;
            


            return View(p);
        }
    }
}
