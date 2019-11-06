using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

public partial class Student_Default : System.Web.UI.Page
{
    SqlConnection con = new SqlConnection(Helper.GetConnection());
    protected void Page_Load(object sender, EventArgs e)
    {
        GetName();
        getBlueforms();
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

    void getBlueforms()
    {
        con.Open();
        SqlCommand cmd = new SqlCommand();
        cmd.Connection = con;
        cmd.CommandText = @"SELECT b.blueformID, 
                    b.purpose, b.item, b.details, b.serialno, b.campus, b.datefiled, b.periodcovered, 
                    st.status, g.Lastname+', '+g.Firstname As GuardName FROM BlueForm b 
                    INNER JOIN statusType st ON b.status=st.statusID
                    LEFT JOIN Guard g ON g.guardID=b.guardID WHERE IDnumber=@idnum";
        cmd.Parameters.AddWithValue("@idnum", Model.IDNumber);
        SqlDataAdapter da = new SqlDataAdapter(cmd);
        DataSet ds = new DataSet();
        da.Fill(ds, "blueform");
        lvBlueForm.DataSource = ds;
        lvBlueForm.DataBind();
        con.Close();
    }



    

    
}