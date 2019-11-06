using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

public partial class Guard_Register : System.Web.UI.Page
{
    SqlConnection con = new SqlConnection(Helper.GetConnection());
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            getIdnumber();
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
            cmd.CommandText = @"INSERT INTO guard VALUES (@guardEmail, @guardPassword, @guardFN, @guardLN)";
            cmd.Parameters.AddWithValue("@guardFN", txtFN.Text);
            cmd.Parameters.AddWithValue("@guardLN", txtLN.Text);
            cmd.Parameters.AddWithValue("@guardEmail", txtEmail.Text);
            cmd.Parameters.AddWithValue("@guardPassword", Helper.CreateSHAHash(txtPassword.Text));
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
        cmd.CommandText = @"SELECT Email FROM Guard WHERE Email=@email";
        cmd.Parameters.AddWithValue("@email", email);
        bool existing = cmd.ExecuteScalar() == null ? false : true;
        con.Close();
        return existing;
    }
    void getIdnumber ()
    {
        con.Open();
        SqlCommand cmd = new SqlCommand();
        cmd.Connection = con;
        cmd.CommandText = "SELECT TOP 1 guardID FROM guard ORDER BY guardID DESC";
        SqlDataReader data = cmd.ExecuteReader();
        if (data.HasRows)
        {
            data.Read();
            txtID.Text = data["guardID"].ToString();
            int num = Int32.Parse(txtID.Text) + 1;
            txtID.Text = num.ToString();
            con.Close();
        }
        else
        {
            txtID.Text = "20000000";
            con.Close();
        }
    }
}