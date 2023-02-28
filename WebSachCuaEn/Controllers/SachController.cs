using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebSachCuaEn.Models;
using WebSachCuaEn.Filters;

namespace WebSachCuaEn.Controllers
{
    
    public class SachController : Controller
    {
        // GET: Sach
        public ActionResult Index(string searchString="", int mLoai = 0)
        {
            SachDBContext db = new SachDBContext();
            var lst = db.SACHes.ToList();
            var categories = db.Loais.ToList();// danh sách Category
            ViewBag.data = categories;
            if(searchString == "" && mLoai == 0)
            {
                List<SACH> saches = db.SACHes.ToList();
                return View(saches);
            }
            if (searchString != "")
            { 
                lst = db.SACHes.Where(m => m.Tensach.Contains(searchString) || m.TACGIA.TenTG.Contains(searchString) || m.Loai.TenLoai.Contains(searchString)).ToList();
            }
            if (mLoai != 0)
            {
                lst = db.SACHes.Where(x => x.Loai.MaLoai== mLoai).ToList();
            }
            return View(lst);
            
        }
        public ActionResult Detail(int id)
        {
            SachDBContext db = new SachDBContext();
            SACH sach = db.SACHes.Where(row => row.Masach == id).FirstOrDefault();
            return View(sach);
        }

    }
}