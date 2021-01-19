using System;

namespace MUG.Models {
    public class UserOrder
    {
        public int id {get;set;}
        public DateTime orderDate {get;set;}

        public int userId { get; set; }
        public Users Users { get; set; }
        
        public UserOrder(int userId, DateTime orderDate)
        {
            this.userId = userId;
            this.orderDate = orderDate;
        }
    }
}