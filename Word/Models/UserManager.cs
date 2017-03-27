using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Word.Models
{
    public class UserManager
    {
        public int Id { get; set; }

      //  [Required] //thêm cái này thì tên bắt buộc phải nhập. cái này gọi là Validation Attribus
        [Display(Name = "Họ và Tên")]
        [Required(ErrorMessage = "Họ và Tên bắt buộc phải nhập!")]
        public string Name { get; set; }
        [Required(ErrorMessage ="Email bắt buộc phải nhập!")]
        public string Email { get; set; }
        public string Address { get; set; }
      //  [Range(1, 10)] // từ 1 -> 10
        public int Phone { get; set; }
        public DateTime BirthDay { get; set; }
        public bool Status { get; set; }
        
        public bool Roles { get; set; }
    }
}