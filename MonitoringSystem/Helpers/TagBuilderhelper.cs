using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MonitoringSystem.Models;

namespace MonitoringSystem.Helpers
{
    public static class TagBuilderhelper
    {
        public static MvcHtmlString formRefsToSubjects(this HtmlHelper helper, string groupId)
        {
            TagBuilder ahrefTag = new TagBuilder("a");
            ahrefTag.InnerHtml = groupId;
            ahrefTag.MergeAttribute("href", "/Subjects/ShowSubjectsByCourseNumber/" + groupId);
            return new MvcHtmlString(ahrefTag.ToString());
        }
      
    }
}