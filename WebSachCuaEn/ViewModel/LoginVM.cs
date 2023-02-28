using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace WebSachCuaEn.ViewModel
{
    public class LoginVM
    {
        [Required(ErrorMessage = "Ten dang nhap khong duoc de trong")]
        public string UserName { get; set; }
        [Required(ErrorMessage = "Mat khau khong duoc de trong")]
        public string Password { get; set; }
    }
}