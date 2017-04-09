using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MonitoringSystem.Models
{
    public class LabMaxPoint
    {
        public int LabMaxPointID { get; set; }
        public int SubjectID { get; set; }
        public int LabNumber { get; set; }

        public short MaxPoint { get; set; }

        public virtual Subject Subject { get; set; }
    }

    public class HWMaxPoint
    {
        public int HWMaxPointID { get; set; }
        public int SubjectID { get; set; }
        public int HWNumber { get; set; }

        public short MaxPoint { get; set; }

        public virtual Subject Subject { get; set; }
    }

    public class ModuleMaxPoint
    {
        public int ModuleMaxPointID { get; set; }
        public int SubjectID { get; set; }
        public int ModuleNumber { get; set; }

        public short MaxPoint { get; set; }

        public virtual Subject Subject { get; set; }
    }

    public class AttMaxPoint
    {
        public int AttMaxPointID { get; set; }
        public int SubjectID { get; set; }
        
        public short MaxAmount { get; set; }

        public virtual Subject Subject { get; set; }
    }

}