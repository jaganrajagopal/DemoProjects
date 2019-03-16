using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace NormalWebformPage
{
    public partial class Repeater : System.Web.UI.Page
    {
        //SqlConnection con;
        SqlCommand cmd = new SqlCommand();
        protected void Page_Load(object sender, EventArgs e)
        {
            SqlConnection  con = new SqlConnection(ConfigurationManager.ConnectionStrings["conn"].ConnectionString);
            cmd.Connection = con;
            cmd.CommandText = "select * from dbo.persons";
            con.Open();
            repeaterGrid.DataSource = cmd.ExecuteReader();
            repeaterGrid.DataBind();
            con.Close();
        }

     
    }
}