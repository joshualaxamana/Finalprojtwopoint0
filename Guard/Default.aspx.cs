using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

public partial class Guard_Default : System.Web.UI.Page
{
    SqlConnection con = new SqlConnection(Helper.GetConnection());
    protected void Page_Load(object sender, EventArgs e)
    {
        getBlueforms();
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

    protected void btnSearch_Click(object sender, EventArgs e)
    {
        getBlueforms(txtKeyword.Text);
    }

    void getBlueforms()
    {
        con.Open();
        SqlCommand cmd = new SqlCommand();
        cmd.Connection = con;
        cmd.CommandText = @"SELECT b.blueformID, b.IDNumber, s.Lastname+', '+s.Firstname AS Name, 
                    b.purpose, b.item, b.details, b.serialno, b.campus, b.datefiled, b.periodcovered, 
                    st.status, g.Lastname+', '+g.Firstname As GuardName FROM BlueForm b 
                    INNER JOIN Student s ON s.IDNumber=b.Idnumber INNER JOIN statusType st ON b.status=st.statusID
                    LEFT JOIN Guard g ON g.guardID=b.guardID";
        SqlDataAdapter da = new SqlDataAdapter(cmd);
        DataSet ds = new DataSet();
        da.Fill(ds, "blueform");
        lvBlueform.DataSource = ds;
        lvBlueform.DataBind();
        con.Close();
    }

    void getBlueforms(string keyword)
    {
        con.Open();
        SqlCommand cmd = new SqlCommand();
        cmd.Connection = con;
        cmd.CommandText = @"SELECT b.blueformID, b.IDNumber, s.Lastname+', '+s.Firstname AS Name, 
                        b.purpose, b.item, b.details, b.serialno, b.campus, b.datefiled, b.periodcovered, 
                        b.status, g.Lastname+', '+g.Firstname As GuardName FROM BlueForm b 
                        INNER JOIN Student s ON s.IDNumber=b.Idnumber
                        LEFT JOIN Guard g ON g.guardID=b.guardID
                        INNER JOIN StatusType st ON b.status=st.statusID
                WHERE s.Lastname LIKE @keyword OR s.Firstname LIKE @keyword OR b.IDNumber LIKE @keyword OR g.Lastname LIKE @keyword OR g.Firstname LIKE @keyword";
        cmd.Parameters.AddWithValue("@keyword", keyword);
        SqlDataAdapter da = new SqlDataAdapter(cmd);
        DataSet ds = new DataSet();
        da.Fill(ds, "blueform");
        lvBlueform.DataSource = ds;
        lvBlueform.DataBind();
        con.Close();
    }
}