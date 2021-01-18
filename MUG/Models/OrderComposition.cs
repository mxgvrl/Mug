namespace MUG.Models {
    public class OrderComposition
    {
        public int id {get;set;}
        public string isDone {get;set;}
        
        public int orderId {get;set;}
        public UserOrder UserOrder { get; set; }
        public int productId {get;set;}
        public Products Products { get; set; }
        public int additionId {get;set;}
        public Additions Additions { get; set; }

        // public OrderComposition(int id_,int orderId_,int productId_,int additionId_,string isDone_)
        // {
        //     this.id = id_;
        //     this.orderId = orderId_;
        //     this.productId = productId_;
        //     this.additionId = additionId_;
        //     this.isDone = isDone_;
        // }
    }
}