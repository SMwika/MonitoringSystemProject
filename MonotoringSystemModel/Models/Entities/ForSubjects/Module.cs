using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MonitoringSystemModel
{
    [Table("Modules")]
    public class Module
    {
        public int ModuleID { get; set; }

        [Index("IX_RecordBookNumberIDModuleIDModuleModulePoint", 1, IsUnique = true)]
        public string RecordBookNumberID { get; set; }

        [Index("IX_RecordBookNumberIDModuleIDModuleModulePoint", 2, IsUnique = true)]
        public int SubjectID { get; set; }

        [Index("IX_RecordBookNumberIDModuleIDModuleModulePoint", 3, IsUnique = true)]
        public int ModulePoint { get; set; }

        [Index("IX_RecordBookNumberIDModuleIDModuleModulePoint", 4, IsUnique = true)]
        public int ModuleNumber { get; set; }

        public virtual Student Student { get; set; }
        public virtual Subject Subject { get; set; }
    }
}