using System.Data.Entity;

namespace MonitoringSystem.Models
{
    public class TotalJournalContext : DbContext
    {
        public TotalJournalContext() 
            : base("name=TotalJournalContext") {}

        public virtual DbSet<Group> Groups { get; set; }
        public virtual DbSet<Student> Students { get; set; }
        public virtual DbSet<Teacher> Teachers { get; set; }        

        public virtual DbSet<Subject> Subjects { get; set; }
        public virtual DbSet<SubjectCP> SubjectCPs { get; set; }

        public virtual DbSet<Attendance> Attendances { get; set; }
        public virtual DbSet<AttendanceDate> AttendanceDates { get; set; }
        public virtual DbSet<OneItemPoint> OneItemPoints { get; set; }
        public virtual DbSet<Module> Modules { get; set; }
        public virtual DbSet<Mark> Marks { get; set; }
        public virtual DbSet<HomeWork> HomeWorks { get; set;}
        public virtual DbSet<LabMaxPoint> LabMaxPoints { get; set; }
        public virtual DbSet<HWMaxPoint> HWMaxPoints { get; set; }
        public virtual DbSet<ModuleMaxPoint> ModuleMaxPoints { get; set; }
        public virtual DbSet<FreeMarkField> FreeMarkFields { get; set; }
        public virtual DbSet<FreeMarkFieldMaxPoint> FreeMarkFieldMaxPoints { get; set; }

        public virtual DbSet<CourseProjectLine> CourseProjectLines { get; set; }
        public virtual DbSet<CPLineMaxPoint> CPLineMaxPoints { get; set; }
    }
}