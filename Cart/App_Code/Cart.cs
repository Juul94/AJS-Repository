﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Excep;


namespace Excep
{
    [Serializable]

    public class Cart
    {

        #region Construntor

            public Cart()
            {
                
                this.items = GrabCart();
            }

        #endregion

        #region method

            public List<CartProduct> Items { get { return this.items; } }

            public List<CartProduct> items;

            private List<CartProduct> GrabCart()
            {
                List<CartProduct> cart = new List<CartProduct>();

                if (HttpContext.Current.Session["Cart"] == null)
                {
                    HttpContext.Current.Session.Add("Cart", cart);
                }

                cart = (List<CartProduct>)HttpContext.Current.Session["Cart"];

                return cart;
            }

            public void AddToCart(int id, string name, decimal price, int amount)
            {
                CartProduct product = findProduct(id);
                
                if(product.Id != 0)
                {
                    product.Amount += amount;
                }

                else
                {
                    this.items.Add(new CartProduct(id, name, price, amount));
                }
            }

            public void SetAmountOnProduct(int id, int newAmount)

            {
                CartProduct item = findProduct(id);
                item.Amount = newAmount;
            }

            public void addAmountOnProduct(int id, int amountToAdd)
            {
                CartProduct item = findProduct(id);
                item.Amount += amountToAdd;
            }

            public void reduceAmountOnProduct(int id, int amountToReduce)
            {
                CartProduct item = findProduct(id);
                item.Amount -= amountToReduce;
            }

            public CartProduct findProduct(int id)
            {
                foreach (CartProduct product in this.items)
                {
                    if (product.Id == id)
                    {
                        return product;
                    }
                }

                return new CartProduct();
            }

            public void removeProduct(int id)
            {
                CartProduct item = findProduct(id);

                if(item.Id != 0)
                {
                    this.items.Remove(item);
                }
            }

            public void removeallProducts()
            {
                if(HttpContext.Current.Session["Cart"] != null)
                {
                    HttpContext.Current.Session.Remove("Cart");
                }
                
                this.items = new List<CartProduct>();
            }


         #endregion
    }
}
