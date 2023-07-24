using ShoppingCart.Product;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCart.Commands.CommandProduct
{
    public class RemoveProduct
    {
        public void Remove_Product(List<ProductFields> products, int id)
        {
            ProductFields removeproduct = products.Find(p => p.Id == id);
            if (removeproduct != null)
            {
                products.Remove(removeproduct);
                Console.WriteLine("Product is removed.");
            }
            else
            {
                Console.WriteLine("Product is not found.");
            }
        }
    }
}
