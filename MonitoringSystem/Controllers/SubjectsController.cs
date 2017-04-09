using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using MonitoringSystem.Models;
using System.Web.Script.Serialization;
using Newtonsoft.Json;

namespace MonitoringSystem.Controllers
{
    public class SubjectsController : Controller
    {
        private TotalJournalContext db = new TotalJournalContext();        
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
        // Чтобы защититься от атак чрезмерной передачи данных, включите определенные свойства, для которых следует установить привязку. Дополнительные 
        // сведения см. в статье http://go.microsoft.com/fwlink/?LinkId=317598.
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
        // Чтобы защититься от атак чрезмерной передачи данных, включите определенные свойства, для которых следует установить привязку. Дополнительные 
        // сведения см. в статье http://go.microsoft.com/fwlink/?LinkId=317598.
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

        //дописать обработчики на 5 и 6 курс
        public ActionResult ShowSubjectsByCourseNumber(string groupId)
        {
            List<Subject> subjectsForCourse = new List<Subject>();
            List<Subject> names;
            IEnumerable<Subject> getSubjects;
            int courseNumber = Cn(groupId);
            //if (courseNumber != -1)
            //{

            //}
            switch (courseNumber)
            {
                case 1:
                    getSubjects = db.Subjects.Where(subjects => (subjects.Term == 1 || subjects.Term == 2) );
                    break;
                case 2:
                    getSubjects = db.Subjects.Where(subjects => (subjects.Term == 3 || subjects.Term == 4) );
                    break;
                case 3:
                    getSubjects = db.Subjects.Where(subjects => (subjects.Term == 5 || subjects.Term == 6) );
                    break;
                case 4:
                    getSubjects = db.Subjects.Where(subjects => (subjects.Term == 7 || subjects.Term == 8));
                    break;
                case 5:
                    getSubjects = db.Subjects.Where(subjects => (subjects.Term == 9 || subjects.Term == 10));
                    break;
                case 6:
                    getSubjects = db.Subjects.Where(subjects => subjects.Term == 11);
                    break;
                default: return new HttpNotFoundResult();                
            }
            names = subjectsForCourse.Select(s => new Subject { SubjectName = s.SubjectName }).ToList();

            subjectsForCourse = getSubjects.ToList();

            ViewBag.GroupNumber = groupId;
            ViewBag.Names = names;

            return View(subjectsForCourse);
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

        public ActionResult ShowMarks(string groupId, int? subjectId)
        {
            if (groupId == null || subjectId == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ModelList modelList = new ModelList();
            List<Student> students = new List<Student>();
            List<Mark> marks = new List<Mark>();
            List<HomeWork> HWs = new List<HomeWork>();
            List<Module> modules = new List<Module>();
            List<Attendance> atts = new List<Attendance>();
            List<LabMaxPoint> lmp = new List<LabMaxPoint>();
            List<HWMaxPoint> hwmp = new List<HWMaxPoint>();
            List<ModuleMaxPoint> mmp = new List<ModuleMaxPoint>();
            List<AttMaxPoint> atmp = new List<AttMaxPoint>();

            //выборка студентов
            students = db.Students.Where(s => s.GroupID == groupId).ToList();

            ///выборка оценок
            marks = db.Marks.Where(m => m.Subject.SubjectID == subjectId && m.Student.GroupID == groupId).ToList();

            //выборка оценок по дз
            HWs = db.HomeWorks
                .Where(hw => hw.Subject.SubjectID == subjectId && hw.Student.GroupID == groupId).ToList();

            //выборка оценок за модули
            modules = db.Modules
                .Where(m => m.Subject.SubjectID == subjectId && m.Student.GroupID == groupId).ToList();

            //выбрать посещаемость
            atts = db.Attendances
                .Where(at => at.Subject.SubjectID == subjectId && at.Student.GroupID == groupId).ToList();

            lmp = db.LabMaxPoints.Where(point => point.Subject.SubjectID == subjectId).ToList();
            hwmp = db.HWMaxPoints.Where(point => point.Subject.SubjectID == subjectId).ToList();
            mmp = db.ModuleMaxPoints.Where(point => point.Subject.SubjectID == subjectId).ToList();
            atmp = db.AttMaxPoints.Where(point => point.Subject.SubjectID == subjectId).ToList();
            

            int[] attendances = new int[students.Count];
            for (int i = 0; i < students.Count; i++)
            {
                List<Attendance> studAtt = atts.Where(a => a.RecordBookNumberID == students[i].RecordBookNumberID).ToList();
                if (studAtt != null)
                {
                    for (int j = 0; j < studAtt.Count; j++)
                    {
                        attendances[i] += Convert.ToInt32(studAtt[j].IsVisited);
                    }
                }
                else
                {
                    attendances[i] = 0;
                }
                
            }

            modelList.GroupName = groupId;
            modelList.SubjectName = db.Subjects.Find(subjectId).SubjectName;
            modelList.SubjectId = (int)subjectId;
            modelList.studentsToShow = students;
            modelList.marksToShow = marks;
            modelList.hwToShow = HWs;
            modelList.modulesToShow = modules;
            modelList.attendanceAmount = attendances;
            modelList.lmps = lmp;
            modelList.hwmps = hwmp;
            modelList.mmps = mmp;
            modelList.atmps = atmp;
            return View(modelList);
        }       
        
        [HttpPost]
        public ActionResult SaveChanges(List<TemplateToMarks> dataToSend)
        {
            getIDs(ref dataToSend);
            for (int i = 0; i < dataToSend.Count-1; i++)
            {
                switch (dataToSend[i].markType)
                {
                    case "lab":
                        Mark mark = db.Marks.Find(Convert.ToInt32(dataToSend[i].inputId));                        
                        mark.TheMark = Convert.ToInt16(dataToSend[i].inputvalue);
                        mark.DateOfProgram = Convert.ToDateTime(dataToSend[i].dateOfProgram);
                        mark.DateOfReport = Convert.ToDateTime(dataToSend[i].dateOfReport);
                        break;
                    case "hw":
                        HomeWork homework = db.HomeWorks.Find(Convert.ToInt32(dataToSend[i].inputId));
                        homework.HWPoint = Convert.ToInt16(dataToSend[i].inputvalue);
                        homework.DateOfProgram = Convert.ToDateTime(dataToSend[i].dateOfProgram);
                        homework.DateOfReport = Convert.ToDateTime(dataToSend[i].dateOfReport);
                        break;                    
                    case "module":
                        Module module = db.Modules.Find(Convert.ToInt16(dataToSend[i].inputId));
                        module.ModulePoint = Convert.ToInt16(dataToSend[i].inputvalue);
                        break;
                    case "maxlab": LabMaxPoint lmp = db.LabMaxPoints.Find(Convert.ToInt32(dataToSend[i].inputId));
                        lmp.MaxPoint = Convert.ToInt16(dataToSend[i].inputvalue);
                        break;
                    case "maxhw":
                        HWMaxPoint hwmp = db.HWMaxPoints.Find(Convert.ToInt32(dataToSend[i].inputId));
                        hwmp.MaxPoint = Convert.ToInt16(dataToSend[i].inputvalue);
                        break;
                    case "maxmodule":
                        ModuleMaxPoint mmp = db.ModuleMaxPoints.Find(Convert.ToInt32(dataToSend[i].inputId));
                        mmp.MaxPoint = Convert.ToInt16(dataToSend[i].inputvalue);
                        break;
                    default:
                        break;
                }
                db.SaveChanges();
            }
            string url = dataToSend[dataToSend.Count - 1].inputId.Substring(dataToSend[dataToSend.Count - 1].inputId.IndexOf("ShowMarks"));

            if (url.LastIndexOf('#') != -1)
            {
                url = url.Substring(0, url.Length - 1);
            }
            return RedirectToAction(url);
        }

        public string isProgramOrReport(string value, string substr)
        {
            string pointer = string.Empty;
            if (value.IndexOf(substr) != -1)
            {
                pointer = value.Substring(value.IndexOf(substr));
            }
            return pointer;
        }

        public void getIDs(ref List<TemplateToMarks> data)
        {
            for (int i = 0; i < data.Count-1; i++)
            {
                int ceparatorIndex = data[i].inputId.IndexOf('_');
                data[i].inputId = data[i].inputId.Substring(0, ceparatorIndex);
            }
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

    public class TemplateInfoJson
    {
        [JsonProperty("inputObject")]
        public TemplateToMarks templateToMarks { get; set; }
    }

    public class TemplateToMarks
    {
        [JsonProperty("rbn")]
        public string rbn { get; set; }
        [JsonProperty("inputId")]
        public string inputId { get; set; }
        [JsonProperty("markType")]
        public string markType { get; set; }
        [JsonProperty("inputvalue")]
        public string inputvalue { get; set; }
        [JsonProperty("dateOfReport")]
        public DateTime dateOfReport { get; set; }
        [JsonProperty("dateOfProgram")]
        public DateTime dateOfProgram { get; set; }
   }

    public class ModelList
    {
        public List<Student> studentsToShow { get; set;}

        public List<Mark> marksToShow { get; set;}
        public List<Module> modulesToShow { get; set; }
        public List<HomeWork> hwToShow { get; set; }
        public List<LabMaxPoint> lmps { get; set; }
        public List<HWMaxPoint> hwmps { get; set; }
        public List<ModuleMaxPoint> mmps { get; set; }
        public List<AttMaxPoint> atmps { get; set; }
        public string GroupName { get; set; }
        public string SubjectName { get; set; }
        public int SubjectId { get; set; }
        public int[] attendanceAmount { get; set; }
    }    
}


//case "labdateprogram":
//    Mark markdateprogram = db.Marks.Find(Convert.ToInt32(dataToSend[i].inputId));
//    markdateprogram.DateOfProgram = Convert.ToDateTime(dataToSend[i].inputvalue);
//    break;
//case "labdatereport":
//    Mark markdatereport = db.Marks.Find(Convert.ToInt32(dataToSend[i].inputId));
//    markdatereport.DateOfReport = Convert.ToDateTime(dataToSend[i].inputvalue);
//    break;
//case "hwdateprogram":
//    HomeWork homeworkdateprogram = db.HomeWorks.Find(Convert.ToInt32(dataToSend[i].inputId));
//    homeworkdateprogram.DateOfProgram = Convert.ToDateTime(dataToSend[i].inputvalue);
//    break;
//case "hwdatereport":
//    HomeWork homeworkdatereport = db.HomeWorks.Find(Convert.ToInt32(dataToSend[i].inputId));
//    homeworkdatereport.DateOfReport = Convert.ToDateTime(dataToSend[i].inputvalue);
//    break;