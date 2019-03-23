using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MyClassLibrary;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;
//oledb or odbc

//using System.Data.OleDb;
//using System.Data.Odbc;




namespace NormalWebformPage
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
          // btn.Text = Session["username"].ToString();
            // MyClassLibrary.Class1 obj = new 
         //   MyClassLibrary.subClassLibary.Class2 obj = new MyClassLibrary.subClassLibary.Class2();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Write("Button clicked");
        }

        protected void DataBind(object sender, EventArgs e)
        {
          

        }

        protected void bind(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["myConnectionString"].ConnectionString))
            {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "select * from emp";
                cmd.Connection = conn;
                cmd.CommandType = System.Data.CommandType.Text;
                conn.Open();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
               // SqlDataReader dr = cmd.ExecuteReader(CommandBehavior.CloseConnection);
               // int count = (int)cmd.ExecuteScalar();
                //string empid = "";
                //string empname = "";
                //while (dr.Read())
                //{
                //   empid= empid + " - "+  dr[0].ToString();
                //   empname = empname + "- " + dr[1].ToString();
                //  //  dr.nex
                //}
                DataSet ds = new DataSet();
                da.Fill(ds, "employee");
                conn.Close();
                conn.Dispose();
                GridView1.DataSource = ds.Tables["employee"];
                GridView1.DataBind();
                GridView1.Visible = true;
                //ServiceReference1. objmyservice = new ServiceReference1();
               


            }
            //ds=   cmd.ExecuteNonQuery
        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }

  
}