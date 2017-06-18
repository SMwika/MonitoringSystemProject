using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MonitoringSystem.Models;
using System.Net;

namespace MonitoringSystem.Controllers
{
    public class HomeController : Controller
    {
        private TotalJournalContext db = new TotalJournalContext();

        public ActionResult Index()
        {
            return View(db.Groups.ToList());
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        [HttpGet]
        public ActionResult SearchStudent()
        {
            return View();
        }

        [HttpPost]
        public ActionResult SearchStudent(string RecordBookNumberID)
        {
            if (RecordBookNumberID == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            Student student = db.Students.Find(RecordBookNumberID);

           // ModelList modelList = new ModelList();
           // modelList.students = db.Students.Where(s => s.Group.GroupID == groupId).ToList();
           // modelList.GroupName = student.GroupID;
           // //modelList.SubjectName = db.Subjects.Find(subjectId).SubjectName;
           // //modelList.SubjectId = (int)subjectId;
           // //modelList.students = db.Students.Where(s => s.Group.GroupID == groupId).ToList();
           // modelList.marks = db.Marks.Where(m => m.RecordBookNumberID == RecordBookNumberID).ToList();
           // modelList.homeworks = db.HomeWorks.Where(hw => hw.RecordBookNumberID == RecordBookNumberID).ToList();
           // modelList.modules = db.Modules.Where(m => m.RecordBookNumberID == RecordBookNumberID).ToList();
           // //modelList.labMaxPoints = db.LabMaxPoints.Where(point => point.Subject.SubjectID == subjectId).ToList();
           // //modelList.hwMaxPoints = db.HWMaxPoints.Where(point => point.Subject.SubjectID == subjectId).ToList();
           // //modelList.moduleMaxPoints = db.ModuleMaxPoints.Where(point => point.Subject.SubjectID == subjectId).ToList();
           // modelList.freeMarkFields = db.FreeMarkFields.Where(point => point.Subject.SubjectID == subjectId && point.Student.GroupID == groupId).ToList();
           // //modelList.freeMarkFieldMaxPoints = db.FreeMarkFieldMaxPoints.Where(point => point.Subject.SubjectID == subjectId).ToList();

           // List<Attendance> atts = db.Attendances
           //     .Where(at => at.RecordBookNumberID == RecordBookNumberID).ToList();
           // //List<OneItemPoint> oip = db.OneItemPoints.Where(oi => oi.SubjectId == subjectId).ToList();
           // double[] attendances = new double[modelList.students.Count];
           // //for (int i = 0; i < modelList.students.Count; i++)
           // //{
           // //    List<Attendance> studAtt = atts.Where(a => a.RecordBookNumberID == modelList.students[i].RecordBookNumberID).ToList();
           // //    if (studAtt != null)
           // //    {
           // //        for (int j = 0; j < studAtt.Count; j++)
           // //        {
           // //            if (studAtt[j].IsVisited == true)
           // //            {
           // //                oip[0].Value = oip[0].Value.Replace('.', ',');
           // //                attendances[i] += Convert.ToDouble(oip[0].Value);
           // //            }
           // //        }
           // //    }
           // //    else
           // //    {
           // //        attendances[i] = 0;
           // //    }
           // //}
           //// modelList.oneItemPoint = atts.Count() > 0 ? Convert.ToDouble(oip[0].Value.Replace('.', ',')) * atts.Max(at => at.Index) : 0;
           // modelList.attendanceAmount = attendances;
            return View("SearchStudentResults",student);
        }
    }

    public class GroupModel
    {
        public List<Group> groups { get; set; }
    }
}