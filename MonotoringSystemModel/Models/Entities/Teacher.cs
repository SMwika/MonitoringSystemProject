using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MonitoringSystemModel
{
    [Table("Teachers")]
    public class Teacher
    {
        public Teacher()
        {
            Subjects = new HashSet<Subject>();
            SubjectsCPs = new HashSet<SubjectCP>();
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

        public virtual ICollection<Subject> Subjects { get; set; }
        public virtual ICollection<SubjectCP> SubjectsCPs { get; set; }
    }
}