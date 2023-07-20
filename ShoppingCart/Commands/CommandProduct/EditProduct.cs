using ShoppingCart.Product;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCart.Commands.CommandProduct
{
    public class EditProduct
    {
        public void Edit_Product(List<ProductFields> products,int id)
        {
            ProductFields editProduct = products.Find(p => p.Id == id);
            Console.WriteLine(editProduct.ToString());
            Console.WriteLine("Name/Description/Price/Quantity");
            Console.WriteLine("What you will edit?");
            string editcom=Console.ReadLine();

            if (editcom == "Name")
            {
                    Console.WriteLine("New Name:");
                    string editName=Console.ReadLine();
                    editProduct.Article_NAME=editName;
            }

            else if (editcom == "Description")
            {
                Console.WriteLine("New Description:");
                string editDiscription = Console.ReadLine();
                editProduct.DESCRIPTION = editDiscription;
            }

            else if (editcom == "Price")
            {
                Console.WriteLine("New Price:");
                double editPrice = double.Parse(Console.ReadLine());
                editProduct.PRICE = editPrice;
            }

            else if (editcom == "Quantity")
            {
                Console.WriteLine("New Quantity:");
                int editQuantity = int.Parse(Console.ReadLine());
                editProduct.QUANTITY = editQuantity;
            }

            else 
            { 
                Console.WriteLine("Error"); 
            }
        }
    }
}
