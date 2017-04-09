using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MonitoringSystem.Models
{
    [Table("Groups")]
    public class Group
    {
        public Group()
        {
            Students = new HashSet<Student>();
        }

        [Display(Name = "Номер группы"), Required(ErrorMessage = "Введите номер группы"),
        MinLength(4, ErrorMessage = "Длина названия группы - минимум 4 символа"),
        MaxLength(6, ErrorMessage = "Длина названия группы - максимум 6 символов")]
        public string GroupID { get; set; }

        //[NotMapped]
        //[Display (Name ="Номер курса")]
        //public int CourseNumber
        //{
        //    // 4 characters or more
        //    get
        //    {
        //        if (GroupID.Length == 4)
        //        {
        //            return Int32.Parse(GroupID.Substring(1, 1));
        //        }
        //        return Int32.Parse(GroupID.Substring(1, 1)) + 1;
        //    }
        //}
        public int CourseNumber { get; set; }
        
        public virtual ICollection<Student> Students { get; set; }
    }

    

}