using ShoppingCart.Commands.CommandApp;
using ShoppingCart.Commands.CommandCart;
using ShoppingCart.Commands.CommandProduct;
using ShoppingCart.Functions;
using ShoppingCart.Product;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCart
{
    public class Input
    {
        public void Input_All(string filename, List<ProductFields>products,List<CartItemFileds>cartItems,string role,int br,int Items) 
        {
                string? Command;
            do
            {
               

                Console.Write("Write Command:");
                Command = Console.ReadLine();
                InputSplit inputSplit = new InputSplit();
                string[] productPreformance = inputSplit.Split_Input(Command);
                string command = productPreformance[0];

                if (command == "help")
                {
                    Help help = new Help();
                    help.Help_Commands();
                }

                else if (command == "addProduct")
                {
                    if (role == "Admin")
                    {
                        string Name = productPreformance[1];
                        string Description = productPreformance[2];
                        double Price = double.Parse(productPreformance[3]);
                        int Quantity = int.Parse(productPreformance[4]);

                        AddProduct addProduct;
                        addProduct = new AddProduct(br, Name, Description, Price, Quantity);
                        products.Add(addProduct);

                        br++;
                    }
                    else
                    {
                        Console.WriteLine("You must be Admin for this command");
                    }
                }

                else if (command == "removeProduct")
                {
                    if (role == "Admin")
                    {
                        int id = int.Parse(productPreformance[1]);
                        RemoveProduct removeProduct = new RemoveProduct();
                        removeProduct.Remove_Product(products, id);
                    }
                    else
                    {
                        Console.WriteLine("You must be Admin for this command");
                    }
                }

                else if (command == "editProduct")
                {
                    if (role == "Admin")
                    {
                        int EditId = int.Parse(productPreformance[1]);
                        EditProduct editProduct = new EditProduct();
                        editProduct.Edit_Product(products, EditId);
                    }
                    else
                    {
                        Console.WriteLine("You must be Admin for this command");
                    }
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
                    searchProduct.Search_Product(products, searchName);
                }

                else if (command == "addCartItem")
                {
                    if (role == "Client")
                    {
                        int IdProduct = int.Parse(productPreformance[1]);
                        ProductFields fields = products.Find(p => p.Id == IdProduct);
                        int Quantity = int.Parse(productPreformance[2]);
                        if (fields != null)
                        {
                            AddCartItem addCart;
                            addCart = new AddCartItem(Items, IdProduct, Quantity);
                            cartItems.Add(addCart);
                        }
                        else
                        {
                            Console.WriteLine("Dont have product wiht this ID");
                        }
                        Items++;
                    }
                    else
                    {
                        Console.WriteLine("You must be Client for this command");
                    }
                }

                else if (command == "removeCartItem")
                {
                    if (role == "Client")
                    {
                        int id = int.Parse(productPreformance[1]);
                        RemoveCartItem removeItem = new RemoveCartItem();
                        removeItem.Remove_CartItem(cartItems, id);
                    }
                    else
                    {
                        Console.WriteLine("You must be Client for this command");
                    }
                }

                else if (command == "listCartItem")
                {
                    if (role == "Client")
                    {
                        ListCartItem listCart = new ListCartItem();
                        listCart.List_CartItem(cartItems);
                    }
                    else
                    {
                        Console.WriteLine("You must be Client for this command");
                    }
                }

                else if (command == "updateCartItem")
                {
                    if (role == "Client")
                    {
                        int UpdateId = int.Parse(productPreformance[1]);
                        UpdateCartItem update = new UpdateCartItem();
                        update.Update_Item(cartItems, UpdateId);
                    }
                    else
                    {
                        Console.WriteLine("You must be Client for this command");
                    }
                }

                else if (command == "checkout")
                {
                    if (role == "Client")
                    {
                        CheckOut checkOut = new CheckOut();
                        checkOut.Check_Out(cartItems, Items, products);
                    }
                    else
                    {
                        Console.WriteLine("You must be Client for this command");
                    }
                }

                else
                {
                    Console.WriteLine("This command does not exist");
                }
            }
            while (Command != "exit");
        }
    }
}
