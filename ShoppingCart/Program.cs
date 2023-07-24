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
using ShoppingCart.Commands.CommandApp;

namespace ShoppingCart
{
    public class Program
    {
        //UnityTest
        //Checks
        private static List<ProductFields> products = new List<ProductFields>();
        static void Main(string[] args)
        {
            Console.CancelKeyPress += CtrlCHandler;
            Login login = new Login();
            string role=login.LoginRole();
            string filename = "Product.txt";//Text Fail
            Welcome welcome = new Welcome();
            while (true)
            {
                List<CartItemFileds> cartItems = new List<CartItemFileds>();//List for Items in cart
                int Items = cartItems.Count();// Count Items
                int br = products.Count();//Count Product
                ReadFromFile read = new ReadFromFile(filename, products);
                Input input = new Input();
                input.Input_All(filename, products, cartItems, role, br, Items);
                SaveInFile saveInFile = new SaveInFile(products);
            }
        }
        static void CtrlCHandler(object? sender, ConsoleCancelEventArgs e)
        {
            SaveInFile saveInFile = new SaveInFile(products);
            Console.WriteLine();
            Console.WriteLine("Saving data before exit...");
            e.Cancel = false;
        }
    }
}
