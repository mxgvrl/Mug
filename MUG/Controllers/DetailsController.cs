using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MUG.Models;

namespace MUG.Controllers {
    public class DetailsController : Controller {
        private readonly MUGContext db;

        public DetailsController(MUGContext context) {
            db = context;
        }

        public async Task<IActionResult> Details(int id) {
            var prod = db.Products.Find(id);
            var model = new CoffeeDetailsViewModel {ProductItem = prod};
            return View(model);
        }
    }
}