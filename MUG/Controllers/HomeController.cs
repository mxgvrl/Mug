using Microsoft.AspNetCore.Mvc;

namespace MUG.Controllers {
    public class HomeController : Controller{
        public IActionResult Home() {
            return View();
        }
    }
}