using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

public partial class BlueForm_Delete : System.Web.UI.Page
{
    SqlConnection con = new SqlConnection(Helper.GetConnection());
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Request.QueryString["ID"] != null)
        {
            int StudentID = 0;
            bool validstudent = int.TryParse(Request.QueryString["ID"].ToString(), out StudentID);

            if (validstudent)
            {
                if (!IsPostBack)
                {
                    DeleteRecord(int.Parse(Request.QueryString["ID"].ToString()));
                }
            }
            else
            {
                Response.Redirect("Default.aspx");
            }

        }
        else
        {
            Response.Redirect("Default.aspx");
        }
    }
    void DeleteRecord(int ID)
    {
        con.Open();
        SqlCommand cmd = new SqlCommand();
        cmd.Connection = con;
        cmd.CommandText = @"DELETE FROM Blueform WHERE blueformID=@BlueformID";
        cmd.Parameters.AddWithValue("@BlueFormID", ID);
        cmd.ExecuteNonQuery();
        con.Close();
        Response.Redirect("Default.aspx");
    }
}

