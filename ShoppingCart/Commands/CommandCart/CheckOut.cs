using ShoppingCart.Product;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCart.Commands.CommandCart
{
    public class CheckOut
    {
        public void Check_Out(List<CartItemFileds>cartItems, int br, List<ProductFields> productFields) 
        {
            double sum=0;
           
            foreach(CartItemFileds item in cartItems)
            {
                int ProductId = item.PRODUCT_ID;
                ProductFields product= productFields.Find(p=>p.Id==ProductId);
                sum += item.QUANTITY*product.PRICE;
                product.QUANTITY -= item.QUANTITY;
            }
            Console.WriteLine(sum);
            cartItems.Clear();
        }
    }
}
