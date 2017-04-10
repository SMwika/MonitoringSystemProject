using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MonitoringSystem.Models
{
    [Table("FreeMarkFields")]
    public class FreeMarkField
    {
        public int FreeMarkFieldID { get; set; }
        public string FieldName { get; set; }
        
        [Index("IX_FieldsNumberRecordBookNumberIDSubjectID", 1, IsUnique = true)]
        public short FieldNumber { get; set; }

        [Index("IX_LabNumberRecordBookNumberIDSubjectID", 2, IsUnique = true)]
        public string RecordBookNumberID { get; set; }

        [Index("IX_LabNumberRecordBookNumberIDSubjectID", 3, IsUnique = true)]
        public int SubjectID { get; set; }

        public int TeacherID { get; set; }
        public short FieldPoint { get; set; }

        public virtual Student Student { get; set; }
        public virtual Subject Subject { get; set; }
        public virtual Teacher Teacher { get; set; }
    }
}