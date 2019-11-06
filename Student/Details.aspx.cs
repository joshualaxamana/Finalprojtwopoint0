using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

public partial class Student_Details : System.Web.UI.Page
{
    SqlConnection con = new SqlConnection(Helper.GetConnection());
    protected void Page_Load(object sender, EventArgs e)
    {
        GetName();
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
    void GetName()
    {
        con.Open();
        SqlCommand cmd = new SqlCommand();
        cmd.Connection = con;
        cmd.CommandText = @"SELECT Firstname+' '+Lastname AS name FROM Student WHERE IDnumber=@StudentID";
        cmd.Parameters.AddWithValue("@StudentID", Model.IDNumber);
        SqlDataReader dr = cmd.ExecuteReader();
        if (dr.HasRows)
        {
            while (dr.Read())
            {
                ltStudent.Text = dr["name"].ToString();
            }
        }
        con.Close();
    }

    void getForm(int BFID)
    {
        con.Open();
        SqlCommand cmd = new SqlCommand();
        cmd.Connection = con;
        cmd.CommandText = @"SELECT blueformID, IDNumber, purpose, item, 
                        details, serialno, campus, datefiled, periodcovered, st.status AS status, g.LAstname+', '+g.Firstname AS Gname FROM BlueForm b INNER JOIN StatusType st ON b.status=st.statusID LEFT JOIN Guard g ON b.GuardID=g.GuardID WHERE blueformID=@blueformID";
        cmd.Parameters.AddWithValue("@blueformID", BFID);
        SqlDataReader dr = cmd.ExecuteReader();
        if (dr.HasRows)
        {
            while (dr.Read())
            {
                txtName.Text = ltStudent.Text;
                ltBlueform.Text = BFID.ToString();
                txtID.Text = dr["IDnumber"].ToString();
                txtPurpose.Text = dr["purpose"].ToString();
                txtItem.Text = dr["item"].ToString();
                txtDetails.Text = dr["details"].ToString();
                txtSerialNo.Text = dr["serialno"].ToString();
                txtCampus.Text = dr["campus"].ToString();
                txtDate.Text = dr["datefiled"].ToString();
                txtPC.Text = dr["periodcovered"].ToString();
                txtStatus.Text = dr["status"].ToString();
                txtGID.Text = dr["Gname"].ToString();
            }
        }

        con.Close();
        
    }
}