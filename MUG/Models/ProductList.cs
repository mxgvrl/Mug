using System.Collections.Generic;

namespace MUG.Models {
    public class ProductList {
        public IEnumerable<Products> productsList { get; set; }
        
        public Products products { get; set; }
    }
}