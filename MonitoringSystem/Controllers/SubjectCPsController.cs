using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using MonitoringSystemModel;

namespace MonitoringSystem.Controllers
{
    public class SubjectCPsController : Controller
    {
        private TotalJournalContext db = new TotalJournalContext();

        // GET: SubjectCPs
        public ActionResult Index()
        {
            var subjectCPs = db.SubjectCPs.Include(s => s.Teacher);
            return View(subjectCPs.ToList());
        }

        // GET: SubjectCPs/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SubjectCP subjectCP = db.SubjectCPs.Find(id);
            if (subjectCP == null)
            {
                return HttpNotFound();
            }
            return View(subjectCP);
        }

        // GET: SubjectCPs/Create
        public ActionResult Create()
        {
            ViewBag.TeacherID = new SelectList(db.Teachers, "TeacherID", "FirstName");
            return View();
        }

        // POST: SubjectCPs/Create
        // Чтобы защититься от атак чрезмерной передачи данных, включите определенные свойства, для которых следует установить привязку. Дополнительные 
        // сведения см. в статье http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "SubjectCP_ID,TeacherID,SubjectCPName,Term")] SubjectCP subjectCP)
        {
            if (ModelState.IsValid)
            {
                db.SubjectCPs.Add(subjectCP);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.TeacherID = new SelectList(db.Teachers, "TeacherID", "FirstName", subjectCP.TeacherID);
            return View(subjectCP);
        }

        // GET: SubjectCPs/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SubjectCP subjectCP = db.SubjectCPs.Find(id);
            if (subjectCP == null)
            {
                return HttpNotFound();
            }
            ViewBag.TeacherID = new SelectList(db.Teachers, "TeacherID", "FirstName", subjectCP.TeacherID);
            return View(subjectCP);
        }

        // POST: SubjectCPs/Edit/5
        // Чтобы защититься от атак чрезмерной передачи данных, включите определенные свойства, для которых следует установить привязку. Дополнительные 
        // сведения см. в статье http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "SubjectCP_ID,TeacherID,SubjectCPName,Term")] SubjectCP subjectCP)
        {
            if (ModelState.IsValid)
            {
                db.Entry(subjectCP).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.TeacherID = new SelectList(db.Teachers, "TeacherID", "FirstName", subjectCP.TeacherID);
            return View(subjectCP);
        }

        // GET: SubjectCPs/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SubjectCP subjectCP = db.SubjectCPs.Find(id);
            if (subjectCP == null)
            {
                return HttpNotFound();
            }
            return View(subjectCP);
        }

        // POST: SubjectCPs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            SubjectCP subjectCP = db.SubjectCPs.Find(id);
            db.SubjectCPs.Remove(subjectCP);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult ShowMarks(string groupId, int? subjectId)
        {
            if (groupId == null || subjectId == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ModelListSubjectCPs model = new ModelListSubjectCPs()
            {
                studentsToShow = db.Students.Where(st => st.GroupID == groupId).ToList(),
                GroupName = groupId,
                SubjectCPId = (int)subjectId,
                SubjectCPName = db.SubjectCPs.Find(subjectId).SubjectCPName,
                linesToShow = db.CourseProjectLines.Where(cpl => cpl.SubjectCP_ID == subjectId && cpl.Student.GroupID == groupId).ToList(),
                cpLinesMaxPoints = db.CPLineMaxPoints.Where(cplmp => cplmp.SubjectCPID == subjectId).ToList()
            };
            return View(model);
        }
        public ActionResult AddCPLine(string groupId, int? subjectId)
        {
            SubjectCP subjectCP = db.SubjectCPs.Find(subjectId);
            List<Group> groups = subjectCP.Groups.ToList();
            Group group = db.Groups.Find(groupId);
            int MaxLineIndex = 0, MaxCP_ID = 0, MaxCPLineMaxPointID = 0;
            if (group.Students.Count == 0)
            {
                ViewBag.ErrorText = "Сначала  добавьте студентов в группу!";
                return View("Error");
            }

            if (db.CourseProjectLines.Count() > 0)
            {
                MaxLineIndex = db.CourseProjectLines
                .Where(m => m.SubjectCP.SubjectCP_ID == subjectId && m.Student.GroupID == groupId)
                .Max(m => m.LineIndex);
                MaxCP_ID = db.CourseProjectLines.Max(m => m.CourseProjectLineID);
            }
            if (db.CPLineMaxPoints.Count() > 0)
            {
                MaxCPLineMaxPointID = db.CPLineMaxPoints.Max(m => m.CPLineMaxPointID);
            }
            db.CPLineMaxPoints.Add(new CPLineMaxPoint() { CPLineMaxPointID = MaxCPLineMaxPointID + 1, LineIndex = MaxLineIndex + 1, MaxPoint = 0, SubjectCPID = (int)subjectId, LineName = "Новый этап"});
            foreach (var grp in groups)
            {
                foreach (var student in grp.Students)
                {
                    MaxCP_ID++;
                    subjectCP.CourseProjectLines.Add(new CourseProjectLine()
                    {
                        CourseProjectLineID = MaxCP_ID,
                        LineIndex = (MaxLineIndex + 1),
                        RecordBookNumberID = student.RecordBookNumberID,
                        DateOfPassing = DateTime.Now,
                        SubjectCP_ID = Convert.ToInt32(subjectId),
                        TheMark = 0,
                        LineName = "Новый этап"
                    });
                }
            }
            //foreach (var student in studentsInGroup)
            //{
            //    MaxCP_ID++;
            //    subject.CourseProjectLines.Add(new CourseProjectLine()
            //    {
            //        CourseProjectLineID = MaxCP_ID,
            //        LineIndex = (MaxLineIndex + 1),
            //        RecordBookNumberID = student.RecordBookNumberID,
            //        DateOfPassing = DateTime.Now,
            //        SubjectCP_ID = Convert.ToInt32(subjectId),
            //        TheMark = 0,
            //        LineName = "Новый этап"
            //    });
            //}
            db.SaveChanges();
            return RedirectToAction(GetUrl("ShowMarks", groupId, Convert.ToInt32(subjectId)));
        }

        public ActionResult RemoveCPLine(string groupId, int? subjectId)
        {
            int MaxLineIndex = 0, MaxCPLineMaxPointID = 0; 
            if (db.CourseProjectLines.Count() > 0)
            {
                MaxLineIndex = db.CourseProjectLines
                                 .Where(m => m.SubjectCP.SubjectCP_ID == subjectId && m.Student.GroupID == groupId)
                                 .Max(m => m.LineIndex);
            }
            if (db.CPLineMaxPoints.Count() > 0)
            {
                MaxCPLineMaxPointID = db.CPLineMaxPoints.Max(m => m.LineIndex);
                db.CPLineMaxPoints.RemoveRange(db.CPLineMaxPoints.Where(m => m.CPLineMaxPointID == MaxCPLineMaxPointID && m.SubjectCPID == subjectId));
            }
            if (db.CourseProjectLines.Count() > 0)
            {
                db.CourseProjectLines.RemoveRange(db.CourseProjectLines.Where(m => m.LineIndex == MaxLineIndex && m.SubjectCP_ID == subjectId));
            }
              
            db.SaveChanges();
            return RedirectToAction(GetUrl("ShowMarks", groupId, Convert.ToInt32(subjectId)));
        }
        [HttpPost]
        public ActionResult SaveLineName(string value, string index, string url)
        {
            int indexOfLastSlash = url.LastIndexOf('/');
            int subjectId = Convert.ToInt32(url.Substring(indexOfLastSlash + 1));
            List<CPLineMaxPoint> cpLineMaxPoints = db.CPLineMaxPoints.Where(cpl => cpl.SubjectCPID == subjectId).ToList();
            foreach (CPLineMaxPoint cpLineMaxPoint in cpLineMaxPoints)
            {
                if (cpLineMaxPoint.LineIndex == Convert.ToInt32(index))
                    cpLineMaxPoint.LineName = value;
            }
            List<CourseProjectLine> cpLines = db.CourseProjectLines.Where(cpl => cpl.SubjectCP_ID == subjectId).ToList();
            foreach (CourseProjectLine cpLine in cpLines)
            {
                if (cpLine.LineIndex == Convert.ToInt32(index))
                    cpLine.LineName = value;
            }
            int indexOfSubject = url.IndexOf("SubjectCPs");
            url = url.Substring(indexOfSubject);

            db.SaveChanges();
            return RedirectToAction(url);
        }
        [HttpPost]
        public ActionResult SaveChanges(List<TemplateToMarks> dataToSend)
        {
            GetIDs(ref dataToSend);
            for (int i = 0; i < dataToSend.Count - 1; i++)
            {
                switch (dataToSend[i].markType)
                {
                    case "lab":
                        CourseProjectLine mark = db.CourseProjectLines.Find(Convert.ToInt32(dataToSend[i].inputId));
                        mark.TheMark = Convert.ToInt32(dataToSend[i].inputvalue);
                        mark.DateOfPassing = Convert.ToDateTime(dataToSend[i].dateOfReport);
                        break;
                    case "maxlab":
                        CPLineMaxPoint labMaxPoint = db.CPLineMaxPoints.Find(Convert.ToInt32(dataToSend[i].inputId));
                        labMaxPoint.MaxPoint = Convert.ToInt32(dataToSend[i].inputvalue);
                        break;
                    default:
                        break;
                }
                db.SaveChanges();
            }
            string url = dataToSend[dataToSend.Count - 1].inputId.Substring(dataToSend[dataToSend.Count - 1].inputId.IndexOf("ShowMarks"));
            return RedirectToAction(url);
        }
        public void GetIDs(ref List<TemplateToMarks> data)
        {
            for (int i = 0; i < data.Count - 1; i++)
            {
                int ceparatorIndex = data[i].inputId.IndexOf('_');
                data[i].inputId = data[i].inputId.Substring(0, ceparatorIndex);
            }
        }
        protected string GetUrl(string action, string groupId, int? subjectId)
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
    }
}
