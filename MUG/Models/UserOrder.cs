using System;

namespace MUG.Models {
    public class UserOrder
    {
        public int id {get;set;}
        public DateTime orderDate {get;set;}

        public int userId { get; set; }
        public Users Users { get; set; }
        
        // public UserOrder(int id_,int userId_,DateTime orderDate_)
        // {
        //     this.id = id_;
        //     this.userId = userId_;
        //     this.orderDate = orderDate_;
        // }
    }
}