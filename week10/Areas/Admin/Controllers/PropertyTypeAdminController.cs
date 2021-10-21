using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using week10.Models;

namespace week10.Areas.Admin.Controllers
{
    public class PropertyTypeAdminController : Controller
    {
        private AD25Team11Entities db = new AD25Team11Entities();

        // GET: Admin/Property_Type
        public ActionResult Index()
        {
            return View(db.Property_Type.ToList());
        }

        // GET: Admin/Property_Type/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Property_Type property_Type = db.Property_Type.Find(id);
            if (property_Type == null)
            {
                return HttpNotFound();
            }
            return View(property_Type);
        }

        // GET: Admin/Property_Type/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Admin/Property_Type/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,Property_Type_Name,Property_Amount")] Property_Type property_Type)
        {
            if (ModelState.IsValid)
            {
                db.Property_Type.Add(property_Type);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(property_Type);
        }

        // GET: Admin/Property_Type/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Property_Type property_Type = db.Property_Type.Find(id);
            if (property_Type == null)
            {
                return HttpNotFound();
            }
            return View(property_Type);
        }

        // POST: Admin/Property_Type/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,Property_Type_Name,Property_Amount")] Property_Type property_Type)
        {
            if (ModelState.IsValid)
            {
                db.Entry(property_Type).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(property_Type);
        }

        // GET: Admin/Property_Type/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Property_Type property_Type = db.Property_Type.Find(id);
            if (property_Type == null)
            {
                return HttpNotFound();
            }
            return View(property_Type);
        }

        // POST: Admin/Property_Type/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Property_Type property_Type = db.Property_Type.Find(id);
            db.Property_Type.Remove(property_Type);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
