using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Excep;


public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        
    }
    protected void Button_submit_Click(object sender, EventArgs e)
    {
        List<CartProduct> cart = new List<CartProduct>();

        cart = GrabCart(cart);
        // eller: cart = Session["Cart"] as List<Excep.CartProduct>;

        AddToCart(cart);

        ShowCart(cart);
    }

    private void ShowCart(List<CartProduct> cart)
    {
        GridView_Cart.DataSource = cart;
        GridView_Cart.DataBind();
    }

    private void AddToCart(List<CartProduct> cart)
    {
        bool NewProduct = true;

        foreach(CartProduct product in cart)
        {
            if(product.Id == Convert.ToInt32(TextBox_id.Text))
            {
                NewProduct = false;
                product.Amount += Convert.ToInt32(TextBox_amount.Text);
                product.Totalprice = product.Amount * product.Price;
            }    
        }

        if (NewProduct)
            {
                cart.Add(new CartProduct(
                    Convert.ToInt32(TextBox_id.Text),
                    TextBox_name.Text,
                    Convert.ToDecimal(TextBox_price.Text),
                    Convert.ToInt32(TextBox_amount.Text)
                ));
            }
    }

    private List<CartProduct> GrabCart(List<CartProduct> cart)
    {
        if (Session["Cart"] == null)
        {
            Session.Add("Cart", cart);
        }

        cart = (List<CartProduct>)Session["Cart"];

        return cart;
    }
}