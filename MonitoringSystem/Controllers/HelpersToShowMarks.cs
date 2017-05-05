﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using MonitoringSystem.Models;
using System.Linq;
using System.Web;

namespace MonitoringSystem.Controllers
{
    public class TemplateToMarks
    {
        [JsonProperty("rbn")]
        public string rbn { get; set; }
        [JsonProperty("inputId")]
        public string inputId { get; set; }
        [JsonProperty("markType")]
        public string markType { get; set; }
        [JsonProperty("inputvalue")]
        public string inputvalue { get; set; }
        [JsonProperty("dateOfReport")]
        public DateTime dateOfReport { get; set; }
        [JsonProperty("dateOfProgram")]
        public DateTime dateOfProgram { get; set; }
    }

    public class ModelList
    {
        public List<Student> studentsToShow { get; set; }

        public List<Mark> marksToShow { get; set; }
        public List<Module> modulesToShow { get; set; }
        public List<HomeWork> hwToShow { get; set; }
        public List<LabMaxPoint> labMaxPoints { get; set; }
        public List<HWMaxPoint> hwMaxPoints { get; set; }
        public List<ModuleMaxPoint> moduleMaxPoints { get; set; }
        public List<AttMaxPoint> attendanceMaxPoints { get; set; }
        public List<FreeMarkField> freeMarkFields { get; set; }
        public List<FreeMarkFieldMaxPoint> freeMarkFieldMaxPoints { get; set; }
        public string GroupName { get; set; }
        public string SubjectName { get; set; }
        public int SubjectId { get; set; }
        public int[] attendanceAmount { get; set; }
    }
}