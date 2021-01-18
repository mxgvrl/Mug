using System.Collections.Generic;
using System.Linq;
using System.Net;
using Microsoft.AspNetCore.Mvc;
using MUG.Models;

namespace MUG.Controllers {
    public class CoffeeController : Controller {
        
        static List<Products> coffees=new List<Products>();
        private MUGContext db;
        public CoffeeController(MUGContext context) {
            db = context;
        }
        
        public IActionResult Coffee() {
            return View(db.Products.ToList());
        }
        

    }
}