using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MonitoringSystem.Models;
using System.Net;
using System.Data.Entity;
using MonitoringSystemModel;

namespace MonitoringSystem.Controllers
{
    public partial class SubjectsController : Controller
    {
        // GET: Subjects
        public ActionResult Index()
        {
            return View(db.Subjects.ToList());
        }
        // GET: Subjects/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Subject subject = db.Subjects.Find(id);
            if (subject == null)
            {
                return HttpNotFound();
            }
            return View(subject);
        }
        // GET: Subjects/Create
        public ActionResult Create()
        {
            return View();
        }
        // POST: Subjects/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "SubjectID,SubjectName,Term,SubjectType")] Subject subject)
        {
            if (ModelState.IsValid)
            {
                db.Subjects.Add(subject);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(subject);
        }
        // GET: Subjects/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Subject subject = db.Subjects.Find(id);
            if (subject == null)
            {
                return HttpNotFound();
            }
            return View(subject);
        }
        // POST: Subjects/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "SubjectID,SubjectName,Term,SubjectType")] Subject subject)
        {
            if (ModelState.IsValid)
            {
                db.Entry(subject).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(subject);
        }
        // GET: Subjects/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Subject subject = db.Subjects.Find(id);
            if (subject == null)
            {
                return HttpNotFound();
            }
            return View(subject);
        }
        // POST: Subjects/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Subject subject = db.Subjects.Find(id);
            db.Subjects.Remove(subject);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        protected string getUrl(string action, string groupId, int? subjectId)
        {
            string url = string.Empty;
            url = action + "/" + groupId + "/" + subjectId.ToString();
            return url;
        }
        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
        public void getIDs(ref List<TemplateToMarks> data)
        {
            for (int i = 0; i < data.Count - 1; i++)
            {
                int ceparatorIndex = data[i].inputId.IndexOf('_');
                data[i].inputId = data[i].inputId.Substring(0, ceparatorIndex);
            }
        }
        public int Cn(string groupId)
        {
            if (groupId != null)
            {
                if (groupId.Length == 4)
                {
                    return Int32.Parse(groupId.Substring(1, 1));
                }
                return Int32.Parse(groupId.Substring(1, 1)) + 1;
            }
            return -1;
        }
        public ActionResult ShowSubjectsByCourseNumber(string groupId)
        {
            SubjectModel model = new SubjectModel();
            List<Subject> getSubjects;
            List<SubjectCP> getSubjectCPs;
            int courseNumber = Cn(groupId);
            if (courseNumber != -1)
            {
                switch (courseNumber)
                {
                    case 1:
                        getSubjects = db.Subjects.Where(subjects => (subjects.Term == 1 || subjects.Term == 2)).ToList();
                        getSubjectCPs = db.SubjectCPs.Where(subjects => (subjects.Term == 1 || subjects.Term == 2)).ToList();
                        break;
                    case 2:
                        getSubjects = db.Subjects.Where(subjects => (subjects.Term == 3 || subjects.Term == 4)).ToList();
                        getSubjectCPs = db.SubjectCPs.Where(subjects => (subjects.Term == 3 || subjects.Term == 4)).ToList();
                        break;
                    case 3:
                        getSubjects = db.Subjects.Where(subjects => (subjects.Term == 5 || subjects.Term == 6)).ToList();
                        getSubjectCPs = db.SubjectCPs.Where(subjects => (subjects.Term == 5 || subjects.Term == 6)).ToList();
                        break;
                    case 4:
                        getSubjects = db.Subjects.Where(subjects => (subjects.Term == 7 || subjects.Term == 8)).ToList();
                        getSubjectCPs = db.SubjectCPs.Where(subjects => (subjects.Term == 7 || subjects.Term == 8)).ToList();
                        break;
                    case 5:
                        getSubjects = db.Subjects.Where(subjects => (subjects.Term == 9 || subjects.Term == 10)).ToList();
                        getSubjectCPs = db.SubjectCPs.Where(subjects => (subjects.Term == 9 || subjects.Term == 10)).ToList();
                        break;
                    case 6:
                        getSubjectCPs = db.SubjectCPs.Where(subjects => (subjects.Term == 11)).ToList();
                        getSubjects = db.Subjects.Where(subjects => subjects.Term == 11).ToList();
                        break;
                    default: return new HttpNotFoundResult();
                }
                ViewBag.GroupNumber = groupId;
                model.subjects = getSubjects;
                model.subjectCPs = getSubjectCPs;
                return View(model);
            }
            return View();
        }
    }
}