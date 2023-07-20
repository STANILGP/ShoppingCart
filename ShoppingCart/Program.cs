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
        //Ctrl+C
        //Quantity
        //Checks
        static void Main(string[] args)
        {
            Login login = new Login();
            string role=login.LoginRole();
            string filename = "Product.txt";//Text Fail
            ReadFromFile read = new ReadFromFile(filename);
            List<ProductFields> products = new List<ProductFields>();//List for product
            List<CartItemFileds>cartItems = new List<CartItemFileds>();//List for Items in cart
            int Items = cartItems.Count();// Count Items
            int br = products.Count();//Count Product
            Welcome welcome=new Welcome();
            Input input= new Input();
            input.Input_All(filename,products,cartItems,role,br,Items);
            SaveInFile saveInFile = new SaveInFile(filename, products, cartItems);
        }
    }
}
