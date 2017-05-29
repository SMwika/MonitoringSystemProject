using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MonitoringSystem.Models
{
    [Table("Subjects")]
    public class Subject
    {
        public Subject()
        {
            Marks = new HashSet<Mark>();
            Attendances = new HashSet<Attendance>();
            Modules = new HashSet<Module>();
            HomeWorks = new HashSet<HomeWork>();
            LabMaxPoints = new HashSet<LabMaxPoint>();
            ModuleMaxPoints = new HashSet<ModuleMaxPoint>();
            HWMaxPoints = new HashSet<HWMaxPoint>();
            AttsMaxPoints = new HashSet<AttMaxPoint>();
            FreeMarkFields = new HashSet<FreeMarkField>();
            FreeMarkFieldMaxPoints = new HashSet<FreeMarkFieldMaxPoint>();
            AttendanceDates = new HashSet<AttendanceDate>();
            OneItemPoints = new HashSet<OneItemPoint>();

            //Students = new HashSet<Student>();
            Groups = new HashSet<Group>();
        }
     
        public int SubjectID { get; set; }
        public int TeacherID { get; set; }
        public virtual Teacher Teacher { get; set; }

        [Required(ErrorMessage = "Введите название предмета"), Display(Name = "Название предмета")]
        public string SubjectName { get; set; }

        [Required(ErrorMessage = "Введите № семестра"), Display(Name = "№ семестра")]
        public int Term { get; set; }

        [Required(ErrorMessage = "Выберите тип предмета"), Display(Name = "Тип предмета")]
        public SubjectType SubjectType { get; set; }

        public virtual ICollection<Mark> Marks { get; set; }
        public virtual ICollection<Attendance> Attendances { get; set; }
        public virtual ICollection<Module> Modules { get; set; }
        public virtual ICollection<HomeWork> HomeWorks { get; set; }
        public virtual ICollection<LabMaxPoint> LabMaxPoints { get; set; }
        public virtual ICollection<HWMaxPoint> HWMaxPoints { get; set; }
        public virtual ICollection<ModuleMaxPoint> ModuleMaxPoints { get; set; }
        public virtual ICollection<AttMaxPoint> AttsMaxPoints { get; set; }
        public virtual ICollection<FreeMarkField> FreeMarkFields { get; set; }
        public virtual ICollection<FreeMarkFieldMaxPoint> FreeMarkFieldMaxPoints { get; set; }
        public virtual ICollection<AttendanceDate> AttendanceDates { get; set; }
        public virtual ICollection<OneItemPoint> OneItemPoints { get; set; } 
             
        //public virtual ICollection<Student> Students { get; set; }
        public virtual ICollection<Group> Groups { get; set; }
        
    }

    public enum SubjectType
    {
        [Display(Name ="Экзамен")]
        Exam,
        [Display(Name = "Зачет")]
        Credit,
        [Display(Name = "Диф.зачет")]
        DiffCredit
    }
}