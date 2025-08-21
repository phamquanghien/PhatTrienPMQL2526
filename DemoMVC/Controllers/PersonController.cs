namespace DemoMVC.Controllers
{
    using DemoMVC.Models.Entities;
    using Microsoft.AspNetCore.Mvc;
    public class PersonController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.Message = "Dữ liệu từ controller gửi về view sử dụng ViewBag";
            return View();
        }
        [HttpPost]
        public IActionResult Index(Person ps)
        {
            ViewBag.Message = ps.StudentID + "-" + ps.FullName;
            return View();
        }
    }
}