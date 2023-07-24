using ShoppingCart.Product;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCart.Commands.CommandCart
{
    public class RemoveCartItem 
    {
        public void Remove_CartItem(List<CartItemFileds> cartItems, int id)
        {
            CartItemFileds removeItem = cartItems.Find(p => p.Id == id);
            if (removeItem != null)
            {
                cartItems.Remove(removeItem);
                Console.WriteLine("Item is removed.");
            }
            else
            {
                Console.WriteLine("Item is not found.");
            }
        }
    }
}
