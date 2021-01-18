using Microsoft.AspNetCore.Mvc;

namespace MUG.Controllers {
    public class AboutController : Controller{
        public IActionResult About() {
            return View();
        }
    }
}