using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace NormalWebformPage
{
    public partial class Instricpage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Page.IsPostBack)
            {
                //Database connection 
            }
            //if (!String.IsNullOrEmpty(txtdata.Text))
            //{
            //   // HttpServerUtility mydata = new HttpServerUtility()
               
            //   System.Web.HttpRequest mybew = new System.Web.HttpRequest("asdf","Asdf","ASdf"):
            //mybew.ServerVariables["servname"]
            ////mybew.

            // System.IO.TextWriter data = new System.IO.TextWriter();
            // System.Web.HttpResponse myresponse = new System.Web.HttpResponse();
            //myresponse.
            //    ListBox1.BackColor
            //    // Access the HttpServerUtility methods through
            //    // the intrinsic Server object.
            //    lblData.Text = "Welcome, " + Server.HtmlEncode(lblData.Text) + ". <br/> The url is " + Server.UrlEncode(Request.Url.ToString())
   //}
        }

        protected void page_preinit(object sender,EventArgs e)
        {
//            Check the IsPostBack property to determine whether this is the first time the page is being processed.
//Create or re - create dynamic controls.
//Set a master page dynamically.
//Set the Theme property dynamically.
 
        }
        protected void page_init(object sender, EventArgs e)
        {
            // ListBox1.BorderWidth.Value = 10;
            lblData.Text = "HI";
//            This event fires after each control has been initialized.
//Each control's UniqueID is set and any skin settings have been applied.
//Use this event to read or initialize control properties.
//The "Init" event is fired first for the bottom-most control in the hierarchy, and then fired up the hierarchy until it is fired for the page itself.
        }

        protected void page_Initcomplete(object sender,EventArgs e)
        {
            lblData.Text = "Page completed";
//            Until now the viewstate values are not yet loaded, hence you can use this event to make changes to the view state that you want to ensure are persisted after the next postback.
//Raised by the Page object.
//Use this event for processing tasks that require all initialization to be complete.
        }

        protected override void OnPreLoad(EventArgs e)
        {
//            Raised after the page loads view state for itself and all controls, and after it processes postback data that is included with the Request instance.
//Before the Page instance raises this event, it loads view state for itself and all controls, and then processes any postback data included with the Request instance.
//Loads ViewState: ViewState data are loaded to controls.
//Loads Postback data: Postback data are now handed to the page controls.
            base.OnPreLoad(e);

        }

        //Next to PageLoad
        //       The Page object calls the OnLoad method on the Page object, and then recursively does the same for each child control until the page and all controls are loaded.The Load event of individual controls occurs after the Load event of the page.
        //This is the first place in the page lifecycle that all values are restored.
        //Most code checks the value of IsPostBack to avoid unnecessarily resetting state.
        //You may also call Validate and check the value of IsValid in this method.
        //You can also create dynamic controls in this method.
        //Use the OnLoad event method to set properties in controls and establish database connections.

        void GreetingBtn_Click(Object sender, EventArgs e)

        {

            //code

        }


        protected override void OnPreRender(EventArgs e)
        {
            //This event is again recursively fired for each child controls in the Page. If we want to make any changes to control values, this is the last event we have to peform the same.
            //custom code
            base.OnPreRender(e);

        }

        protected override void OnSaveStateComplete(EventArgs e)
        {
            //Before this event occurs, ViewState has been saved for the page and for all controls. Any changes to the page or controls at this point will be ignored.
           // Use this event perform tasks that require view state to be saved, but that do not make any changes to controls
            //custome code
            base.OnSaveStateComplete(e);
        }

        protected override void Render(HtmlTextWriter writer)
        {
            //custom code
            //This is not an event; instead, at this stage of processing, the Page object calls this method on each control. All ASP.NET Web server controls have a Render method that writes out the control’s markup that is sent to the browser
            base.Render(writer);
        }
        protected override void OnUnload(EventArgs e)
        {
            //This event occurs for each control and then for the page. In controls, use this event to do final cleanup for specific controls, such as closing control-specific database connections.
            //custom code
            base.OnUnload(e);
        }


    }
}