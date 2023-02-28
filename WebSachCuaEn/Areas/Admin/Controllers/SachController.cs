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
    public class SachController : Controller
    {
        // GET: Admin/Sach
        [MyAuthenFilter]
        public ActionResult Index(string searchString, int mLoai = 0)
        {
            SachDBContext db = new SachDBContext();
            var lst = new List<SACH>();
            var categories = db.Loais.ToList();
            ViewBag.data = categories;
            ViewBag.categoryID = new SelectList(categories, "CategoryID", "CategoryName"); // danh sách Category
            if (mLoai != 0)
            {
                lst = db.SACHes.Where(x => x.MaLoai == mLoai).ToList();
            }
            if (!String.IsNullOrEmpty(searchString))
            {
                lst = db.SACHes.Where(m => m.Tensach.Contains(searchString) || m.Mota.Contains(searchString) || m.TACGIA.TenTG.Contains(searchString) || m.Loai.TenLoai.Contains(searchString)).ToList();
                return View(lst);
            }
            List<SACH> saches = db.SACHes.ToList();
            return View(saches);
        }
        public ActionResult Create()
        {
            SachDBContext db = new SachDBContext();
            List<Loai> loais = db.Loais.ToList();
            ViewBag.loais = loais;
            List<NHAXUATBAN> nxbs = db.NHAXUATBANs.ToList();
            ViewBag.nxbs = nxbs;
            return View();
        }
        [HttpPost]
        public ActionResult Create(SACH sh)
        {
            if (ModelState.IsValid)
            {
                SachDBContext db = new SachDBContext();
                db.SACHes.Add(sh);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            else
            {
                return RedirectToAction("Create");
            }
        }
        public ActionResult Edit(int id)
        {
            SachDBContext db = new SachDBContext();
            SACH sach = db.SACHes.Where(row => row.Masach == id).FirstOrDefault();
            ViewBag.SACH = db.SACHes.ToList();
            List<Loai> loais = db.Loais.ToList();
            ViewBag.loais = loais;
            List<NHAXUATBAN> nxbs = db.NHAXUATBANs.ToList();
            ViewBag.nxbs = nxbs;
            return View(sach);
        }
        [HttpPost]
        public ActionResult Edit(SACH sh)
        {
            SachDBContext db = new SachDBContext();
            SACH sach = db.SACHes.Where(row => row.Masach == sh.Masach).FirstOrDefault();
            //Update
            sach.Tensach = sh.Tensach;
            sach.Giaban = sh.Giaban;
            sach.Mota = sh.Mota;
            sach.Ngaycapnhat = sh.Ngaycapnhat;
            sach.Soluongton = sh.Soluongton;
            sach.MaLoai = sh.MaLoai;
            sach.MaNXB = sh.MaNXB;
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult Delete(int id)
        {
            SachDBContext db = new SachDBContext();
            SACH epl = db.SACHes.Where(row => row.Masach == id).FirstOrDefault();
            return View(epl);
        }
        [HttpPost]
        public ActionResult Delete(int id, SACH epm)
        {
            SachDBContext db = new SachDBContext();
            SACH epl = db.SACHes.Where(row => row.Masach == id).FirstOrDefault();
            db.SACHes.Remove(epl);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult Detail(int id)
        {
            SachDBContext db = new SachDBContext();
            SACH sach = db.SACHes.Where(row => row.Masach == id).FirstOrDefault();
            return View(sach);
        }
    }
}