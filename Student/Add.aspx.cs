using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;


public partial class BlueForm_Add : System.Web.UI.Page
{
    SqlConnection con = new SqlConnection(Helper.GetConnection());

    protected void Page_Load(object sender, EventArgs e)
    {
        txtID.Text = Model.IDNumber;
        txtStatus.Text = "Pending";
    }

    protected void btnAdd_Click(object sender, EventArgs e)
    {
        con.Open();
        SqlCommand cmd = new SqlCommand();
        cmd.Connection = con;
        cmd.CommandText = @"INSERT INTO BlueForm VALUES (@IDNumber, @Purpose, @Item, @Details, @SerialNo,
                    @Campus, @DateFiled, @PeriodCovered, @Status, @GuardID)";
        cmd.Parameters.AddWithValue("@IDNumber", Model.IDNumber);
        cmd.Parameters.AddWithValue("@Purpose", txtPurpose.Text);
        cmd.Parameters.AddWithValue("@Item", txtItem.Text);
        cmd.Parameters.AddWithValue("@Details", txtDetails.Text);
        cmd.Parameters.AddWithValue("@SerialNo", txtSerialNo.Text);
        cmd.Parameters.AddWithValue("@Campus", txtCampus.Text);
        cmd.Parameters.AddWithValue("@DateFiled", txtDate.Text);
        cmd.Parameters.AddWithValue("@PeriodCovered", txtPC.Text);
        cmd.Parameters.AddWithValue("@Status", 1);
        cmd.Parameters.AddWithValue("@GuardID", "");
        cmd.ExecuteNonQuery();
        con.Close();
        Response.Redirect("Default.aspx");
    }
}