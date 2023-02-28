using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebSachCuaEn.Models;
using WebSachCuaEn.Filters;

namespace WebSachCuaEn.Controllers
{
    
    public class LoaiSachController : Controller
    {
        // GET: LoaiSach
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
        public ActionResult LaySachTheoLoai(int id=0)
        {
            SachDBContext db = new SachDBContext();
            var lst = new List<SACH>();
            var categories = db.Loais.ToList();
            ViewBag.data = categories;
            // danh sách Category
            if (id != 0)
            {
                lst = db.SACHes.Where(x => x.Loai.MaLoai == id).ToList();
                

            }
            return View(lst);
        }
    }
}