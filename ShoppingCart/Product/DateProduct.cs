using ShoppingCart.Commands.CommandProduct;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCart.Product
{
    public class DateProduct : AddProduct
    {
        List<ProductFields> products;

        public DateProduct(int id, string article_Name, string desciption, double price, int available_Quantity) : base(id, article_Name, desciption, price, available_Quantity)
        {
            products = new List<ProductFields>();
        }
    }
}
