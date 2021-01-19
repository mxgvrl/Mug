using System;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using MUG.Models;

namespace MUG.Controllers {
    public class OrderController : Controller{
        public readonly MUGContext db;

        public OrderController(MUGContext context) {
            db = context;
        }

        public async Task<IActionResult> Order(int prodId, string addit1, string addit2, string addit3, 
            int prodCost, int additCost1, int additCost2, int additCost3) { 
            var prod = db.Products.Find(prodId);
            var addition1 = db.Additions.Find(Convert.ToInt32(addit1));
            var addition2 = db.Additions.Find(Convert.ToInt32(addit2));
            var addition3 = db.Additions.Find(Convert.ToInt32(addit3));
            var sum = db.Products.Find(prodId).cost;
            if (db.Additions.Find(Convert.ToInt32(addit1)) != null) {
                sum += db.Additions.Find(Convert.ToInt32(addit1)).cost;
                if (db.Additions.Find(Convert.ToInt32(addit2)) != null) {
                    sum += db.Additions.Find(Convert.ToInt32(addit2)).cost;
                    if (db.Additions.Find(Convert.ToInt32(addit3)) != null) {
                        sum += db.Additions.Find(Convert.ToInt32(addit3)).cost;
                    }
                }
            }
            var model = new OrderDetailsModel {ProductItem = prod, AdditionsItem1 = addition1, AdditionsItem2 = addition2, AdditionsItem3 = addition3, Sum = sum};
            
            var uId = User.FindFirst(x => x.Type == ClaimTypes.Name).Value;
            var userId = db.Users.Where(y => y.userName == uId).Select(u => u.id).FirstOrDefault();
            var date = DateTime.Today.ToString("yyyy-MM-dd");
            await db.Database.ExecuteSqlInterpolatedAsync($"INSERT INTO UserOrder VALUES ({userId}, {date})");
            return View(model);
        }

        public RedirectToRouteResult SendOrder(int prodId, int addition1, int addition2, int addition3) {
            var uId = User.FindFirst(x => x.Type == ClaimTypes.Name).Value;
            var userId = db.Users.Where(y => y.userName == uId).Select(u => u.id).FirstOrDefault();
            var orderId = db.UserOrder.Where(y => y.userId == userId).Select(u => u.id).FirstOrDefault();
            if (addition1 != 0) {
                db.Database.ExecuteSqlInterpolated($"INSERT INTO OrderComposition VALUES ({orderId}, {prodId}, {addition1}, 'Not Done')");
                if (addition2 != 0) {
                    db.Database.ExecuteSqlInterpolated($"INSERT INTO OrderComposition VALUES ({orderId}, {prodId}, {addition2}, 'Not Done')");
                    if (addition3 != 0) {
                        db.Database.ExecuteSqlInterpolated($"INSERT INTO OrderComposition VALUES ({orderId}, {prodId}, {addition3}, 'Not Done')");
                    }
                }
            }
            else {
                db.Database.ExecuteSqlInterpolated($"INSERT INTO OrderComposition (orderId, productId, isDone) VALUES ({orderId}, {prodId}, 'Not Done')");
            }

            return RedirectToRoute(new { controller="Home", action="Home"});
        }
        
    }
}