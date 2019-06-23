using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CourseManager.Models;

namespace CourseManager.Controllers
{ 
    public class CourseManagerController : Controller
    {
        private CourseManagerEntities1 db = new CourseManagerEntities1();

        //
        // GET: /CourseManager/

        public ViewResult Index()
        {
            return View(db.CourseManager.ToList());
        }

        //
        // GET: /CourseManager/Details/5

        public ViewResult Details(int id)
        {
            CourseManagers coursemanagers = db.CourseManager.Find(id);
            return View(coursemanagers);
        }

        //
        // GET: /CourseManager/Create

        public ActionResult Create()
        {
            var classes = db.Classes.ToList();
            ViewBag.Classes = classes;

            var teachers = db.Teachers.ToList();
            ViewBag.Classes =teachers ;

            var course = db.Course.ToList();
            ViewBag.Courses = course;
            return View();
        }
        //
        // POST: /CourseManager/Create

        [HttpPost]
        public ActionResult Create(CourseManagers coursemanager)
        {
            if (ModelState.IsValid)
            {
                db.CourseManager.Add(coursemanagers);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(coursemanager);
        }
        
        //
        // GET: /CourseManager/Edit/5
 
        public ActionResult Edit(int id)
        {
            CourseManager coursemanagers = db.CourseManager.Find(id);
            return View(coursemanagers);
        }

        //
        // GET: /CourseManager/Delete/5
 
        public ActionResult Delete(int id)
        {
            CourseManagers coursemanager = db.CourseManager.Find(id);
            return View(coursemanager);
        }

        //
        // POST: /CourseManager/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {            
            CourseManagers coursemanager = db.CourseManagers.Find(id);
            db.CourseManager.Remove(coursemanagers);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }
    }
}