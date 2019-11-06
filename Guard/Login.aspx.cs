using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

public partial class Guard_Login : System.Web.UI.Page
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
        cmd.CommandText = @"SELECT GuardID FROM guard WHERE GuardID=@GuardID AND Password=@Password";
        cmd.Parameters.AddWithValue("@GuardID", txtIDnum.Text);
        cmd.Parameters.AddWithValue("@Password", Helper.CreateSHAHash(txtPW.Text));
        SqlDataReader dr = cmd.ExecuteReader();
        if (dr.HasRows)
        {
            while (dr.Read())
            {
                Model.IDNumber = dr["GuardID"].ToString();
            }
            con.Close();
            Response.Redirect("Default.aspx");
        }
        else
        {
            con.Close();
            Error.Visible = true;
        }
        
    }
}