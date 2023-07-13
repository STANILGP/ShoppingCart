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
        public AddProduct(int id, string article_Name, string desciption, double price, int available_Quantity) : base(id, article_Name, desciption, price, available_Quantity)
        {
            ID = id;
            Article_Name = article_Name;
            Desciption = desciption;
            Price = price;
            Available_Quantity = available_Quantity;
        }

        public void ADD_Product(List<ProductFields> products, int br)
        {
            products.Add(new ProductFields(br, Article_Name, Desciption, Price, Available_Quantity));
            br++;
        }
    }
}
