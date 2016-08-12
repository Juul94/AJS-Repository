using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Excep;

public partial class Success : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Request.UrlReferrer == null)
        {
            Response.Redirect("Default.aspx");
        }

        else if (Request.UrlReferrer.AbsolutePath != "/CheckOut.aspx")
        {
            Response.Redirect("Default.aspx");
        }
    }
}