using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebSachCuaEn.Filters;
using WebSachCuaEn.Models;

namespace WebSachCuaEn.Areas.Admin.Controllers
{
    [AdminAuthorization]
    public class TacGiaController : Controller
    {
        // GET: Admin/TacGia
        public ActionResult Index()
        {
            SachDBContext db = new SachDBContext();
            List<TACGIA> loais = db.TACGIAs.ToList();
            return View(loais);
        }
    }
}