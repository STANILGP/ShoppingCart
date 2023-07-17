using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using ShoppingCart.Commands.CommandProduct;
using ShoppingCart.Product;
using ShoppingCart.Functions;
using ShoppingCart.Commands.CommandCart;
using System.Xml.Linq;

namespace ShoppingCart
{
    public class Program
    {

        static void Main(string[] args)
        {
            
           string filename = "Product.txt";
            List<ProductFields> products = new List<ProductFields>();
            List<CartItemFileds>cartItems = new List<CartItemFileds>();
            int Items = cartItems.Count();
            int br = products.Count();
            string? Command;
            do
            {
                Console.WriteLine("Use command \"help\" to see all commands.");
                Console.Write("Write Command:");
                Command = Console.ReadLine();
                InputSplit inputSplit = new InputSplit();
                string[] productPreformance = inputSplit.Split_Input(Command);
                string command = productPreformance[0];
                
                if (command == "help") //TODO:
                {

                }  //TODO:

                else if (command == "login")//TODO:
                {

                }  //TODO:

                else if (command == "addProduct")
                {
                    string Name = productPreformance[1];
                    string Description = productPreformance[2];
                    double Price = double.Parse(productPreformance[3]);
                    int Quantity = int.Parse(productPreformance[4]);
                    using (StreamWriter writer = new StreamWriter(filename))
                    {
                        Console.WriteLine("Products:");
                        AddProduct addProduct;
                        addProduct = new AddProduct(br, Name, Description, Price, Quantity);
                        products.Add(addProduct);
                        foreach (ProductFields field in products)
                        {
                            writer.WriteLine(field.ToString()); 
                        }
                    }
                    br++;
                }

                else if (command == "removeProduct")
                {
                        int id = int.Parse(productPreformance[1]);
                        RemoveProduct removeProduct = new RemoveProduct();
                        removeProduct.Remove_Product(products, id);
                    using (StreamWriter writer = new StreamWriter(filename))
                    {
                        foreach (ProductFields field in products)
                        {
                            writer.WriteLine(field.ToString());
                        }
                    }
                }

                else if (command == "editProduct")  
                {
                    int EditId = int.Parse(productPreformance[1]);
                    EditProduct editProduct = new EditProduct();
                    editProduct.Edit_Product(products, EditId);
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
                    string searchName = productPreformance[1];
                    SearchProduct searchProduct = new SearchProduct();
                    searchProduct.Search_Product(products,searchName);
                }

                else if (command == "addCartItem")  
                {
                    int IdProduct = int.Parse(productPreformance[1]);
                    products.Find(p => p.Id == IdProduct);
                    int Quantity = int.Parse(productPreformance[2]);
                    using (StreamWriter writer = new StreamWriter(filename))
                    {
                        Console.WriteLine("CartItems:");
                        AddCartItem addCart;
                        addCart = new AddCartItem(Items,IdProduct,Quantity);
                        cartItems.Add(addCart);
                    }
                    Items++;
                }

                else if (command == "removeCartItem")
                {
                    //TODO:
                }//TODO:

                else if (command == "updateCartItem")
                {
                    //TODO:
                }//TODO:

                else if (command == "checkout")
                {
                    //TODO:
                }//TODO:

                else if (command != "help" || command != "login" || command != "addProduct" || command != "removeProduct" || command != "editProduct" || command != "listProduct" || command != "searchProduct"
                    || command != "addCartItem" || command != "removeCartItem" || command != "updateCartItem" || command != "checkout")
                {
                    Console.WriteLine("This command does not exist");
                }
            }
            while (Command != "exit");

        }
    }
        
    
}
