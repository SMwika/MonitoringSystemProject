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

        }
     
        public int SubjectID { get; set; }

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