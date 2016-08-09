﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Excep
{
    public class CartProduct
    {

        #region Fields

        private int id;
        private string name;
        private decimal price;
        private int amount;
        private decimal totalprice;

        #endregion

        #region Proporties

        public int Id { get { return this.id; } set { this.id = value; } }
        public string Name { get { return this.name; } set { this.name = value; } }
        public decimal Price { get { return this.price; } set { this.price = value; } }
        public int Amount { get { return this.amount; } set { this.amount = value; } }
        public decimal Totalprice { get { return this.totalprice; } set { this.totalprice = value; } }

        #endregion

        #region Constructors

	    public CartProduct()
	    {
		    //
		    // TODO: Add constructor logic here
		    //
	    }

        // Overload nedenfor

        public CartProduct(int id, string name, decimal price, int amount)
        {
            this.id = id;
            this.name = name;
            this.price = price;
            this.amount = amount;
            this.totalprice = this.price * this.amount;
        }

        #endregion

        #region Methods



        #endregion
    }
}