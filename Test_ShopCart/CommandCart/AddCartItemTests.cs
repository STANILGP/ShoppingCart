using ShoppingCart.Commands.CommandCart;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_ShopCart.CommandCart
{
    [TestFixture]
    public class AddCartItemTests
    {
        [Test]
        public void AddCartItem_Constructor_InitializesFieldsCorrectly()
        {
            int id = 1;
            int productId = 123;
            int quantity = 5;

            AddCartItem addCartItem = new AddCartItem(id, productId, quantity);

            Assert.AreEqual(id, addCartItem.Id);
            Assert.AreEqual(productId, addCartItem.PRODUCT_ID);
            Assert.AreEqual(quantity, addCartItem.QUANTITY);
        }
    }
}
