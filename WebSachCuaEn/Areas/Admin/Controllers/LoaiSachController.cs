using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebSachCuaEn.Models;
using WebSachCuaEn.Filters;

namespace WebSachCuaEn.Areas.Admin.Controllers
{
    [AdminAuthorization]
    public class LoaiSachController : Controller
    {
        // GET: Admin/LoaiSach 
        public ActionResult Index()
        {
            SachDBContext db = new SachDBContext();
            List<Loai> loais = db.Loais.ToList();
            return View(loais);
        }
        public ActionResult Detail(int id)
        {
            SachDBContext db = new SachDBContext();
            Loai de = db.Loais.Where(row => row.MaLoai == id).FirstOrDefault();
            int count = db.SACHes.Where(r => r.MaLoai == id).ToList().Count;
            ViewBag.count = count;
            return View(de);
        }
        public ActionResult LaySachTheoLoai(int id)
        {
            SachDBContext db = new SachDBContext();
            List<SACH> empls = db.SACHes.Where(row => row.MaLoai == id).ToList();
            ViewBag.id = id;
            return View(empls);
        }

    }
}