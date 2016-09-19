using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using QuadFace.Models;

namespace QuadFace.Controllers
{
    public class SampleDataController : Controller
    {
        private SampleContext db = new SampleContext();

        // GET: SampleData
        public ActionResult Index()
        {
            return View(db.SampleDatas.ToList());
        }

        // GET: SampleData/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SampleData sampleData = db.SampleDatas.Find(id);
            if (sampleData == null)
            {
                return HttpNotFound();
            }
            return View(sampleData);
        }

        // GET: SampleData/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: SampleData/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Name,Age,DataOfBirth,Email,Address")] SampleData sampleData)
        {
            if (ModelState.IsValid)
            {
                db.SampleDatas.Add(sampleData);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(sampleData);
        }

        // GET: SampleData/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SampleData sampleData = db.SampleDatas.Find(id);
            if (sampleData == null)
            {
                return HttpNotFound();
            }
            return View(sampleData);
        }

        // POST: SampleData/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Name,Age,DataOfBirth,Email,Address")] SampleData sampleData)
        {
            if (ModelState.IsValid)
            {
                db.Entry(sampleData).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(sampleData);
        }

        // GET: SampleData/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SampleData sampleData = db.SampleDatas.Find(id);
            if (sampleData == null)
            {
                return HttpNotFound();
            }
            return View(sampleData);
        }

        // POST: SampleData/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            SampleData sampleData = db.SampleDatas.Find(id);
            db.SampleDatas.Remove(sampleData);
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
