using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Data;

/// <summary>
/// Summary description for SubjectFunctions
/// </summary>
public class SubjectFunctions
{
    ConToDb connstr = new ConToDb("ProjectStudentsDB");

    public SubjectFunctions()
    {
        //
        // TODO: Add constructor logic here
        //
    }

    public void InsertSubject(string subject, string teacher, string date)
    {

        using (SqlConnection sqlconn = new SqlConnection(connstr.GetConnectionString()))
        {
            SqlCommand sqlquery = new SqlCommand();
            sqlquery.CommandText = string.Format("INSERT INTO Subjects VALUES ('{0}','{1}','{2}')", subject, teacher, date);
            sqlconn.Open();
            sqlquery.Connection = sqlconn;
            sqlquery.ExecuteNonQuery();
            sqlconn.Close();
        }
    }
        
    public DataTable SelectSubjectInfo() { 
        using (SqlConnection sqlconn = new SqlConnection(connstr.GetConnectionString()))
        {
            string sqlquery = "SELECT Subject, Teacher, ExamDate FROM Subjects";
            DataTable dt = new DataTable();

            try
            {
                SqlDataAdapter sda = new SqlDataAdapter(sqlquery, connstr.GetConnectionString());
                sqlconn.Open();
                sda.Fill(dt);
                return dt;                
            }

            finally
            {
                sqlconn.Close();
                sqlconn.Dispose();
            }
        }
    }

    public DataTable SelectDistinctSubject()
    {
        using (SqlConnection sqlconn = new SqlConnection(connstr.GetConnectionString()))
        {
            string sqlquery = "SELECT 'PLEASE SELECT' as Subject FROM Subjects UNION SELECT DISTINCT Subject FROM Subjects";
            DataTable dt = new DataTable();

            try
            {
                SqlDataAdapter sda = new SqlDataAdapter(sqlquery, connstr.GetConnectionString());
                sqlconn.Open();
                sda.Fill(dt);
                return dt;
            }

            finally
            {
                sqlconn.Close();
                sqlconn.Dispose();
            }
        }
    }
}