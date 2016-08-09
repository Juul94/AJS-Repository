using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        MySystem.User user = new MySystem.User("Rasmus", "Frank", "Goldmann", 3);
        //user.Username = "Rasmus";
        div_navn.InnerHtml = user.Username;

        SetLoginStatus();
    }

    private void SetLoginStatus()
    {
        if (MySystem.User.IsUser())
        {
            lbl_user.Text = "Du er logget på!";
        }
        else
        {
            lbl_user.Text = "Du er IKKE logget på!";
        }
    }
    protected void Btn_opret_Click(object sender, EventArgs e)
    {
        MySystem.User.CreateSession();
        Response.Redirect("BrugerTest.aspx");
    }
    protected void Btn_slet_Click(object sender, EventArgs e)
    {
        MySystem.User.RemoveSession();
        Response.Redirect("BrugerTest.aspx");
    }
}