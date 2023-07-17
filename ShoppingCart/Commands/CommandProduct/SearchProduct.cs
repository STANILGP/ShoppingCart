using ShoppingCart.Product;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCart.Commands.CommandProduct
{
    public class SearchProduct
    {
       
        public void Search_Product(List<ProductFields> products, string name)
        {
            ProductFields searchProduct = products.Find(p => p.Article_NAME == name);
            if (searchProduct != null)
            {
                Console.WriteLine(searchProduct.ToString());
            }
            else
            {
                Console.WriteLine("Product is not found.");
            }
        }
    }
}
