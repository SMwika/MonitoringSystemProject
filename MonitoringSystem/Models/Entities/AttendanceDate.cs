using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MonitoringSystem.Models
{ 
    public class AttendanceDate
    {
        public int AttendanceDateId { get; set; }
        public DateTime Date { get; set; }
        public int Index { get; set; }
        public int SubjectId { get; set; }
        public virtual Subject Subject { get; set; }
    }
}