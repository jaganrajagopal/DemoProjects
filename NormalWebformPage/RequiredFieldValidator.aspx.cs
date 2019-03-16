using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace NormalWebformPage
{
    public partial class RequiredFieldValidator : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Session["username"] = "Naveen";
        }

        protected void cusCustom_ServerValidate(object sender, ServerValidateEventArgs e)
        {
            if (e.Value.Length == 8)
                e.IsValid = true;
            else
                e.IsValid = false;
        }

        protected void ClickHere(object sender, EventArgs e)
        {
            hddn.Value = "sadflsdjf";
        }
    }
}