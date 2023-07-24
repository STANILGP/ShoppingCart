using ShoppingCart.Product;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCart.Commands.CommandProduct
{
    public class ListProduct
    {
        public void List_Product(List<ProductFields> products)
        {
            foreach (ProductFields fields in products)
            {
                Console.WriteLine(fields);
            }
        }
    }
}
