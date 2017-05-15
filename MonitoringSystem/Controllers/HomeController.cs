using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MonitoringSystem.Models;
using System.Net;

namespace MonitoringSystem.Controllers
{
    public class HomeController : Controller
    {
        private TotalJournalContext db = new TotalJournalContext();

        public ActionResult Index()
        {
            return View(db.Groups.ToList());
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        [HttpGet]
        public ActionResult SearchStudent()
        {
            return View();
        }

        [HttpPost]
        public ActionResult SearchStudent(string RecordBookNumberID)
        {
            if (RecordBookNumberID == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            List<Student> student = new List<Student>();

            var search = db.Students.Where(rbn => rbn.RecordBookNumberID == RecordBookNumberID);

            student = search.ToList();
            return View("SearchStudentResults",student);
        }
    }

    public class GroupModel
    {
        public List<Group> groups { get; set; }
    }
}