using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

public partial class Guard_Details : System.Web.UI.Page
{
    SqlConnection con = new SqlConnection(Helper.GetConnection());
    protected void Page_Load(object sender, EventArgs e)
    {
        getGuard();
        if (Request.QueryString["ID"] != null)
        {
            int blueformID = 0;
            bool validblueform = int.TryParse(Request.QueryString["ID"].ToString(), out blueformID);

            if (validblueform)
            {
                if (!IsPostBack)
                {
                    getForm(int.Parse(Request.QueryString["ID"].ToString()));
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

    protected void btnUpdate_Click(object sender, EventArgs e)
    {
        con.Open();
        SqlCommand cmd = new SqlCommand();
        cmd.Connection = con;
        cmd.CommandText = @"UPDATE Blueform SET status=@status, guardID=@guardID WHERE blueformID=@blueformID";
        cmd.Parameters.AddWithValue("@status", 2);
        cmd.Parameters.AddWithValue("@guardID", Model.IDNumber);
        cmd.Parameters.AddWithValue("@blueformID", ltBlueform.Text);
        cmd.ExecuteNonQuery();
        con.Close();
        Response.Redirect("Default.aspx");
    }
    void getForm(int BFID)
    {
        con.Open();
        SqlCommand cmd = new SqlCommand();
        cmd.Connection = con;
        cmd.CommandText = @"SELECT blueformID, IDNumber, purpose, item, 
                        details, serialno, campus, datefiled, periodcovered FROM BlueForm WHERE blueformID=@blueformID";
        cmd.Parameters.AddWithValue("@blueformID", BFID);
        SqlDataReader dr = cmd.ExecuteReader();
        if (dr.HasRows)
        {
            while (dr.Read())
            {
                ltBlueform.Text = BFID.ToString();
                txtIDNo.Text = dr["IDnumber"].ToString();
                txtPurpose.Text = dr["purpose"].ToString();
                txtItem.Text = dr["item"].ToString();
                txtDetails.Text = dr["details"].ToString();
                txtserial.Text = dr["serialno"].ToString();
                txtCampus.Text = dr["campus"].ToString();
                txtDate.Text = dr["datefiled"].ToString();
                txtPeriod.Text = dr["periodcovered"].ToString();
            }
        }

        con.Close();
    }

    void getGuard()
    {
        con.Open();
        SqlCommand cmd = new SqlCommand();
        cmd.Connection = con;
        cmd.CommandText = @"SELECT Firstname+' '+Lastname AS name FROM Guard WHERE guardID=@guardID";
        cmd.Parameters.AddWithValue("@guardID", Model.IDNumber);
        SqlDataReader dr = cmd.ExecuteReader();
        if (dr.HasRows)
        {
            while (dr.Read())
            {
                ltGuard.Text = dr["name"].ToString();
            }
        }
        con.Close();
    }
}