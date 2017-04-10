using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MonitoringSystem.Models
{
    [Table("Teachers")]
    public class Teacher
    {
        public Teacher()
        {
            Marks = new HashSet<Mark>();
            CourseProjectLines = new HashSet<CourseProjectLine>();
            HomeWorks = new HashSet<HomeWork>();
            Modules = new HashSet<Module>();
            FreeMarkFields = new HashSet<FreeMarkField>();
        }

        public int TeacherID { get; set; }

        [Required(ErrorMessage = "Введите имя"), Display(Name = "Имя учителя")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Введите отчество"), Display(Name = "Отчество учителя")]
        public string MiddleName { get; set; }

        [Required(ErrorMessage = "Введите фамилию"), Display(Name = "Фамилия учителя")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "Введите научную степень"), Display(Name = "Научная степень")]
        public string AcadDegree { get; set; }

        public virtual ICollection<Mark> Marks { get; set; }
        public virtual ICollection<CourseProjectLine> CourseProjectLines { get; set; }
        public virtual ICollection<HomeWork> HomeWorks { get; set; }
        public virtual ICollection<Module> Modules { get; set; }
        public virtual ICollection<FreeMarkField> FreeMarkFields { get; set; }
    }
}