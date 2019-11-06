using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;


public partial class Student_Login : System.Web.UI.Page
{
    SqlConnection con = new SqlConnection(Helper.GetConnection());
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnLogin_Click(object sender, EventArgs e)
    {
        con.Open();
        SqlCommand cmd = new SqlCommand();
        cmd.Connection = con;
        cmd.CommandText = @"SELECT IDnumber FROM student WHERE IDnumber=@studentID AND password=@password";
        cmd.Parameters.AddWithValue("@studentID", txtIDnum.Text);
        cmd.Parameters.AddWithValue("@password", Helper.CreateSHAHash(txtPW.Text));
        SqlDataReader dr = cmd.ExecuteReader();
        if (dr.HasRows)
        {
            while (dr.Read())
            {
                Model.IDNumber = dr["IDnumber"].ToString();
            }

            Response.Redirect("Default.aspx");
        }
        else
        {
            Error.Visible = true;
        }
        con.Close();
    }
}