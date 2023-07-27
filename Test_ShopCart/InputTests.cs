using ShoppingCart.Product;
using ShoppingCart;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Moq;
using ShoppingCart.Functions;

namespace Test_ShopCart
{
    [TestFixture]
    public class InputTests
    {
        [Test]
        public void Input_All_MockCommands_ExpectedBehavior()
        {
            var input = new Input();
            var mockProducts = new List<ProductFields>();
            var mockCartItems = new List<CartItemFileds>();
            var role = "Admin";
            var br = 1;
            var items = 0;

            var mockCommands = new Queue<string>();
            mockCommands.Enqueue("help");
            mockCommands.Enqueue("addProduct Product1 Desc1 10.99 50");
            mockCommands.Enqueue("addProduct Product2 Desc2 20.99 30");
            mockCommands.Enqueue("listProduct");
            mockCommands.Enqueue("removeProduct 1");
            mockCommands.Enqueue("listProduct");
            mockCommands.Enqueue("addCartItem 1 5");
            mockCommands.Enqueue("addCartItem 2 3");
            mockCommands.Enqueue("listCartItem");
            mockCommands.Enqueue("checkout");
            mockCommands.Enqueue("exit");

            var consoleOutput = new StringWriter();
            Console.SetOut(consoleOutput);

            try
            {
                using (var reader = new StringReader(string.Join(Environment.NewLine, mockCommands)))
                {
                    Console.SetIn(reader);
                    input.Input_All("filename", mockProducts, mockCartItems, role, br, items);
                }

                var consoleOutputResult = consoleOutput.ToString();
                Assert.IsFalse(consoleOutputResult.Contains("Product1"));
                Assert.IsFalse(consoleOutputResult.Contains("Product2"));
                // Add more assertions if needed
            }
            finally
            {
                Console.SetOut(new StreamWriter(Console.OpenStandardOutput()));
            }
        }
    }
}
