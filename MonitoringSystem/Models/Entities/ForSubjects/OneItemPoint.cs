using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MonitoringSystem.Models
{
    public class OneItemPoint
    {
        public int OneItemPointID { get; set; }
        public string Value { get; set; }
        public int SubjectId { get; set; }
        public virtual Subject Subject { get; set; }
    }
}