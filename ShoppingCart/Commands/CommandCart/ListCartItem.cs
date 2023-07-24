using ShoppingCart.Product;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCart.Commands.CommandCart
{
    public class ListCartItem
    {
        public void List_CartItem(List<CartItemFileds> cartItems)
        {
            foreach (CartItemFileds item in cartItems)
            {
                Console.WriteLine(item);
            }
        }
    }
}
