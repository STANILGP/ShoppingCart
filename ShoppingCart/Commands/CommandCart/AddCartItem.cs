using ShoppingCart.Product;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCart.Commands.CommandCart
{
    public class AddCartItem : CartItemFileds
    {
        public AddCartItem(int iD, int PRODUCT_ID, int QUANTITY) : base(iD, PRODUCT_ID, QUANTITY)
        {
            ID = iD;
            ProductID = PRODUCT_ID;
            Quantity = QUANTITY;
        }
    }
}
