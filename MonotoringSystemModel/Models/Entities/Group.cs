using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MonitoringSystemModel
{
    [Table("Groups")]
    public class Group
    {
        public Group()
        {
            Students = new HashSet<Student>();
            Subjects = new HashSet<Subject>();
            SubjectCPs = new HashSet<SubjectCP>();
        }

        [Display(Name = "Номер группы"), Required(ErrorMessage = "Введите номер группы"),
        MinLength(4, ErrorMessage = "Длина названия группы - минимум 4 символа"),
        MaxLength(6, ErrorMessage = "Длина названия группы - максимум 6 символов")]
        public string GroupID { get; set; }

        [Display(Name = "Номер курса"), Required(ErrorMessage = "Введите номер курса")]
        public int CourseNumber { get; set; }
        
        public virtual ICollection<Student> Students { get; set; }
        public virtual ICollection<Subject> Subjects { get; set; }
        public virtual ICollection<SubjectCP> SubjectCPs { get; set; }
    }

    

}