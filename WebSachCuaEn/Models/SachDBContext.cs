using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace WebSachCuaEn.Models
{
    public class SachDBContext:DbContext
    {
        public SachDBContext() : base("MyCS") { }
        public DbSet<Loai> Loais { get; set; }
        public DbSet<NHAXUATBAN> NHAXUATBANs { get; set; }
        public DbSet<TACGIA> TACGIAs { get; set; }
        public DbSet<SACH> SACHes { get; set; }
        public DbSet<DONDATHANG> DONDATHANGs { get; set; }
        public DbSet<CHITIETDONHANG> CHITIETDONHANGs { get; set; }
        public DbSet<Giohang> Giohangs { get; set; }
    }
}