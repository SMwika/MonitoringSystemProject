using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MonitoringSystemModel
{
    [Table("Students")]
    public class Student
    {
        public Student()
        {            
            Subjects = new HashSet<Subject>();
            SubjectCPs = new HashSet<SubjectCP>();
        }

        [Key, Required (ErrorMessage ="Введите № зачетки студента"), Display(Name ="№ зачетки")]
        public string RecordBookNumberID { get; set; }

        public string GroupID { get; set; }
        public virtual Group Group { get; set; }

        [Required (ErrorMessage ="Введите имя"), Display(Name ="Имя студента")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Введите отчество"), Display(Name = "Отчество студента")]
        public string MiddleName { get; set; }

        [Required(ErrorMessage = "Введите фамилию"), Display(Name = "Фамилия студента")]
        public string LastName { get; set; }
       
        public virtual ICollection<Subject> Subjects { get; set; }
        public virtual ICollection<SubjectCP> SubjectCPs { get; set; }
    }
}
