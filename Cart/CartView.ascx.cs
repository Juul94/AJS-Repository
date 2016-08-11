using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Excep;


public partial class CartView : System.Web.UI.UserControl
{

    public Cart cart;

    protected void Page_Load(object sender, EventArgs e)
    {
        cart = new Cart();

        if (!IsPostBack)
        {
            Refresh();
        }
    }

    public void Refresh()
    {
        cart = new Cart();
        Repeater_CartView.DataSource = cart.Items;
        Repeater_CartView.DataBind();
    }
    protected void Repeater_CartView_ItemCommand(object source, RepeaterCommandEventArgs e)
    {
        int id = Convert.ToInt32(e.CommandArgument);

        if(e.CommandName == "plus")
        {
            cart.addAmountOnProduct(id, 1);
        }

        else if (e.CommandName == "minus")
        {
            cart.reduceAmountOnProduct(id, 1);
        }

        else if (e.CommandName == "delete")
        {
            cart.removeProduct(id);
        }

        Refresh();
    }
    protected void Button_EmptyCart_Click(object sender, EventArgs e)
    {
        cart.removeallProducts();
        Refresh();
    }
}