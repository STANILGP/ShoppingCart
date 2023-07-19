using ShoppingCart.Product;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCart.Commands.CommandProduct
{
    public class AddProduct : ProductFields
    {
        public AddProduct(int id, string article_Name, string description, double price, int available_Quantity) : base(id, article_Name, description, price, available_Quantity)
        {
            ID = id;
            Article_Name = article_Name;
            DESCRIPTION = description;
            Price = price;
            Available_Quantity = available_Quantity;
        }
    }
}
