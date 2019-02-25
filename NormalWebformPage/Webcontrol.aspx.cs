using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace NormalWebformPage
{
    public partial class Webcontrol : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            // BulletedList1.DataSource=
            List<string> mylist = new List<string>();
            mylist.Add("product1");
            mylist.Add("product2");
            DropDownList2.DataSource = mylist;
            DropDownList2.DataBind();
            chkProduct.DataSource = mylist;
            chkProduct.DataBind();
            Response.Write(hdnfields.Value);

        }

        protected void BulletedList1_Click(object sender, BulletedListEventArgs e)
        {

        }

        protected void BtnClick(object sender, EventArgs e)
        {
            //on Button click 
            //connected to database and binding the data
            btnButton.Text = " You clicked the button";
           // btnButton.Height = 20;
        }

        protected void ImageButton_clicked(object sender, ImageClickEventArgs e)
        {
            imgButton.AlternateText = "You have binding the image text as alternative text";

        }
    }
}