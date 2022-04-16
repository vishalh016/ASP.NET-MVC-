using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class ProductController : Controller
    {
        //List<Product> l = new List<Product>()
        //{
        //    new Product(){ Id = 1, Name ="Dell", Category="Laptop" },
        //    new Product(){ Id = 2, Name ="Asus", Category="GamingLaptop" },
        //    new Product(){ Id = 3, Name ="Hp", Category ="PC"}
        //};
        static List<Product> AllProducts;
        static ProductController()
        {
            AllProducts = new List<Product>()
            {
                new Product(){ Id = 1, Name ="Dell", Category="Laptop" },
                new Product(){ Id = 2, Name ="Asus", Category="GamingLaptop" },
                new Product(){ Id = 3, Name ="Hp", Category ="PC"}

            };
        }
        public IActionResult Index()
        {
            return View();
        }
        //public string ShowDate()
        //{
        //    DateTime date = DateTime.Now;
        //    return date.ToString();
        //}
        public IActionResult Show() { return View(); }
        public IActionResult Test() { return View(); }
        public IActionResult DisplayProduct()
        {
            return View(AllProducts);
        }

    }
}
