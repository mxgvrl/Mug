using System.ComponentModel.DataAnnotations;

namespace MUG.Models {
    public class RegisterModel {
        [Required]
        public string UserName { get; set; }
         
        [Required]
        [DataType(DataType.Password)]
        public string UserPassword { get; set; }
         
        [DataType(DataType.Password)]
        [Compare("UserPassword")]
        public string ConfirmPassword { get; set; }
    }
}