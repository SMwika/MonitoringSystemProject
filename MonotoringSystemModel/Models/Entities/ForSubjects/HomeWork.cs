using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MonitoringSystemModel
{
    [Table("HomeWorks")]
    public class HomeWork
    {
        public int HomeWorkID { get; set; }

        [Index("IX_RecordBookNumberIDSubjectIDHomeWorkIDHWNumber", 1, IsUnique = true)]
        public string RecordBookNumberID { get; set; }

        [Index("IX_RecordBookNumberIDSubjectIDHomeWorkIDHWNumber", 2, IsUnique = true)]
        public int SubjectID { get; set; }

        [Index("IX_RecordBookNumberIDSubjectIDHomeWorkIDHWNumber", 3, IsUnique = true)]
        public int HWPoint { get; set; }

        [Index("IX_RecordBookNumberIDSubjectIDHomeWorkIDHWNumber", 4, IsUnique = true)]
        public int HWNumber { get; set; }

        public DateTime DateOfReport { get; set; }
        public DateTime DateOfProgram { get; set; }

        public virtual Student Student { get; set; }
        public virtual Subject Subject { get; set; }
    }
}