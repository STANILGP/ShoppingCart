﻿using ShoppingCart.Product;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCart.Commands.CommandProduct
{
    public class ListProduct : ProductFields
    {
        public ListProduct(int id, string article_Name, string desciption, double price, int available_Quantity) : base(id, article_Name, desciption, price, available_Quantity)
        {
            ID = id;
            Article_Name = article_Name;
            Desciption = desciption;
            Price = price;
            Available_Quantity = available_Quantity;
        }
        public void List_Product(List<ProductFields> products, int count)
        {
            for (int i = 0; i < count; i++)
            {
                Console.WriteLine(products[i]);
            }
        }
    }
}
