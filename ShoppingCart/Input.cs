using ShoppingCart.Commands.CommandApp;
using ShoppingCart.Commands.CommandCart;
using ShoppingCart.Commands.CommandProduct;
using ShoppingCart.Functions;
using ShoppingCart.Messager.Errors;
using ShoppingCart.Messager.Warnings;
using ShoppingCart.Product;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace ShoppingCart
{
    public class Input 
    {
        public void Input_All(string filename, List<ProductFields> products, List<CartItemFileds> cartItems, string role, int br, int Items,TextWriter output = null)
        {
            void WriteLine(string message) => (output ?? Console.Out).WriteLine(message);
            string? Command; 
            List<string> logs = new List<string>();
            List<string>c= new List<string>();
            List<string>msg= new List<string>();
            List<string>log_msg = new List<string>();
            do
            {
              
                Console.Write("Write Command:");
                Command = Console.ReadLine();
                InputSplit inputSplit = new InputSplit();
                string[] productPreformance = inputSplit.Split_Input(Command);
                string command = productPreformance[0];
                c.Add(command); 
                if (command == "help")
                {
                    Help help = new Help();
                    help.Help_Commands();
                }

                else if (command == "addProduct")
                {
                    if (role == "Admin")
                    {
                        if (productPreformance.Length < 6 || productPreformance.Length > 6)
                        {
                            IncorectSyntax messanger = new IncorectSyntax();
                            logs.Add(messanger.Incorect_Syntax());
                            msg.Add(messanger.ToString());
                        }
                        else
                        {
                            string Name = productPreformance[1];
                            string Description = productPreformance[2];
                            double Price = double.Parse(productPreformance[3]);
                            int Quantity = int.Parse(productPreformance[4]);
                            if (Name == null || Description == null || Price == 0 || Quantity == 0)
                            {
                                MessagerMissingArgument messanger = new MessagerMissingArgument();
                                logs.Add(messanger.Messager_Missing_Argument());
                                msg.Add(messanger.ToString());
                            }
                            else if (Quantity < 0 || Price < 0)
                            {
                                MessangerPriceAndQuantity messanger = new MessangerPriceAndQuantity();
                                logs.Add(messanger.Messanger_Price_And_Quantity());
                                msg.Add(messanger.ToString());
                            }


                            else
                            {
                                AddProduct addProduct;
                                addProduct = new AddProduct(br, Name, Description, Price, Quantity);
                                products.Add(addProduct);
                                br++;
                            }
                        }
                    }
                    else
                    {
                        YouMustBeAdmin messanger = new YouMustBeAdmin();
                        logs.Add(messanger.You_Must_Be_Admin());
                        msg.Add(messanger.ToString());
                    }
                }

                else if (command == "removeProduct")
                {
                    if (role == "Admin")
                    {
                        int id = int.Parse(productPreformance[1]);
                        if (id == null)
                        {
                            MissingID messanger = new MissingID();
                            
                            logs.Add(messanger.Missing_ID());
                            msg.Add(messanger.ToString());
                        }
                        else
                        {
                            RemoveProduct removeProduct = new RemoveProduct();
                            removeProduct.Remove_Product(products, id);
                        }
                    }
                    else
                    {
                        YouMustBeAdmin messanger = new YouMustBeAdmin();
                        msg.Add(messanger.ToString());
                        logs.Add(messanger.You_Must_Be_Admin());
                    }
                }

                else if (command == "editProduct")
                {
                    int EditId = int.Parse(productPreformance[1]);
                    if (EditId == null)
                    {
                        MissingID messanger = new MissingID();
                        logs.Add(messanger.Missing_ID());
                        msg.Add(messanger.ToString());
                    }
                    else
                    {
                        EditProduct editProduct = new EditProduct();
                        editProduct.Edit_Product(products, EditId, role);
                    }

                }

                else if (command == "loggig")
                { 
                    Logging logging = new Logging();
                    string type = logging.LoginMessager();
                    LoggigFun loggigFun = new LoggigFun();
                    for (int i = 0; i < logs.Count; i++)
                    {
                        log_msg.Add($"{logs[i]}  {msg[i]}");
                    }
                    loggigFun.Loggig_Fun(type, log_msg, role,c);
                }

                else if (command == "listProduct")
                {
                    ListProduct listProduct = new ListProduct();
                    listProduct.List_Product(products);
                }

                else if (command == "searchProduct")
                {
                    string searchName = productPreformance[1];
                    if (searchName == null)
                    {
                        MessagerMissingArgument messanger = new MessagerMissingArgument();
                        msg.Add(messanger.ToString());
                        logs.Add(messanger.Messager_Missing_Argument());
                    }
                    else
                    {
                        SearchProduct searchProduct = new SearchProduct();
                        searchProduct.Search_Product(products, searchName);
                    }

                }

                else if (command == "addCartItem")
                {
                    if (role == "Client")
                    {
                        Console.WriteLine(productPreformance.Length);
                        if (productPreformance.Length < 3 || productPreformance.Length > 3)
                        {
                            IncorectSyntax messanger = new IncorectSyntax();
                            logs.Add(messanger.Incorect_Syntax());
                            msg.Add(messanger.ToString());
                        }
                        else
                        {
                            int IdProduct = int.Parse(productPreformance[1]);
                            ProductFields fields = products.Find(p => p.Id == IdProduct);
                            int Quantity = int.Parse(productPreformance[2]);
                            if (IdProduct == null)
                            {
                                MissingID messanger = new MissingID();
                                msg.Add(messanger.ToString());
                                logs.Add(messanger.Missing_ID());
                            }
                            else if (Quantity == null)
                            {
                                MessagerMissingArgument messanger = new MessagerMissingArgument();
                                msg.Add(messanger.ToString());
                                logs.Add(messanger.Messager_Missing_Argument());
                            }
                            if (fields != null)
                            {
                                AddCartItem addCart;
                                addCart = new AddCartItem(Items, IdProduct, Quantity);
                                cartItems.Add(addCart);
                                Items++;
                            }
                            else
                            {
                                DontHaveProduct messanger = new DontHaveProduct();
                                msg.Add(messanger.ToString());
                                logs.Add(messanger.Dont_Have_Product());
                            }
                        }
                    }
                    else
                    {
                        YouMustBeClient messanger = new YouMustBeClient();
                        msg.Add(messanger.ToString());
                        logs.Add(messanger.You_Must_Be_Client());
                    }
                }

                else if (command == "removeCartItem")
                {
                    if (role == "Client")
                    {
                        int id = int.Parse(productPreformance[1]);
                        if (id == null)
                        {
                            MissingID messanger = new MissingID();
                            msg.Add(messanger.ToString());
                            logs.Add(messanger.Missing_ID());
                        }
                        else
                        {
                            RemoveCartItem removeItem = new RemoveCartItem();
                            removeItem.Remove_CartItem(cartItems, id);
                        }
                    }
                    else
                    {
                        YouMustBeClient messanger = new YouMustBeClient();
                        msg.Add(messanger.ToString());
                        logs.Add(messanger.You_Must_Be_Client());
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
                        YouMustBeClient messanger = new YouMustBeClient();
                        msg.Add(messanger.ToString());
                        logs.Add(messanger.You_Must_Be_Client());
                    }
                }

                else if (command == "updateCartItem")
                {
                    if (role == "Client")
                    {
                        int UpdateId = int.Parse(productPreformance[1]);
                        if (UpdateId == null)
                        {
                            MissingID messanger = new MissingID();
                            msg.Add(messanger.ToString());
                            logs.Add(messanger.Missing_ID());
                        }
                        else
                        {
                            UpdateCartItem update = new UpdateCartItem();
                            update.Update_Item(cartItems, UpdateId);
                        }

                    }
                    else
                    {
                        YouMustBeClient messanger = new YouMustBeClient();                   
                        logs.Add(messanger.You_Must_Be_Client());
                        msg.Add(messanger.ToString());
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
                        YouMustBeClient messanger = new YouMustBeClient();
                        logs.Add(messanger.You_Must_Be_Client());
                        msg.Add(messanger.ToString());
                    }
                }

                else if (command == "exit")
                {

                }
                else
                {
                    ErrorCommand messanger = new ErrorCommand();
                    logs.Add(messanger.Error_Command());
                    msg.Add(messanger.ToString());
                }
            }
            while (Command != "exit");
        }
    }
}
