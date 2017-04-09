using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MonitoringSystem.Models
{
    [Table("Modules")]
    public class Module
    {
        public int ModuleID { get; set; }

        [Index("IX_RecordBookNumberIDHomeWorkIDModuleModulePoint", 1, IsUnique = true)]
        public string RecordBookNumberID { get; set; }

        [Index("IX_RecordBookNumberIDHomeWorkIDModuleModulePoint", 2, IsUnique = true)]
        public int SubjectID { get; set; }

        [Index("IX_RecordBookNumberIDHomeWorkIDModuleModulePoint", 3, IsUnique = true)]
        public short? ModulePoint { get; set; }

        [Index("IX_RecordBookNumberIDHomeWorkIDModuleModulePoint", 4, IsUnique = true)]
        public short ModuleNumber { get; set; }

        public short? OlympiadPoints { get; set; }
        public short? AdditionalPoints { get; set; }

        public int TeacherID { get; set; }

        public virtual Teacher Teacher { get; set; }
        public virtual Student Student { get; set; }
        public virtual Subject Subject { get; set; }
    }
}