using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Excep;
using System.Data.SqlClient;
using System.Configuration;


public partial class _Default : System.Web.UI.Page
{
    private Cart cart;

    protected void Page_Load(object sender, EventArgs e)
    {
        cart = new Cart();
    }

    protected void Button_submit_Click(object sender, EventArgs e)
    {

        cart.AddToCart(
            Convert.ToInt32(TextBox_id.Text),
            TextBox_name.Text,
            Convert.ToDecimal(TextBox_price.Text),
            Convert.ToInt32(TextBox_amount.Text)
        );

        CartView1.Refresh();
    }
}