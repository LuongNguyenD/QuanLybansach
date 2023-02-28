using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebSachCuaEn.Identity;
using WebSachCuaEn.Filters;

namespace WebSachCuaEn.Areas.Admin.Controllers
{
    [AdminAuthorization]
    public class UsersController : Controller
    {
        // GET: Admin/Users
        public ActionResult Index()
        {
            AppDBContext db = new AppDBContext();
            List<AppUser> users = db.Users.ToList();
            return View(users);
        }
        public ActionResult Create()
        {
            AppDBContext db = new AppDBContext();
            List<AppUser> users = db.Users.ToList();
            return View();
        }
        [HttpPost]
        public ActionResult Create(AppUser us)
        {
            if (ModelState.IsValid)
            {
                AppDBContext db = new AppDBContext();
                db.Users.Add(us);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            else
            {
                return RedirectToAction("Create");
            }
        }
        public ActionResult Edit(String id)
        {
            AppDBContext db = new AppDBContext();
            AppUser sach = db.Users.Where(row => row.Id == id).FirstOrDefault();
            ViewBag.Id = db.Users.ToList();
            return View(sach);
        }
        [HttpPost]
        public ActionResult Edit(AppUser sh)
        {
            AppDBContext db = new AppDBContext();
            AppUser sach = db.Users.Where(row => row.Id == sh.Id).FirstOrDefault();
            //Update
            sach.UserName = sh.UserName;
            sach.PhoneNumber = sh.PhoneNumber;
            sach.Email = sh.Email;
            sach.Address = sh.Address;
            sach.City = sh.City;
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult Delete(String id)
        {
            AppDBContext db = new AppDBContext();
            AppUser epl = db.Users.Where(row => row.Id == id).FirstOrDefault();
            return View(epl);
        }
        [HttpPost]
        public ActionResult Delete(String id, AppUser epm)
        {
            AppDBContext db = new AppDBContext();
            AppUser epl = db.Users.Where(row => row.Id == id).FirstOrDefault();
            db.Users.Remove(epl);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}