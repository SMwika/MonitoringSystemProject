using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MonitoringSystem.Models
{
    [Table("CourseProjectLines")]
    public class CourseProjectLine
    {
        public int CourseProjectLineID { get; set; }

        public string LineName { get; set; }

        [Index("IX_RecordBookNumberIDSubjectCP_IDTheMark", 1, IsUnique = true)]
        public string RecordBookNumberID { get; set; }

        [Index("IX_RecordBookNumberIDSubjectCP_IDTheMark", 2, IsUnique = true)]
        public int SubjectCP_ID { get; set; }

        [Index("IX_RecordBookNumberIDSubjectCP_IDTheMark", 3, IsUnique = true)]
        public int TheMark { get; set; }

        public int TeacherID { get; set; }

        public virtual Teacher Teacher { get; set; }
        public virtual Student Student { get; set; }
        public virtual SubjectCP SubjectCP { get; set; }
    }
}