using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MonitoringSystemModel
{
    [Table("Marks")]
    public class Mark
    {   
        public int MarkID { get; set; }

        [Index("IX_LabNumberRecordBookNumberIDSubjectID", 1, IsUnique =true)]
        public int LabNumber { get; set; }

        [Index("IX_LabNumberRecordBookNumberIDSubjectID", 2, IsUnique = true)]
        public string RecordBookNumberID { get; set; }

        [Index("IX_LabNumberRecordBookNumberIDSubjectID", 3, IsUnique = true)]
        public int SubjectID { get; set; }

        public DateTime DateOfReport { get; set; }
        public DateTime DateOfProgram { get; set; }
        public int TheMark { get; set; }
        
        public virtual Student Student { get; set; }
        public virtual Subject Subject { get; set; }
    }
}