namespace MUG.Models {
    public class Products {
        public int id {get;set;}
        public string productName {get;set;}
        public byte[] productImage {get;set;}
        public string grade {get;set;}
        public int volume {get;set;}
        public string composition {get;set;}
        public int cost {get;set;}

        // public Products(int id_,string productName_,byte[] productImage_,string grade_,int volume_,string composition_,int cost_)
        // {
        //     this.id = id_;
        //     this.productName = productName_;
        //     this.productImage = productImage_;
        //     this.grade = grade_;
        //     this.volume = volume_;
        //     this.composition = composition_;
        //     this.cost = cost_;
        // }
    }
}