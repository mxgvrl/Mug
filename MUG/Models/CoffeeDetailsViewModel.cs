using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore.Query.SqlExpressions;

namespace MUG.Models {
    public class CoffeeDetailsViewModel {
        public Products ProductItem { get; set; }

        public Additions AdditionsItem1 { get; set; }
        public Additions AdditionsItem2 { get; set; }
        public Additions AdditionsItem3 { get; set; }    
    }
}