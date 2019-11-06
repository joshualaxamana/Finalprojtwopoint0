using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

public partial class Student_Register : System.Web.UI.Page
{
    SqlConnection con = new SqlConnection(Helper.GetConnection());
    protected void Page_Load(object sender, EventArgs e)
    {
       GetID();
    }

    void GetID()
    {
        con.Open();
        SqlCommand cmd = new SqlCommand();
        cmd.Connection = con;
        cmd.CommandText = "SELECT TOP 1 IDnumber FROM student ORDER BY IDnumber DESC";
        SqlDataReader data = cmd.ExecuteReader();
        if (data.HasRows)
        {
            data.Read();
            txtID.Text = data["IDnumber"].ToString();
            int num = Int32.Parse(txtID.Text) + 1;
            txtID.Text = num.ToString();
            con.Close();
        }
        else
        {
            txtID.Text = "10000000";
            con.Close();
        }
    }

   



    protected void btnRegister_Click(object sender, EventArgs e)
    {
        bool existingUser = IsExisting(txtEmail.Text);
        if (existingUser)
        {
            error.Visible = true;
        }
        else
        {
            con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = @"INSERT INTO student VALUES ( @studentEmail, @studentPassword, @studentFN, @studentLN, @studentCourse, @studentAddress, @studentContact)";

            cmd.Parameters.AddWithValue("@studentFN", txtFN.Text);
            cmd.Parameters.AddWithValue("@studentLN", txtLN.Text);
            cmd.Parameters.AddWithValue("@studentCourse", txtCourse.Text);
            cmd.Parameters.AddWithValue("@studentAddress", txtAddress.Text);
            cmd.Parameters.AddWithValue("@studentContact", txtContact.Text);
            cmd.Parameters.AddWithValue("@studentEmail", txtEmail.Text);
            cmd.Parameters.AddWithValue("@studentPassword",Helper.CreateSHAHash(txtPassword.Text));
            cmd.ExecuteNonQuery();
            con.Close();

            Response.Redirect("Login.aspx");
        }
    }

    bool IsExisting(string email)
    {
        con.Open();
        SqlCommand cmd = new SqlCommand();
        cmd.Connection = con;
        cmd.CommandText = @"SELECT Email FROM Student WHERE Email=@email";
        cmd.Parameters.AddWithValue("@email", email);
        bool existing = cmd.ExecuteScalar() == null ? false : true;
        con.Close();
        return existing;
    }
}