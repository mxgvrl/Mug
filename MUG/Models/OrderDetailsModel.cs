using Microsoft.AspNetCore.Mvc.Rendering;

namespace MUG.Models {
    public class OrderDetailsModel {
        public Products ProductItem { get; set; }
        public Additions AdditionsItem1 { get; set; }
        public Additions AdditionsItem2 { get; set; }
        public Additions AdditionsItem3 { get; set; }   
        public int Sum { get; set; }
    }
}