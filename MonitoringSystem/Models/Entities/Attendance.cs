using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MonitoringSystem.Models
{
    [Table("Attendances")]
    public class Attendance
    {
        public int AttendanceID { get; set; }

        public string RecordBookNumberID { get; set; }
        public int SubjectID { get; set; }
        public DateTime? ClassDate { get; set; }
        public bool? IsVisited { get; set; }



        public virtual Student Student { get; set; }
        public virtual Subject Subject { get; set; }

    }
}