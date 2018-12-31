using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CLStudentsDb;

public partial class Subjects : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack)
        {
            //disabling delete button, will be enabled after confirmation via checkbox
            btnDelSubjects.Enabled = false;
        }
    }

    protected void btnImportSubjectInfo_Click(object sender, EventArgs e)
    {
        //branches for selected and not selected exam date
        if (cldrExamDate.SelectedDate.ToShortDateString() != DateTime.MinValue.ToShortDateString())
        {
            SubjectFunctions insrt = new SubjectFunctions(txtSubject.Text, txtTeacher.Text, cldrExamDate.SelectedDate.ToShortDateString().ToString());
            insrt.InsertSubject();
            lblTest.Text = string.Format("Selected date:{0}", cldrExamDate.SelectedDate.ToShortDateString().ToString());
        }
        else
        {
            SubjectFunctions insrt = new SubjectFunctions(txtSubject.Text, txtTeacher.Text);
            insrt.InsertSubject();
            lblTest.Text = string.Format("not selected date");
        }    
    }

    //check if checkbox is checked :) if yes, you can proceed with delete all student records
    protected void chckSubBox_CheckedChanged(object sender, EventArgs e)
    {
        if (Page.IsPostBack && chckSubBox.Checked == true)
            btnDelSubjects.Enabled = true;
        else
            btnDelSubjects.Enabled = false;
    }

    protected void btnDelSubjects_Click(object sender, EventArgs e)
    {
        //deleting all subjects by button click :)
        DelRecords delrcdrs = new DelRecords();
        delrcdrs.DeleteAllRecords("Subjects");
    }
}