using System;
using System.Text;
using System.Web;
using System.Web.UI.WebControls;
using ASPNetMVCTutorial.Models;
using ASPNetMVCTutorial.Utilities;

namespace ASPNetMVCTutorial.Views.Students
{
    public class AddStudent : System.Web.Mvc.ViewPage
    {
        protected HyperLink linkCancelAddStudent;
        protected Literal litAddStudentActionHidden;
        protected void Page_Load(object sender, EventArgs e)
        {
            Response.Cache.SetCacheability(HttpCacheability.NoCache);

            StringBuilder SB = new StringBuilder();
            SB.Append("<input type=\"hidden\" id=\"hidAddstudentActionURL\" value=\"");
            SB.Append(ApplicationUtility.FormatURL("/Students/AddStudentAction"));
            SB.Append("\" />");
            linkCancelAddStudent.NavigateUrl
                = ApplicationUtility.FormatURL("/Students/StudentList");
            litAddStudentActionHidden.Text = SB.ToString();
        }

    }
}
