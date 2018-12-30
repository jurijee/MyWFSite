using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;

/// <summary>
/// Summary description for StudentFunctions
/// </summary>
public class StudentFunctions
{
    ConToDb connstr = new ConToDb("ProjectStudentsDB");

    public StudentFunctions()
    {
        //
        // TODO: Add constructor logic here
        //
    }

    /// <summary>
    /// inserts student in to database
    /// </summary>
    /// <param name="name"></param>
    /// <param name="surname"></param>
    /// <param name="grade"></param>
    /// <param name="subject"></param>
    public void InsertStudent(string name, string surname, short grade, string subject)
    {

        using (SqlConnection sqlconn = new SqlConnection(connstr.GetConnectionString()))
        {
            SqlCommand sqlquery = new SqlCommand();
            sqlquery.CommandText = string.Format("InsStudent");
            sqlquery.CommandType = CommandType.StoredProcedure;
            sqlquery.Parameters.Add(new SqlParameter("@name", SqlDbType.VarChar, 50));
            sqlquery.Parameters["@name"].Value = name;
            sqlquery.Parameters.Add(new SqlParameter("@surname", SqlDbType.VarChar, 50));
            sqlquery.Parameters["@surname"].Value = surname;
            sqlquery.Parameters.Add(new SqlParameter("@grade", SqlDbType.SmallInt));
            sqlquery.Parameters["@grade"].Value = grade;
            sqlquery.Parameters.Add(new SqlParameter("@subject", SqlDbType.VarChar, 50));
            sqlquery.Parameters["@subject"].Value = subject;
            sqlconn.Open();
            sqlquery.Connection = sqlconn;
            sqlquery.ExecuteNonQuery();
            sqlconn.Close();
        }
    }

    /*public DataTable SelectSubjectInfo()
    {
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
            string sqlquery = "SELECT Subject FROM SelDistSubjects";
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
    }*/
}