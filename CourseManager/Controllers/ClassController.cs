using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CourseManager.Models;
using CourseManager.CourseManagerEntities__CourseManager;

namespace CourseManager.Controllers
{ 
    public class ClassController : Controller
    {
        private Models_ db = new Models_();

        //
        // GET: /Class/

        public ViewResult Index()
        {
            return View(db.Class.ToList());
        }

        //
        // GET: /Class/Details/5

        public ViewResult Details(int id)
        {
            Class classes = db.Class.Find(id);
            return View(classes);
        }

        //
        // GET: /Class/Create

        public ActionResult Create()
        {
            return View();
        } 

        //
        // POST: /Class/Create

        [HttpPost]
        public ActionResult Create(Class classes)
        {
            if (ModelState.IsValid)
            {
                db.Class.Add(classes);
                db.SaveChanges();
                return RedirectToAction("Index");  
            }

            return View(classes);
        }
        
        //
        // GET: /Class/Edit/5
 
        public ActionResult Edit(int id)
        {
            Class classes = db.Class.Find(id);
            return View(classes);
        }

        //
        // POST: /Class/Edit/5

        [HttpPost]
        public ActionResult Edit(Class classes)
        {
            if (ModelState.IsValid)
            {
                db.Entry(classes).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(classes);
        }

        //
        // GET: /Class/Delete/5
 
        public ActionResult Delete(int id)
        {
            Class classes = db.Class.Find(id);
            return View(classes);
        }

        //
        // POST: /Class/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {            
            Class classes = db.Class.Find(id);
            db.Class.Remove(classes);
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