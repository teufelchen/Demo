using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Text;
using System.Web.UI.WebControls;
using ASPNetMVCTutorial.Models;
using ASPNetMVCTutorial.Utilities;

namespace ASPNetMVCTutorial.Views.Shared
{
    public partial class Site : System.Web.Mvc.ViewMasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            ApplicationInformation appInfomation = ApplicationInformation.GetInstance();
            litAppTitle.Text = appInfomation.ApplicationName;
            litApplicationName.Text = "Simple Project";

            StringBuilder SB = new StringBuilder();
            SB.Append("Developed by ");
            SB.Append("Teodora Tsoykova");
            SB.Append(" on ");
            SB.Append("05.06.2013");
            litAuthorInformation.Text = SB.ToString();
        }
    }
}
