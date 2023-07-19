using ShoppingCart.Product;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCart.Commands.CommandCart
{
    public class UpdateCartItem
    {
        public void Update_Item(List<CartItemFileds> item, int id)
        {
            CartItemFileds editProduct = item.Find(p => p.Id == id);
            Console.WriteLine(editProduct.ToString());
            Console.WriteLine("New Quantity: ");
            int newQuantity = int.Parse(Console.ReadLine());
            editProduct.QUANTITY = newQuantity;
        }
    }
}
