using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace WebSachCuaEn.Models
{
    public class SACH
    {
        [Key]
        public int Masach { get; set; }
        public string Tensach { get; set; }
        public Nullable<decimal> Giaban { get; set; }
        public string Mota { get; set; }
        public string Anhbia { get; set; }
        public Nullable<DateTime> Ngaycapnhat { get; set; }
        public Nullable<int> Soluongton { get; set; }
        public Nullable<int> MaLoai { get; set; }
        public Nullable<int> MaNXB { get; set; }
        public Nullable<int> MaTG { get; set; }
        public virtual Loai Loai { get; set; }
        public virtual NHAXUATBAN NHAXUATBAN { get; set; }
        public virtual TACGIA TACGIA { get; set; }
    }
}