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
            modelList.students = db.Students.Where(s => s.GroupID == groupId).ToList();
            modelList.GroupName = groupId;
            modelList.SubjectName = db.Subjects.Find(subjectId).SubjectName;
            modelList.SubjectId = (int)subjectId;
            modelList.students = db.Students.Where(s => s.GroupID == groupId).ToList();
            modelList.marks = db.Marks.Where(m => m.Subject.SubjectID == subjectId && m.Student.GroupID == groupId).ToList();
            modelList.homeworks = db.HomeWorks.Where(hw => hw.Subject.SubjectID == subjectId && hw.Student.GroupID == groupId).ToList();
            modelList.modules = db.Modules.Where(m => m.Subject.SubjectID == subjectId && m.Student.GroupID == groupId).ToList();
            modelList.labMaxPoints = db.LabMaxPoints.Where(point => point.Subject.SubjectID == subjectId).ToList();
            modelList.hwMaxPoints = db.HWMaxPoints.Where(point => point.Subject.SubjectID == subjectId).ToList();
            modelList.moduleMaxPoints = db.ModuleMaxPoints.Where(point => point.Subject.SubjectID == subjectId).ToList();
            modelList.freeMarkFields = db.FreeMarkFields.Where(point => point.Subject.SubjectID == subjectId && point.Student.GroupID == groupId).ToList();
            modelList.freeMarkFieldMaxPoints = db.FreeMarkFieldMaxPoints.Where(point => point.Subject.SubjectID == subjectId).ToList();

            List<Attendance> atts = db.Attendances
                .Where(at => at.Subject.SubjectID == subjectId && at.Student.GroupID == groupId).ToList();
            List<OneItemPoint> oip = db.OneItemPoints.Where(oi => oi.SubjectId == subjectId).ToList();


            double[] attendances = new double[modelList.students.Count];
            for (int i = 0; i < modelList.students.Count; i++)
            {
                List<Attendance> studAtt = atts.Where(a => a.RecordBookNumberID == modelList.students[i].RecordBookNumberID).ToList();
                if (studAtt != null)
                {
                    for (int j = 0; j < studAtt.Count; j++)
                    {
                        if (studAtt[j].IsVisited == true)
                        {
                            oip[0].Value = oip[0].Value.Replace('.', ',');
                            attendances[i] += Convert.ToDouble(oip[0].Value);
                        }
                    }
                }
                else
                {
                    attendances[i] = 0;
                }                
            }
            //if (oip.Count() > 0)
            //{
            //    if (atts.Count() > 0)
            //    {
            //        modelList.oneItemPoint = Convert.ToDouble(oip[0].Value.Replace('.', ','))*atts.Max(at => at.Index);
            //    }
            //    else // atts.Count > 0
            //    {
            //        modelList.oneItemPoint = Convert.ToDouble(oip[0].Value.Replace('.', ','))*;
            //    }
            //}
            //else
            //{
            //    modelList.oneItemPoint = 0;
            //}
            modelList.oneItemPoint = atts.Count() > 0 ? Convert.ToDouble(oip[0].Value.Replace('.', ','))*atts.Max(at => at.Index) : 0;
            modelList.attendanceAmount = attendances;
            return View(modelList);
        }            
        public ActionResult AddMarkColumn(string groupId, int? subjectId)
        {
            //получаем максимальный номер лабы по предмету
            //получаем максимальный ИД в таблице
            // в цикле по студентам каждому студенту присваиваем ноль по лабе с данным номером
            // db.Students.Where(s => s.Subject.)
            Subject subject = db.Subjects.Find(subjectId);
            List<Student> studentsInGroup = subject.Students.ToList();
            int MaxLabNumber = 0, 
                MaxLabID = 0,
                MaxLabMaxPointID = 0;

            if (db.LabMaxPoints.Where(m => m.Subject.SubjectID == subjectId).Count() !=0)
            {
                //максимальный номер лабы по предмету
                MaxLabNumber = db.LabMaxPoints
                .Where(m => m.Subject.SubjectID == subjectId).Max(m => m.LabNumber);
            }
            if (db.Marks.Count() != 0)
            {
                MaxLabID = db.Marks.Max(m => m.MarkID);
            }                       
            if (db.LabMaxPoints.Count() != 0)
            {
                MaxLabMaxPointID = db.LabMaxPoints.Max(m => m.LabMaxPointID);
            }
            db.LabMaxPoints.Add(new LabMaxPoint() { LabMaxPointID = MaxLabMaxPointID + 1, LabNumber = MaxLabNumber + 1, MaxPoint = 0, SubjectID = (int)subjectId });

            foreach (var student in studentsInGroup)
            {
                MaxLabID++;
                subject.Marks.Add(new Mark()
                {
                    MarkID = MaxLabID,
                    LabNumber = (MaxLabNumber + 1),
                    RecordBookNumberID = student.RecordBookNumberID,
                    DateOfProgram = DateTime.Now,
                    DateOfReport = DateTime.Now,
                    SubjectID = Convert.ToInt32(subjectId),
                    TheMark = 0
                });                
            }

            db.SaveChanges();
            return RedirectToAction(getUrl("ShowMarks", groupId, subjectId));
        }
        public ActionResult AddHomeWorkColumn(string groupId, int? subjectId)
        {
            Subject subject = db.Subjects.Find(subjectId);
            List<Student> studentsInGroup = subject.Students.ToList();
            int MaxHWNumber = 0,
                MaxHWID = 0,
                MaxModuleMaxPointID = 0;

            if (db.HWMaxPoints.Where(m => m.Subject.SubjectID == subjectId).Count() != 0)
            {
                MaxHWNumber = db.HWMaxPoints
               .Where(m => m.Subject.SubjectID == subjectId).Max(m => m.HWNumber);
            }
            if (db.HomeWorks.Count() != 0)
            {
                MaxHWID = db.HomeWorks.Max(m => m.HomeWorkID);

            }
            if (db.HWMaxPoints.Count() != 0)
            {
                MaxModuleMaxPointID = db.HWMaxPoints.Max(m => m.HWMaxPointID);
            }
            
            db.HWMaxPoints.Add(new HWMaxPoint() { HWMaxPointID = MaxModuleMaxPointID + 1, HWNumber = MaxHWNumber + 1, MaxPoint = 0, SubjectID = (int)subjectId });
            foreach (var student in studentsInGroup)
            {
                MaxHWID++;
                subject.HomeWorks.Add(new HomeWork()
                {
                    HomeWorkID = MaxHWID,
                    HWNumber = (MaxHWNumber + 1),
                    RecordBookNumberID = student.RecordBookNumberID,
                    DateOfProgram = DateTime.Now,
                    DateOfReport = DateTime.Now,
                    SubjectID = Convert.ToInt32(subjectId),                    
                    HWPoint = 0,
                });
            }

            db.SaveChanges();
            return RedirectToAction(getUrl("ShowMarks", groupId, subjectId));
        }
        public ActionResult AddModuleColumn(string groupId, int? subjectId)
        {
            Subject subject = db.Subjects.Find(subjectId);
            List<Student> studentsInGroup = subject.Students.ToList();
            int MaxModuleNumber = 0,
                MaxModuleID = 0,
                MaxModuleMaxPointID = 0;

            if  (db.ModuleMaxPoints.Where(m => m.Subject.SubjectID == subjectId).Count() != 0)
            {
                MaxModuleNumber = db.ModuleMaxPoints
                .Where(m => m.Subject.SubjectID == subjectId).Max(m => m.ModuleNumber);
            }
            
            if (db.Modules.Count() !=0)
            {
                MaxModuleID = db.Modules.Max(m => m.ModuleID);
            }
            if (db.ModuleMaxPoints.Count() != 0)
            {
                MaxModuleMaxPointID = db.ModuleMaxPoints.Max(m => m.ModuleMaxPointID);
            }
            db.ModuleMaxPoints.Add(new ModuleMaxPoint() { ModuleMaxPointID = MaxModuleMaxPointID + 1, ModuleNumber = MaxModuleNumber + 1, MaxPoint = 0, SubjectID = (int)subjectId });
            foreach (var student in studentsInGroup)
            {
                MaxModuleID++;
                subject.Modules.Add(new Module()
                {
                    ModuleID = MaxModuleID,
                    ModuleNumber = (MaxModuleNumber + 1),
                    RecordBookNumberID = student.RecordBookNumberID,
                    SubjectID = Convert.ToInt32(subjectId),
                    ModulePoint = 0
                });
            }

            db.SaveChanges();
            return RedirectToAction(getUrl("ShowMarks", groupId, subjectId));
        }
        public ActionResult AddFreeFieldColumn(string groupId, int? subjectId)
        {
            Subject subject = db.Subjects.Find(subjectId);
            List<Student> studentsInGroup = subject.Students.ToList();
            int MaxFreeMarkFieldNumber = 0,
                MaxFreeMaxMarkID = 0,
                MaxFreeMaxMarkMaxPointID = 0;

            if (db.FreeMarkFieldMaxPoints.Where(m => m.Subject.SubjectID == subjectId).Count() != 0)
            {
                MaxFreeMarkFieldNumber = db.FreeMarkFieldMaxPoints
                .Where(m => m.Subject.SubjectID == subjectId)
                .Max(m => m.FieldNumber);
            }
            if (db.FreeMarkFields.Count() != 0)
            {
                MaxFreeMaxMarkID = db.FreeMarkFields.Max(m => m.FreeMarkFieldID);
            }
            if (db.FreeMarkFieldMaxPoints.Count() !=0)
            {
                MaxFreeMaxMarkMaxPointID = db.FreeMarkFieldMaxPoints.Max(m => m.FreeMarkFieldMaxPointID);
            }
            db.FreeMarkFieldMaxPoints.Add(new FreeMarkFieldMaxPoint() { FreeMarkFieldMaxPointID = MaxFreeMaxMarkMaxPointID + 1, FieldNumber = MaxFreeMarkFieldNumber + 1, MaxPoint = 0, FieldName = "Новый столбец" , SubjectID = (int)subjectId });
            foreach (var student in studentsInGroup)
            {
                MaxFreeMaxMarkID++;
                subject.FreeMarkFields.Add(new FreeMarkField()
                {
                    FreeMarkFieldID = MaxFreeMaxMarkID,
                    FieldNumber = (MaxFreeMarkFieldNumber + 1),
                    RecordBookNumberID = student.RecordBookNumberID,
                    SubjectID = Convert.ToInt32(subjectId),
                    FieldPoint = 0,
                    FieldName = "Новый столбец"
                });
            }

            db.SaveChanges();
            return RedirectToAction(getUrl("ShowMarks", groupId, subjectId));
        }
        public ActionResult RemoveMarkColumn(string groupId, int? subjectId)
        {
            // взять все оценки в группе  по предмету и удалить те, где 
            // номер лабы = максимальный номер лабы
            int MaxLabNumber = 0, MaxLabMaxPointID = 0;
            if (db.LabMaxPoints.Where(m => m.Subject.SubjectID == subjectId).Count() != 0)
            {
                MaxLabNumber = db.LabMaxPoints
                                 .Where(m => m.Subject.SubjectID == subjectId).Max(m => m.LabNumber);
            }
            if (db.LabMaxPoints.Count() != 0)
            {
                MaxLabMaxPointID = db.LabMaxPoints.Max(m => m.LabMaxPointID);
                db.LabMaxPoints.RemoveRange(db.LabMaxPoints.Where(m => m.LabMaxPointID == MaxLabMaxPointID));
            }

            if(db.Marks.Where(m => m.LabNumber == MaxLabNumber).Count() != 0)
            {
                db.Marks.RemoveRange(db.Marks.Where(m => m.LabNumber == MaxLabNumber));
            }

            db.SaveChanges();
            return RedirectToAction(getUrl("ShowMarks", groupId, subjectId));
        }
        public ActionResult RemoveHomeWorkColumn(string groupId, int? subjectId)
        {
            // взять все оценки в группе  по предмету и удалить те, где 
            // номер лабы = максимальный номер лабы
            int MaxHWNumber = 0, MaxHWMaxPointID = 0; 
            if (db.HWMaxPoints.Where(m => m.Subject.SubjectID == subjectId).Count() != 0)
            {
                MaxHWNumber = db.HWMaxPoints
                                 .Where(m => m.Subject.SubjectID == subjectId)
                                 .Max(m => m.HWNumber);
            }
            if (db.HWMaxPoints.Count() != 0)
            {
                MaxHWMaxPointID = db.HWMaxPoints.Max(m => m.HWMaxPointID);
                db.HWMaxPoints.RemoveRange(db.HWMaxPoints.Where(m => m.HWMaxPointID == MaxHWMaxPointID));
            }
            if (db.HomeWorks.Where(m => m.HWNumber == MaxHWNumber).Count() != 0)
            {
                db.HomeWorks.RemoveRange(db.HomeWorks.Where(m => m.HWNumber == MaxHWNumber));
            }

            db.SaveChanges();
            return RedirectToAction(getUrl("ShowMarks", groupId, subjectId));
        }
        public ActionResult RemoveModuleColumn(string groupId, int? subjectId)
        {
            // взять все оценки по предмету и удалить те, где 
            // номер лабы = максимальный номер лабы
            int MaxModuleNumber = 0, MaxModuleMaxPointID = 0;
            if (db.ModuleMaxPoints.Where(m => m.Subject.SubjectID == subjectId).Count() != 0)
            {
                MaxModuleNumber = db.ModuleMaxPoints
                                 .Where(m => m.Subject.SubjectID == subjectId).Max(m => m.ModuleNumber);
            }
            if (db.ModuleMaxPoints.Count() != 0)
            {
                MaxModuleMaxPointID = db.ModuleMaxPoints.Max(m => m.ModuleMaxPointID);
                db.ModuleMaxPoints.RemoveRange(db.ModuleMaxPoints.Where(m => m.ModuleMaxPointID == MaxModuleMaxPointID));
            }
            if (db.Modules.Where(m => m.ModuleNumber == MaxModuleNumber).Count() !=0)
            {
                db.Modules.RemoveRange(db.Modules.Where(m => m.ModuleNumber == MaxModuleNumber));
            }

            db.SaveChanges();
            return RedirectToAction(getUrl("ShowMarks", groupId, subjectId));
        }
        public ActionResult RemoveFreeFieldColumn(string groupId, int? subjectId)
        {
            // взять все оценки в предмету и удалить те, где 
            // номер лабы = максимальный номер лабы
            int MaxFreeFieldNumber = 0, MaxFreeFieldMaxPointID = 0;
            if (db.FreeMarkFieldMaxPoints.Where(m => m.Subject.SubjectID == subjectId).Count() != 0)
            {
                MaxFreeFieldNumber = db.FreeMarkFieldMaxPoints
                                 .Where(m => m.Subject.SubjectID == subjectId).Max(m => m.FieldNumber);
            }
            if (db.FreeMarkFieldMaxPoints.Count() !=0)
            {
                MaxFreeFieldMaxPointID = db.FreeMarkFieldMaxPoints.Max(m => m.FreeMarkFieldMaxPointID);
                db.FreeMarkFieldMaxPoints.RemoveRange(db.FreeMarkFieldMaxPoints.Where(m => m.FreeMarkFieldMaxPointID == MaxFreeFieldMaxPointID));
            }
            if (db.FreeMarkFields.Where(m => m.FieldNumber == MaxFreeFieldNumber).Count() !=0)
            {
                db.FreeMarkFields.RemoveRange(db.FreeMarkFields.Where(m => m.FieldNumber == MaxFreeFieldNumber));
            }

            db.SaveChanges();
            return RedirectToAction(getUrl("ShowMarks",groupId, subjectId));
        }
        protected string getUrl(string action, string groupId, int? subjectId)
        {
            string url = string.Empty;
            url = action + "/" + groupId + "/" + subjectId.ToString();
            return url;
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
                        mark.TheMark = Convert.ToInt32(dataToSend[i].inputvalue);
                        mark.DateOfProgram = Convert.ToDateTime(dataToSend[i].dateOfProgram);
                        mark.DateOfReport = Convert.ToDateTime(dataToSend[i].dateOfReport);
                        break;
                    case "hw":
                        HomeWork homework = db.HomeWorks.Find(Convert.ToInt32(dataToSend[i].inputId));
                        homework.HWPoint = Convert.ToInt32(dataToSend[i].inputvalue);
                        homework.DateOfProgram = Convert.ToDateTime(dataToSend[i].dateOfProgram);
                        homework.DateOfReport = Convert.ToDateTime(dataToSend[i].dateOfReport);
                        break;                    
                    case "module":
                        Module module = db.Modules.Find(Convert.ToInt32(dataToSend[i].inputId));
                        module.ModulePoint = Convert.ToInt32(dataToSend[i].inputvalue);
                        break;
                    case "freemarkfield":
                        FreeMarkField freeMarkField = db.FreeMarkFields.Find(Convert.ToInt32(dataToSend[i].inputId));
                        freeMarkField.FieldPoint = Convert.ToInt32(dataToSend[i].inputvalue);
                        break;
                    case "maxlab": LabMaxPoint labMaxPoint = db.LabMaxPoints.Find(Convert.ToInt32(dataToSend[i].inputId));
                        labMaxPoint.MaxPoint = Convert.ToInt32(dataToSend[i].inputvalue);
                        break;
                    case "maxhw":
                        HWMaxPoint hwMaxPoint = db.HWMaxPoints.Find(Convert.ToInt32(dataToSend[i].inputId));
                        hwMaxPoint.MaxPoint = Convert.ToInt32(dataToSend[i].inputvalue);
                        break;
                    case "maxmodule":
                        ModuleMaxPoint moduleMaxPoint = db.ModuleMaxPoints.Find(Convert.ToInt32(dataToSend[i].inputId));
                        moduleMaxPoint.MaxPoint = Convert.ToInt32(dataToSend[i].inputvalue);
                        break;
                    case "maxfreefieldpoint":
                        FreeMarkFieldMaxPoint freeFieldMaxPoint = db.FreeMarkFieldMaxPoints.Find(Convert.ToInt32(dataToSend[i].inputId));
                        freeFieldMaxPoint.MaxPoint = Convert.ToInt32(dataToSend[i].inputvalue);
                        break;
                    default:
                        break;
                }
                db.SaveChanges();
            }
            string url = dataToSend[dataToSend.Count - 1].inputId.Substring(dataToSend[dataToSend.Count - 1].inputId.IndexOf("ShowMarks"));
            return RedirectToAction(url);
        }
        [HttpPost]
        public ActionResult SaveOneItemPoint(string value, string url)
        {
            int indexOfLastSlash = url.LastIndexOf('/');
            int subjectId = Convert.ToInt32(url.Substring(indexOfLastSlash + 1));
            int maxOneItemPointId = 0;

            List<OneItemPoint> oneItemPoints = db.OneItemPoints.Where(atts => atts.Subject.SubjectID == subjectId).ToList();

            if (oneItemPoints.Count == 0)
            {
                if (db.OneItemPoints.Count() > 0)
                {
                    maxOneItemPointId = db.OneItemPoints.Max(o => o.OneItemPointID);
                    OneItemPoint oip = new OneItemPoint() { OneItemPointID = maxOneItemPointId + 1, SubjectId = subjectId, Value = value };
                    db.OneItemPoints.Add(oip);
                }
                else // db.OneItemPoint.Count == 0  (the sequence is empty)
                {
                    db.OneItemPoints.Add(new OneItemPoint() { OneItemPointID = 1, SubjectId = subjectId, Value = value });
                }
            }
            else
            {
                foreach (OneItemPoint oneItemPoint in oneItemPoints)
                {
                    oneItemPoint.Value = value;
                    db.SaveChanges();
                }
            }
            
            int indexOfSubject = url.IndexOf("Subjects");
            url = url.Substring(indexOfSubject);

            db.SaveChanges();
            return RedirectToAction(url);
        }
        public void getIDs(ref List<TemplateToMarks> data)
        {
            for (int i = 0; i < data.Count-1; i++)
            {
                int ceparatorIndex = data[i].inputId.IndexOf('_');
                data[i].inputId = data[i].inputId.Substring(0, ceparatorIndex);
            }
        }
        public ActionResult EditAttendance(string groupId, int? subjectId)
        {
            ModelListAttendances model = new ModelListAttendances();

            List<Student> students = new List<Student>();
            List<AttendanceDate> attendanceDates = new List<AttendanceDate>();

            students = db.Students.Where(s => s.GroupID == groupId).ToList();
            attendanceDates = db.AttendanceDates.Where(attD => attD.SubjectId == subjectId).ToList();

            model.students = students;
            model.groupId = groupId;
            model.subjectId = (int)subjectId;
            model.subjectName = db.Subjects.Find(subjectId).SubjectName;
            model.attendances = db.Attendances.Where(att => att.Subject.SubjectID == subjectId && att.Student.GroupID == groupId).ToList();
            model.attendanceDates = attendanceDates;
            model.oneItemPoint = db.OneItemPoints.Where(pt => pt.SubjectId == subjectId).ToList().Count > 0 
                ? db.OneItemPoints.Where(pt => pt.SubjectId == subjectId).ToList() : new List<OneItemPoint>() {  };
            return View(model);            
        } 
        //[HttpPost]
        public ActionResult AddAttendanceDate(string groupId, string subjectId)
        {
            int courseNumber = Cn(groupId);
            int subId = Convert.ToInt32(subjectId);
            // кааждому студенту, у которого есть данный предмет выставить по нем посещение
            Subject subject = db.Subjects.Find(subId);
            List<Student> studentsInGroup = subject.Students.ToList();
            if (studentsInGroup.Count() > 0)
            {
                return View("Error");
            }

            int maxAttendanceDateId = 0;
            int maxAttendanceId = 0;
            int indexAttendanceDate = 0, indexAttendance = 0;
            if (db.AttendanceDates.Count() > 0)
            {
                maxAttendanceDateId = db.AttendanceDates.Max(at => at.AttendanceDateId);
                indexAttendanceDate = db.AttendanceDates.Max(at => at.Index);
            }
            if (db.Attendances.Count() > 0 )
            {
                maxAttendanceId = db.Attendances.Max(at => at.AttendanceID);
                indexAttendance = db.Attendances.Max(at => at.Index);
            }
            db.AttendanceDates.Add(new AttendanceDate() { AttendanceDateId = maxAttendanceDateId + 1, Date = DateTime.Now, SubjectId = Convert.ToInt32(subjectId), Index=indexAttendanceDate+1 });
            foreach (var student in studentsInGroup)
            {
                maxAttendanceId++;
                subject.Attendances.Add(new Attendance()
                {
                    AttendanceID = maxAttendanceId,
                    ClassDate = DateTime.Now,
                    IsVisited = false,
                    RecordBookNumberID = student.RecordBookNumberID,
                    SubjectID = Convert.ToInt32(subjectId), 
                    Index = indexAttendance + 1
                });
            }

            db.SaveChanges();
            return RedirectToAction(getUrl("EditAttendance", groupId, Convert.ToInt32(subjectId)));
        }
        public ActionResult RemoveAttendanceDate(string groupId, int? subjectId)
        {
            // удалить все посещения, где индекс = максимальный индекс
            int maxAttendanceDateIndex = 0, maxAttendanceIndex = 0;
            if (db.AttendanceDates.Count() > 0)
            {
                maxAttendanceDateIndex = db.AttendanceDates.Max(at => at.Index);
            }
            if (db.Attendances.Count() > 0)
            {
                maxAttendanceIndex = db.Attendances.Max(at => at.Index);
            }
            db.AttendanceDates.RemoveRange(db.AttendanceDates.Where(att => att.Index == maxAttendanceDateIndex));
            db.Attendances.RemoveRange(db.Attendances.Where(att => att.Index == maxAttendanceIndex));

            db.SaveChanges();
            return RedirectToAction(getUrl("EditAttendance", groupId, subjectId));
        }
        [HttpPost]
        public ActionResult SaveAttendances(List<Attendance> attendances, List<AttendanceDate> attendanceDates, string url)
        {
            foreach(Attendance attendance in attendances)
            {
                // находим по ID соответствующую запись о посещении и перезаписываем данные
                Attendance _attendance =  db.Attendances.Find(attendance.AttendanceID);
                _attendance.ClassDate = attendance.ClassDate;
                _attendance.Index = attendance.Index;
                _attendance.IsVisited = attendance.IsVisited;
            }
            foreach(AttendanceDate attendanceDate in attendanceDates)
            {
                AttendanceDate _attendanceDate = db.AttendanceDates.Find(attendanceDate.AttendanceDateId);
                _attendanceDate.Date = attendanceDate.Date;
                _attendanceDate.Index = attendanceDate.Index;                
            }
            int indexOfLastSlash = url.LastIndexOf('/');
            int subjectId = Convert.ToInt32(url.Substring(indexOfLastSlash + 1));
            

            db.SaveChanges();
            return View();
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