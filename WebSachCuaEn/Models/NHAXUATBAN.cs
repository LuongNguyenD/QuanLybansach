using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace WebSachCuaEn.Models
{
    public class NHAXUATBAN
    {
        [Key]
        public int MaNXB { get; set; }
        public string TenNXB { get; set; }
        public string Diachi { get; set; }
        public string DienThoai { get; set; }
    }
}