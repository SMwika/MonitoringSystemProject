using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MonitoringSystem.Models
{
    [Table("Students")]
    public class Student
    {
        public Student()
        {
            Marks = new HashSet<Mark>();
            Attendances = new HashSet<Attendance>();
            Modules = new HashSet<Module>();
            CourseProjectLines = new HashSet<CourseProjectLine>();
            Homeworks = new HashSet<HomeWork>();
            FreeMarkFields = new HashSet<FreeMarkField>();
        }

        [Key, Required (ErrorMessage ="Введите № зачетки студента"), Display(Name ="№ зачетки")]
        public string RecordBookNumberID { get; set; }

        public string GroupID { get; set; }
        public virtual Group Group { get; set; }
        public virtual Subject Subject { get; set; }

        [Required (ErrorMessage ="Введите имя"), Display(Name ="Имя студента")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Введите отчество"), Display(Name = "Отчество студента")]
        public string MiddleName { get; set; }

        [Required(ErrorMessage = "Введите фамилию"), Display(Name = "Фамилия студента")]
        public string LastName { get; set; }

        public virtual ICollection<Mark> Marks { get; set; }
        public virtual ICollection<Attendance> Attendances { get; set; }
        public virtual ICollection<Module> Modules { get; set; }
        public virtual ICollection<CourseProjectLine> CourseProjectLines { get; set; }
        public virtual ICollection<HomeWork> Homeworks { get; set; }
        public virtual ICollection<FreeMarkField> FreeMarkFields { get; set; }
    }
}