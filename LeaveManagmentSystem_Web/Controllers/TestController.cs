using LeaveManagmentSystem_Web.Models;
using Microsoft.AspNetCore.Mvc;

namespace LeaveManagmentSystem_Web.Controllers
{
    public class TestController : Controller
    {
        public IActionResult Index()
        {
            var data = new TestViewModel
            {
                Name = "Shubham"
            };
            return View(data);
        }
    }
}
