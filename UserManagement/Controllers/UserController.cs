using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;
using UserManagement.Models;

namespace UserManagement.Controllers
{
    public class UserController : Controller
    {
        public UserDBContext dbuser = new UserDBContext();
        // GET: User
        public ActionResult Index()
        {
            var data = dbuser.Users.ToList();
            return View(data);
        }

        public ActionResult Details(int id)
        {
            var data = dbuser.Users.Find(id);
            return View(data);
        }

        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(users u)
        {
            dbuser.Users.Add(u);
            dbuser.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult Edit(int id)
        {
            var data = dbuser.Users.Where(x => x.ID == id).FirstOrDefault();
            return View(data);
        }
        [HttpPost]
        public ActionResult Edit(users u)
        {
            dbuser.Entry(u).State = EntityState.Modified ;
            dbuser.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult Delete(int id)
        {
            var data = dbuser.Users.Find(id);
            dbuser.Entry(data).State = EntityState.Deleted;
            dbuser.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}