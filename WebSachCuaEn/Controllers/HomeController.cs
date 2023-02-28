using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebSachCuaEn.Models;

namespace WebSachCuaEn.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index(string searchString)
        {
            SachDBContext db = new SachDBContext();
            var lst = new List<SACH>();
            if (!String.IsNullOrEmpty(searchString))
                lst = db.SACHes.Where(m => m.Tensach.Contains(searchString) || m.Mota.Contains(searchString)).ToList();
            return View(lst);
        }
        public ActionResult Search(string searchString)
        {
            
            SachDBContext db = new SachDBContext();
            var lst = new List<SACH>();
           if(!String.IsNullOrEmpty(searchString))
                 lst = db.SACHes.Where(m => m.Tensach.Contains(searchString) || m.Mota.Contains(searchString)).ToList();
            return View(lst);
        }
    }
}