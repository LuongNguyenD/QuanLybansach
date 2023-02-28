using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace WebSachCuaEn.Models
{
    public class DONDATHANG
    {
        [Key]
        public int MaDonHang { get; set; }
        public Nullable<bool> Dathanhtoan { get; set; }
        public Nullable<bool> Tinhtranggiaohang { get; set; }
        public Nullable<DateTime> Ngaydat { get; set; }
        public Nullable<DateTime> Ngaygiao { get; set; }
    }
}