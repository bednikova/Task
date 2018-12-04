using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using WebApplication.Data;
using WebApplication.Models;

namespace WebApplication.Controllers
{
    public class OwnersController : Controller
    {
        private StoreContext db = new StoreContext();

        // GET: Owners
        public ActionResult Index()
        {
            return View(db.Owners.ToList());
        }

        // GET: Owners/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Owners owners = db.Owners.Find(id);
            if (owners == null)
            {
                return HttpNotFound();
            }
            return View(owners);
        }

        // GET: Owners/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Owners/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "OwnersId,Name")] Owners owners)
        {
            if (ModelState.IsValid)
            {
                db.Owners.Add(owners);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(owners);
        }

        // GET: Owners/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Owners owners = db.Owners.Find(id);
            if (owners == null)
            {
                return HttpNotFound();
            }
            return View(owners);
        }

        // POST: Owners/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "OwnersId,Name")] Owners owners)
        {
            if (ModelState.IsValid)
            {
                db.Entry(owners).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(owners);
        }

        // GET: Owners/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Owners owners = db.Owners.Find(id);
            if (owners == null)
            {
                return HttpNotFound();
            }
            return View(owners);
        }

        // POST: Owners/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Owners owners = db.Owners.Find(id);
            db.Owners.Remove(owners);
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
