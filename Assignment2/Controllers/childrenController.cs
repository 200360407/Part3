using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Assignment.Models;
using Assignment2.Models;

namespace Assignment.Controllers
{
    [Authorize]
    public class childrenController : Controller
    {
        // private CompanyModel db = new CompanyModel();
        //connection moved to EFChildrenRepository
        private EFChildrenRepository db;

        // default constructor - no dependency => use the database
        public childrenController(MocKchildrenRepository @object)
        {

            this.db = new EFChildrenRepository();
        }
        public childrenController(EFChildrenRepository mockRepo)
        {
            this.db = mockRepo;
        }

        // GET: children
        public ActionResult Index()

        {
            return View(db.children);
        }

        private ActionResult View(object p)
        {
            //throw new NotImplementedException();
            return View();
        }

        //public static implicit operator childrenController(List<child> v)
        //{
        //    throw new NotImplementedException();
        //}

        public IQueryable<child> AsQueryable()
        {
            throw new NotImplementedException();
        }

        //  GET: children/Details/5
        public ActionResult Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            child child = db.children.SingleOrDefault(c => c.location == id);
            if (child == null)
            {
                // if HttpNotfound
                return View("Error");
            }
            return View(child);
        }

        //        // GET: children/Create
        //        public ActionResult Create()
        //{
        //    return View();
        //}

        //        public ViewResult Details(int v)
        //        {
        //            throw new NotImplementedException();
        //        }

        //        // POST: children/Create
        //        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        //        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        //        [HttpPost]
        //[ValidateAntiForgeryToken]
        //public ActionResult Create([Bind(Include = "color2,location,Description")] child child)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        db.children.Add(child);
        //        db.SaveChanges();
        //        return RedirectToAction("Index");
        //    }

        //return View(child);
        //}

        // GET: children/Edit/5
        public ActionResult Edit(string destinationLocation)
        {
            if (destinationLocation == null)
            {
                return View("Error");
            }
            // child child = db.children.Find(id);
            // new code unit testing
            //string destinationLocation = "";    
            child child = db.children.SingleOrDefault(c => c.location == destinationLocation);

            if (child == null)
            {
                return View("Error");
            }
            return View(child);
        }

        // POST: children/Edit/5
        //  To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        //more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "color2,location,Description")] child child)
        {
            if (ModelState.IsValid)
            {
                //db.Entry(child).State = EntityState.Modified;
                //db.SaveChanges();
                db.Save(child);
                return RedirectToAction("Index");
            }
            return View(child);
        }

        //     // GET: children/Delete/5
        //     public ActionResult Delete(string id)
        //     {
        //         if (id == null)
        //         {
        //             return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
        //         }
        //            child child = db.children.Find(id);
        //            if (child == null)
        //            {
        //                return HttpNotFound();
        //            }
        //            return View(child);
        //}

        //// POST: children/Delete/5
        //[HttpPost, ActionName("Delete")]
        //[ValidateAntiForgeryToken]
        //public ActionResult DeleteConfirmed(string id)
        //{
        //    child child = db.children.Find(id);
        //    db.children.Remove(child);
        //    db.SaveChanges();
        //    return RedirectToAction("Index");
        //}

        public child Save(child child)
        {
            if (child.location != null)
            {
                //db.Entry(child).State = EntityState.Modified;
                db.Save(child);
            }
            else
            {
                //db.children.(child);
                db.Save(child);
            }
            //db.SaveChanges();
            return child;
        }
    }
}
//protected override void Dispose(bool disposing)
//{
//    if (disposing)
//    {
//        db.Dispose();
//    }
//    base.Dispose(disposing);
//}
//    }
//}
