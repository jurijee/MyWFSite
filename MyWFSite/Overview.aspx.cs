using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CLStudentsDb;

public partial class Overview : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //just for fun - displays browser :)
        ltrlTest.Text = Page.Request.Browser.Browser;

        //repeater stuff
        SubjectFunctions seldata = new SubjectFunctions();
        rptrSubjectSummary.DataSource = seldata.SelectSubjectInfo();
        rptrSubjectSummary.DataBind();     
    }
}