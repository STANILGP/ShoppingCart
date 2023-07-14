using ShoppingCart.Product;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCart.Commands.CommandProduct
{
    public class EditProduct : ProductFields
    {
        public EditProduct(int id, string article_Name, string desciption, double price, int available_Quantity) : base(id, article_Name, desciption, price, available_Quantity)
        {
        }
    }
}
