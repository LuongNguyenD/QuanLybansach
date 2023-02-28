using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace WebSachCuaEn.Models
{
    public class CHITIETDONHANG
    {
        [Key]
        public int MaCTDonHang { get; set; }
        public int MaDonHang { get; set; }
        public int Masach { get; set; }
        public Nullable<int> Soluong { get; set; }
        public Nullable<decimal> Dongia { get; set; }
        public virtual DONDATHANG DONDATHANG { get; set; }
        public virtual SACH SACH { get; set; }
    }
}