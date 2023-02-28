using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace WebSachCuaEn.ViewModel
{
    public class RegisterVM
    {
        [Required(ErrorMessage = "Ten dang nhap khong duoc de trong")]
        public string UserName { get; set; }
        [Required(ErrorMessage = "Mat khau khong duoc de trong")]
        public string Password { get; set; }
        [Required(ErrorMessage = "Vui long xac nhan lai mat khau")]
        [Compare("Password", ErrorMessage = "Password va Confirm Password khong trung khop")]
        public string ConfirmPassword { get; set; }
        [Required(ErrorMessage = "Khong duoc de trong email")]
        [EmailAddress(ErrorMessage = "Ten Email da ton tai")]
        public string Email { get; set; }
        public DateTime? DateBirth { get; set; }
        public string Gender { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
    }
}