using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace ShoppingCart.Commands.CommandApp
{
    public class Help
    {
        public void Help_Commands()
        {
            Console.WriteLine("Commands: ");
            Console.WriteLine("addProduct*{Article Name}*{Discription}*{Price}*{Quantity}* ->Add Product");
            Console.WriteLine("removeProdict*{ID}* ->Remove Product");
            Console.WriteLine("editProduct*{ID}* ->Edit Product Can change Name, Discription, Price and Quantity");
            Console.WriteLine("listProduct ->Show all Products");
            Console.WriteLine("searchProduct*{Article Name}* ->Find the Product you want");
            Console.WriteLine("addCartItem*{IDProduct}*{Quantity}* ->Add Item In Cart");
            Console.WriteLine("removeCartItem*{ID}* -> Remove Item from Cart");
            Console.WriteLine("updateCartItem*{ID}* -> Can change Qantity");
            Console.WriteLine("listCartItem ->Show items in cart");
            Console.WriteLine("checkout -> Show the account and clean cart ");
            Console.WriteLine("help -> Show all commands and how to use");
        }

    }
}
