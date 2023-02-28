using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace WebSachCuaEn.Models
{
    public class TACGIA
    {
        [Key]
        public int MaTG { get; set; }
        public string TenTG { get; set; }
        public string Diachi { get; set; }
        public string Tieusu { get; set; }
        public string Dienthoai { get; set; }
    }
}