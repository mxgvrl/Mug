using System.ComponentModel.DataAnnotations.Schema;

namespace MUG.Models {
    public class Users { 
        public int id {get;set;}
        public string userName {get;set;}
        public string userPassword {get;set;}
        
        public string adress {get;set;}
        public string userRole {get;set;}

        // public Users(int id_,string userName_,string userPassword_,string adress_,string userRole_)
        // {
        //     this.id = id_;
        //     this.userName = userName_;
        //     this.userPassword = userPassword_;
        //     this.adress = adress_;
        //     this.userRole = userRole_;
        // }
    }
}