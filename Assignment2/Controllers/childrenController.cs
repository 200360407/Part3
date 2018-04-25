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
          private MockchildrenRepository db;

        // default constructor - no dependency => use the database
        public childrenController()
        {

            this.db = new EFChildrenRepository();
        }
        public childrenController(MockchildrenRepository mockRepo)
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
            throw new NotImplementedException();
        }

        // GET: children/Details/5
        //public ActionResult Details(string id)
        //{
        //    if (id == null)
        //    {
        //        return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
        //    }
        //    child child = db.children.Find(id);
        //    if (child == null)
        //    {
        //        return HttpNotFound();
        //    }
        //    return View(child);
        //}

        //// GET: children/Create
        //public ActionResult Create()
        //{
        //    return View();
        //}

        //// POST: children/Create
        //// To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        //// more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public ActionResult Create([Bind(Include = "color2,location,Description")] child child)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        db.children.Add(child);
        //        db.SaveChanges();
        //        return RedirectToAction("Index");
        //    }

        //    return View(child);
        //}

        //// GET: children/Edit/5
        //public ActionResult Edit(string id)
        //{
        //    if (id == null)
        //    {
        //        return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
        //    }
        //    child child = db.children.Find(id);
        //    if (child == null)
        //    {
        //        return HttpNotFound();
        //    }
        //    return View(child);
        //}

        //// POST: children/Edit/5
        //// To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        //// more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public ActionResult Edit([Bind(Include = "color2,location,Description")] child child)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        db.Entry(child).State = EntityState.Modified;
        //        db.SaveChanges();
        //        return RedirectToAction("Index");
        //    }
        //    return View(child);
        //}

        //// GET: children/Delete/5
        //public ActionResult Delete(string id)
        //{
        //    if (id == null)
        //    {
        //        return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
        //    }
        //    child child = db.children.Find(id);
        //    if (child == null)
        //    {
        //        return HttpNotFound();
        //    }
        //    return View(child);
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

        //protected override void Dispose(bool disposing)
        //{
        //    if (disposing)
        //    {
        //        db.Dispose();
        //    }
        //    base.Dispose(disposing);
        //}
    }
}
