using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CLStudentsDb;

public partial class Students : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        SubjectFunctions seldistsub = new SubjectFunctions();
        if (!Page.IsPostBack)
        {
            //populating drop down list
            ddlSubjectDrop.DataSource = seldistsub.SelectDistinctSubject();
            ddlSubjectDrop.DataValueField = "Subject";
            ddlSubjectDrop.DataBind();

            //disabling delete button, will be enabled after confirmation via checkbox
            btnDelStudents.Enabled = false;

            //testing dev tools/features
            //Trace.IsEnabled = true;
        }
    }

    //inserting new student record in to the database
    protected void btnImportStudentInfo_Click(object sender, EventArgs e)
    {
        StudentFunctions instudent = new StudentFunctions(txtName.Text, txtSurname.Text, short.Parse(txtGrade.Text), ddlSubjectDrop.SelectedValue);
        instudent.InsertStudent();
    }

    //check if checkbox is checked :) if yes, you can proceed with delete all student records
    protected void chckBox_CheckedChanged(object sender, EventArgs e)
    {
        if (Page.IsPostBack && chckBox.Checked == true)
            btnDelStudents.Enabled = true;
        else
            btnDelStudents.Enabled = false;
    }

    protected void btnDelStudents_Click(object sender, EventArgs e)
    {
        //deleting all subjects by button click :)
        DelRecords delrcdrs = new DelRecords();
        delrcdrs.DeleteAllRecords("Students");
    }
}