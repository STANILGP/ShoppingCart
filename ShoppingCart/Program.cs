using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using ShoppingCart.Commands.CommandProduct;
using ShoppingCart.Product;
using ShoppingCart.Functions;

namespace ShoppingCart
{
    public class Program
    {

        static void Main(string[] args)
        {
            int br = 0;
           string filename = "Product.txt";
            List<ProductFields> products = new List<ProductFields>();
            string? Command;
            do
            {
                Console.WriteLine("Use command \"help\" to see all commands.");
                Console.Write("Write Command:");
      
                Command = Console.ReadLine();
                InputSplit inputSplit = new InputSplit();
                string[] productPreformance = inputSplit.Split_Input(Command);
                string command = productPreformance[0];
                
                if (command == "help")
                {
                    //TODO:
                }
                else if (command == "login")
                {
                    //TODO:
                }
                else if (command == "addProduct")
                {
                    string Name = productPreformance[1];
                    string Description = productPreformance[2];
                    double Price = double.Parse(productPreformance[3]);
                    int Quantity = int.Parse(productPreformance[4]);
                    using (StreamWriter writer = new StreamWriter(filename))
                    {
                        AddProduct addProduct;
                        writer.WriteLine(addProduct = new AddProduct(br, Name, Description, Price, Quantity));
                    }
                    br++;
                }
                else if (command == "removeProduct")
                {//no work
                    using (StreamWriter writer = new StreamWriter(filename))
                    {
                        int id = int.Parse(productPreformance[1]);
                        RemoveProduct removeProduct = new RemoveProduct();
                        bool removeP =  removeProduct.Remove_Product(products, id);
                        if (removeP==true)
                        {
                            Console.WriteLine("Product is removed");
                        }
                        else
                        {
                            Console.WriteLine("Product is not found");
                        }
                    }
                }
                else if (command == "editProduct")
                {
                    //TODO:
                }
                else if (command == "listProduct")
                {
                    using (StreamReader reader = new StreamReader(filename))
                    {
                        string line;
                        while ((line = reader.ReadLine()) != null)
                        {
                            Console.WriteLine(line);
                        }
                    }
                }
                else if (command == "searchProduct")
                {
                    //TODO:
                }
                else if (command == "addCartItem")
                {
                    //TODO:
                }
                else if (command == "removeCartItem")
                {
                    //TODO:
                }
                else if (command == "updateCartItem")
                {
                    //TODO:
                }
                else if (command == "checkout")
                {
                    //TODO:
                }
                else if (command != "help" || command != "login" || command != "addProduct" || command != "removeProduct"
                     || command != "editProduct" || command != "listProduct" || command != "searchProduct"
                    || command != "addCartItem" || command != "removeCartItem" || command != "updateCartItem" || command != "checkout")
                {
                    Console.WriteLine("This command does not exist");
                }
            }
            while (Command != "exit");

        }
    }
        
    
}
