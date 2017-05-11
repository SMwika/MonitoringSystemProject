using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MonitoringSystem.Models
{
    [Table("SubjectCPs")]
    public class SubjectCP
    {
        public SubjectCP()
        {
            CourseProjectLines = new HashSet<CourseProjectLine>();
            CPLineMaxPoints = new HashSet<CPLineMaxPoint>();
        }

        [Key]
        public int SubjectCP_ID { get; set; }
        public int TeacherID { get; set; }
        public string SubjectCPName { get; set; }

        [Required(ErrorMessage = "Введите № семестра"), Display(Name = "№ семестра")]
        public int Term { get; set; }
        public virtual Teacher Teacher { get; set; }
        public virtual ICollection<CourseProjectLine> CourseProjectLines { get; set; }
        public virtual ICollection<CPLineMaxPoint> CPLineMaxPoints { get; set; }
    }
}