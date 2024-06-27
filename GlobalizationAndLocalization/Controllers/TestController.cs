using Microsoft.AspNetCore.Mvc;

namespace GlobalizationAndLocalization.Controllers
{
    public class TestController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Create()
        {
            return View();
        }
    }
}
