using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Web_OnlineShop.Models
{
    public class UserRegister
    {
        [Required]
        [Display(Name="Tên đăng nhập")]
        public string UserName { get; set; }
        [Required]
        [Display(Name = "Mật khẩu")]
        [StringLength(20,MinimumLength=6,ErrorMessage="Phải ít nhất 6 ký tự")]
        public string Password { get; set; }
        [Display(Name = "Xác nhận mật khẩu")]
        [Compare("Password", ErrorMessage = "Xác nhận mật khẩu không đúng!")]
        public string ConfirmPassword { get; set; }
        [Display(Name = "Họ Tên")]
        public string Name { get; set; }

        [Display(Name = "Địa chỉ")]
        public string Address { get; set; }
        
        [Display(Name = "Email")]
        public string Email { get; set; }
        [Display(Name = "Điện Thoại")]
        public string Phone { get; set; }
        
    }
}