using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MonitoringSystem.Models
{
    [Table("HomeWorks")]
    public class HomeWork
    {
        public int HomeWorkID { get; set; }

        [Index("IX_RecordBookNumberIDSubjectIDModule1Module2Module3Module4", 1, IsUnique = true)]
        public string RecordBookNumberID { get; set; }

        [Index("IX_RecordBookNumberIDSubjectIDModule1Module2Module3Module4", 2, IsUnique = true)]
        public int SubjectID { get; set; }

        [Index("IX_RecordBookNumberIDSubjectIDModule1Module2Module3Module4", 3, IsUnique = true)]
        public short? HWPoint { get; set; }

        [Index("IX_RecordBookNumberIDSubjectIDModule1Module2Module3Module4", 4, IsUnique = true)]
        public int HWNumber { get; set; }

        public DateTime DateOfReport { get; set; }

        public DateTime DateOfProgram { get; set; }

        public int TeacherID { get; set; }

        public virtual Teacher Teacher { get; set; }
        public virtual Student Student { get; set; }
        public virtual Subject Subject { get; set; }
    }
}