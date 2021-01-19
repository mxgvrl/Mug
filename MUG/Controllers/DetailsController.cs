using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using MUG.Models;

namespace MUG.Controllers {
    public class DetailsController : Controller {
        
        private readonly MUGContext db;

        public DetailsController(MUGContext context) {
            db = context;
        }

        public async Task<IActionResult> Details(int id) {
            var prod = db.Products.Find(id);
            ViewBag.AdditionsList = new SelectList(db.Additions, "id", "additionName");
            var model = new CoffeeDetailsViewModel {ProductItem = prod};

            return View(model);
        }
    }
}