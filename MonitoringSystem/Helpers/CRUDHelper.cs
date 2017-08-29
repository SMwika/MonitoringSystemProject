using MonitoringSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MonitoringSystemModel;

namespace MonitoringSystem.Helpers
{
    public class CRUDHelper
    {
        
        public void AddMarkColumn(ref TotalJournalContext db, string type, string groupId, int? subjectId)
        {
            //получаем максимальный номер лабы по предмету
            //получаем максимальный ИД в таблице
            // в цикле по студентам каждому студенту присваиваем ноль по лабе с данным номером
            Subject subject = db.Subjects.Find(subjectId);
            List<Group> groups = subject.Groups.ToList();
            Group group = db.Groups.Find(groupId);
            
            #region
            int MaxLabNumber = 0,
                MaxLabID = 0,
                MaxLabMaxPointID = 0;

            if (db.LabMaxPoints.Where(m => m.Subject.SubjectID == subjectId).Count() != 0)
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
            #endregion

            foreach (var grp in groups)
            {
                foreach (var student in grp.Students)
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
            }
            db.SaveChanges();
        }

        public void RemoveColumn(ref TotalJournalContext context, string type, string groupId, int? subjectId)
        {

        }
    }
}