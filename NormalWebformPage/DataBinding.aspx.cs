using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace NormalWebformPage
{
    public partial class DataBinding : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            // gridview
            //https://code.msdn.microsoft.com/CSASPNETGridView-5b16ce70#content
            if (!IsPostBack)
            {
               // gridview.AllowPaging = true;
               // gridview.PageSize = 1;
                gridview.AllowSorting = true;
                // Initialize the sorting expression. 
                ViewState["SortExpression"] = "personid ASC";
                BindGridView();
            }
        }

        private void BindGridView()
        {
            // Get the connection string from Web.config.  
            // When we use Using statement,  
            // we don't need to explicitly dispose the object in the code,  
            // the using statement takes care of it. 
            using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["conn"].ToString()))
            {
                // Create a DataSet object. 
                DataSet dsPerson = new DataSet();


                // Create a SELECT query. 
                string strSelectCmd = "SELECT PersonID,LastName,FirstName FROM Persons";


                // Create a SqlDataAdapter object 
                // SqlDataAdapter represents a set of data commands and a  
                // database connection that are used to fill the DataSet and  
                // update a SQL Server database.  
                SqlDataAdapter da = new SqlDataAdapter(strSelectCmd, conn);


                // Open the connection 
                conn.Open();


                // Fill the DataTable named "Person" in DataSet with the rows 
                // returned by the query.new n 
                da.Fill(dsPerson, "mydataset");


                // Get the DataView from Person DataTable. 
                DataView dvPerson = dsPerson.Tables["mydataset"].DefaultView;


                // Set the sort column and sort order. 
               dvPerson.Sort = ViewState["SortExpression"].ToString();


                // Bind the GridView control. 
                gridview.DataSource = dvPerson;
                gridview.DataBind();
            }
        }

        protected void gvPerson_RowDataBound(object sender, GridViewRowEventArgs e)
        {
            // Make sure the current GridViewRow is a data row. 
            if (e.Row.RowType == DataControlRowType.DataRow)
            {
                // Make sure the current GridViewRow is either  
                // in the normal state or an alternate row. 
                if (e.Row.RowState == DataControlRowState.Normal || e.Row.RowState == DataControlRowState.Alternate)
                {
                    // Add client-side confirmation when deleting. 
                    ((LinkButton)e.Row.Cells[1].Controls[0]).Attributes["onclick"] = "if(!confirm('Are you certain you want to delete this person ?')) return false;";
                }
            }
        }

        protected void gvPerson_Sorting(object sender, GridViewSortEventArgs e)
        {
            string[] strSortExpression = ViewState["SortExpression"].ToString().Split(' ');


            // If the sorting column is the same as the previous one,  
            // then change the sort order. 
            if (strSortExpression[0] == e.SortExpression)
            {
                if (strSortExpression[1] == "ASC")
                {
                    ViewState["SortExpression"] = e.SortExpression + " " + "DESC";
                }
                else
                {
                    ViewState["SortExpression"] = e.SortExpression + " " + "ASC";
                }
            }
            // If sorting column is another column,   
            // then specify the sort order to "Ascending". 
            else
            {
                ViewState["SortExpression"] = e.SortExpression + " " + "ASC";
            }


            // Rebind the GridView control to show sorted data. 
            BindGridView();
        }

        protected void gvPerson_RowEditing(object sender, GridViewEditEventArgs e)
        {
            // Make the GridView control into edit mode  
            // for the selected row.  
            gridview.EditIndex = e.NewEditIndex;


            // Rebind the GridView control to show data in edit mode. 
            BindGridView();


            // Hide the Add button. 
           // lbtnAdd.Visible = false;
        }

        protected void gvPerson_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            // Set the index of the new display page.  
            gridview.PageIndex = e.NewPageIndex;


            // Rebind the GridView control to  
            // show data in the new page. 
            BindGridView();
        }
        protected void gvPerson_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            // Exit edit mode. 
            gridview.EditIndex = -1;


            // Rebind the GridView control to show data in view mode. 
            BindGridView();


            // Show the Add button. 
            //lbtnAdd.Visible = true;
        }

        protected void gvPeron_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["conn"].ToString()))
            {
                // Create a command object. 
                SqlCommand cmd = new SqlCommand();


                // Assign the connection to the command. 
                cmd.Connection = conn;


                // Set the command text 
                // SQL statement or the name of the stored procedure  
                cmd.CommandText = "UPDATE Persons SET LastName = @LastName, FirstName = @FirstName WHERE PersonID = @PersonID";


                // Set the command type 
                // CommandType.Text for ordinary SQL statements;  
                // CommandType.StoredProcedure for stored procedures. 
                cmd.CommandType = CommandType.Text;


                // Get the PersonID of the selected row. 
                string strPersonID = gridview.Rows[e.RowIndex].Cells[2].Text;
                string strLastName = ((TextBox)gridview.Rows[e.RowIndex].FindControl("TextBox1")).Text;
                string strFirstName = ((TextBox)gridview.Rows[e.RowIndex].FindControl("TextBox2")).Text;


                // Append the parameters. 
                cmd.Parameters.Add("@PersonID", SqlDbType.Int).Value = strPersonID;
                cmd.Parameters.Add("@LastName", SqlDbType.NVarChar, 50).Value = strLastName;
                cmd.Parameters.Add("@FirstName", SqlDbType.NVarChar, 50).Value = strFirstName;


                // Open the connection. 
                conn.Open();


                // Execute the command. 
                cmd.ExecuteNonQuery();
            }


            // Exit edit mode. 
            gridview.EditIndex = -1;


            // Rebind the GridView control to show data after updating. 
            BindGridView();


            // Show the Add button. 
           // lbtnAdd.Visible = true;
        }

        protected void gvPerson_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["conn"].ToString()))
            {

                // Create a command object. 
                SqlCommand cmd = new SqlCommand();


                // Assign the connection to the command. 
                cmd.Connection = conn;


                // Set the command text 
                // SQL statement or the name of the stored procedure  
                cmd.CommandText = "DELETE FROM Persons WHERE PersonID = @PersonID";


                // Set the command type 
                // CommandType.Text for ordinary SQL statements;  
                // CommandType.StoredProcedure for stored procedures. 
                cmd.CommandType = CommandType.Text;


                // Get the PersonID of the selected row. 
                string strPersonID = gridview.Rows[e.RowIndex].Cells[2].Text;


                // Append the parameter. 
                cmd.Parameters.Add("@PersonID", SqlDbType.Int).Value = strPersonID;


                // Open the connection. 
                conn.Open();


                // Execute the command. 
                cmd.ExecuteNonQuery();
            }


            // Rebind the GridView control to show data after deleting. 
            BindGridView();
        }
    }
}