using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ShoesOnline.Models.Account
{
    public class Account
    {
        public int ID { get; set; }
        
        [Required(ErrorMessage = "Vui lòng nhập email")]
        public string Email { get; set; }
        
        [Required(ErrorMessage = "Vui lòng nhập số diện thoại")]
        [StringLength(10, ErrorMessage = "Sô điện thoại không đúng định dạng")]
        public string Phone { get; set; }
        
        [Required(ErrorMessage = "Vui lòng nhập mật khẩu")]
        [StringLength(20, MinimumLength = 6, ErrorMessage = "Mật khẩu phải có độ dài 6-20 kí tự")]
        public string Passsword { get; set; }

        public string Role { get; set; }

        [Required(ErrorMessage = "Vui lòng nhập họ và tên")]
        public string Fullname { get; set; }
        
        [Required(ErrorMessage = "Vui lòng chọn giới tính")]
        public string Gender { get; set; }
        
        public string AvatarPath { get; set; }
    }
}
