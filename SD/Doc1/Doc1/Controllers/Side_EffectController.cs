using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Doc1.Models;

namespace Doc1.Controllers
{
    public class Side_EffectController : Controller
    {
        private HospitalEntities db = new HospitalEntities();

        // GET: Side_Effect
        public ActionResult Index()
        {
            return View(db.Side_Effect.ToList());
        }

        // GET: Side_Effect/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Side_Effect side_Effect = db.Side_Effect.Find(id);
            if (side_Effect == null)
            {
                return HttpNotFound();
            }
            return View(side_Effect);
        }

        // GET: Side_Effect/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Side_Effect/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "id,detail")] Side_Effect side_Effect)
        {
            if (ModelState.IsValid)
            {
                db.Side_Effect.Add(side_Effect);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(side_Effect);
        }

        // GET: Side_Effect/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Side_Effect side_Effect = db.Side_Effect.Find(id);
            if (side_Effect == null)
            {
                return HttpNotFound();
            }
            return View(side_Effect);
        }

        // POST: Side_Effect/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "id,detail")] Side_Effect side_Effect)
        {
            if (ModelState.IsValid)
            {
                db.Entry(side_Effect).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(side_Effect);
        }

        // GET: Side_Effect/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Side_Effect side_Effect = db.Side_Effect.Find(id);
            if (side_Effect == null)
            {
                return HttpNotFound();
            }
            return View(side_Effect);
        }

        // POST: Side_Effect/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Side_Effect side_Effect = db.Side_Effect.Find(id);
            db.Side_Effect.Remove(side_Effect);
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
