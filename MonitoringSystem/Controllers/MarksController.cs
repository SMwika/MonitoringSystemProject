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
    public class MarksController : Controller
    {
        private TotalJournalContext db = new TotalJournalContext();

        // GET: Marks
        public ActionResult Index()
        {
            var marks = db.Marks.Include(m => m.Student).Include(m => m.Subject);
            return View(marks.ToList());
        }

        // GET: Marks/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Mark mark = db.Marks.Find(id);
            if (mark == null)
            {
                return HttpNotFound();
            }
            return View(mark);
        }

        // GET: Marks/Create
        public ActionResult Create()
        {
            ViewBag.RecordBookNumberID = new SelectList(db.Students, "RecordBookNumberID", "RecordBookNumberID");
            ViewBag.SubjectID = new SelectList(db.Subjects, "SubjectID", "SubjectName");
            ViewBag.TeacherID = new SelectList(db.Teachers, "TeacherID", "FirstName");
            return View();
        }

        // POST: Marks/Create
        // Чтобы защититься от атак чрезмерной передачи данных, включите определенные свойства, для которых следует установить привязку. Дополнительные 
        // сведения см. в статье http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "MarkID,LabNumber,RecordBookNumberID,SubjectID,DateOfReport,DateOfProgram,TheMark,AdditionalPoints")] Mark mark)
        {
            if (ModelState.IsValid)
            {
                db.Marks.Add(mark);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.RecordBookNumberID = new SelectList(db.Students, "RecordBookNumberID", "RecordBookNumberID", mark.RecordBookNumberID);
            ViewBag.SubjectID = new SelectList(db.Subjects, "SubjectID", "SubjectName", mark.SubjectID);
            return View(mark);
        }

        // GET: Marks/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Mark mark = db.Marks.Find(id);
            if (mark == null)
            {
                return HttpNotFound();
            }
            ViewBag.RecordBookNumberID = new SelectList(db.Students, "RecordBookNumberID", "RecordBookNumberID", mark.RecordBookNumberID);
            ViewBag.SubjectID = new SelectList(db.Subjects, "SubjectID", "SubjectName", mark.SubjectID);
            return View(mark);
        }

        // POST: Marks/Edit/5
        // Чтобы защититься от атак чрезмерной передачи данных, включите определенные свойства, для которых следует установить привязку. Дополнительные 
        // сведения см. в статье http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "MarkID,LabNumber,RecordBookNumberID,SubjectID,DateOfReport,DateOfProgram,TheMark,AdditionalPoints")] Mark mark)
        {
            if (ModelState.IsValid)
            {
                db.Entry(mark).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.RecordBookNumberID = new SelectList(db.Students, "RecordBookNumberID", "RecordBookNumberID", mark.RecordBookNumberID);
            ViewBag.SubjectID = new SelectList(db.Subjects, "SubjectID", "SubjectName", mark.SubjectID);
            return View(mark);
        }

        // GET: Marks/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Mark mark = db.Marks.Find(id);
            if (mark == null)
            {
                return HttpNotFound();
            }
            return View(mark);
        }

        // POST: Marks/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Mark mark = db.Marks.Find(id);
            db.Marks.Remove(mark);
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
