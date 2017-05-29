using System.Collections.Generic;
using MonitoringSystem.Models;

namespace MonitoringSystem.Controllers
{
    public class ModelListSubjectCPs
    {
        public List<Student> studentsToShow { get; set; }
        public List<CourseProjectLine> linesToShow { get; set; }
        public List<CPLineMaxPoint> cpLinesMaxPoints { get; set; }
        public string GroupName { get; set; }
        public string SubjectCPName { get; set; }
        public int SubjectCPId { get; set; }
    }
}