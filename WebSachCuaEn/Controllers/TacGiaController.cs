using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebSachCuaEn.Models;
using WebSachCuaEn.Filters;

namespace WebSachCuaEn.Controllers
{
    
    public class TacGiaController : Controller
    {
        // GET: TacGia
        public ActionResult Index()
        {
            SachDBContext db = new SachDBContext();
            List<TACGIA> tg = db.TACGIAs.ToList();
            return View(tg);
        }
    }
}