using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using MonitoringSystem.Models;

namespace MonitoringSystem.Controllers
{
    public class CourseProjectLinesController : Controller
    {
        private TotalJournalContext db = new TotalJournalContext();

        // GET: CourseProjectLines
        public ActionResult Index()
        {
            var courseProjectLines = db.CourseProjectLines.Include(c => c.Student).Include(c => c.SubjectCP);
            return View(courseProjectLines.ToList());
        }

        // GET: CourseProjectLines/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CourseProjectLine courseProjectLine = db.CourseProjectLines.Find(id);
            if (courseProjectLine == null)
            {
                return HttpNotFound();
            }
            return View(courseProjectLine);
        }

        // GET: CourseProjectLines/Create
        public ActionResult Create()
        {
            ViewBag.RecordBookNumberID = new SelectList(db.Students, "RecordBookNumberID", "GroupID");
            ViewBag.SubjectCP_ID = new SelectList(db.SubjectCPs, "SubjectCP_ID", "SubjectCPName");
            return View();
        }

        // POST: CourseProjectLines/Create
        // Чтобы защититься от атак чрезмерной передачи данных, включите определенные свойства, для которых следует установить привязку. Дополнительные 
        // сведения см. в статье http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "CourseProjectLineID,LineName,RecordBookNumberID,SubjectCP_ID,TheMark,TeacherID")] CourseProjectLine courseProjectLine)
        {
            if (ModelState.IsValid)
            {
                db.CourseProjectLines.Add(courseProjectLine);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.RecordBookNumberID = new SelectList(db.Students, "RecordBookNumberID", "GroupID", courseProjectLine.RecordBookNumberID);
            ViewBag.SubjectCP_ID = new SelectList(db.SubjectCPs, "SubjectCP_ID", "SubjectCPName", courseProjectLine.SubjectCP_ID);
            return View(courseProjectLine);
        }

        // GET: CourseProjectLines/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CourseProjectLine courseProjectLine = db.CourseProjectLines.Find(id);
            if (courseProjectLine == null)
            {
                return HttpNotFound();
            }
            ViewBag.RecordBookNumberID = new SelectList(db.Students, "RecordBookNumberID", "GroupID", courseProjectLine.RecordBookNumberID);
            ViewBag.SubjectCP_ID = new SelectList(db.SubjectCPs, "SubjectCP_ID", "SubjectCPName", courseProjectLine.SubjectCP_ID);
            return View(courseProjectLine);
        }

        // POST: CourseProjectLines/Edit/5
        // Чтобы защититься от атак чрезмерной передачи данных, включите определенные свойства, для которых следует установить привязку. Дополнительные 
        // сведения см. в статье http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "CourseProjectLineID,LineName,RecordBookNumberID,SubjectCP_ID,TheMark,TeacherID")] CourseProjectLine courseProjectLine)
        {
            if (ModelState.IsValid)
            {
                db.Entry(courseProjectLine).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.RecordBookNumberID = new SelectList(db.Students, "RecordBookNumberID", "GroupID", courseProjectLine.RecordBookNumberID);
            ViewBag.SubjectCP_ID = new SelectList(db.SubjectCPs, "SubjectCP_ID", "SubjectCPName", courseProjectLine.SubjectCP_ID);
            return View(courseProjectLine);
        }

        // GET: CourseProjectLines/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CourseProjectLine courseProjectLine = db.CourseProjectLines.Find(id);
            if (courseProjectLine == null)
            {
                return HttpNotFound();
            }
            return View(courseProjectLine);
        }

        // POST: CourseProjectLines/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            CourseProjectLine courseProjectLine = db.CourseProjectLines.Find(id);
            db.CourseProjectLines.Remove(courseProjectLine);
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
