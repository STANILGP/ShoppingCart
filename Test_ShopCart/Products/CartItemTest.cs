using ShoppingCart.Product;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_ShopCart.Products
{
    public class CartItemTest
    {
        private CartItemFileds Cart;
        [SetUp]
        public void Setup()
        {
            Cart = new CartItemFileds();
            {
                Cart.PRODUCT_ID = 1;
                Cart.QUANTITY = 2;
            };
        }

        [Test]
        public void CheckInvalidProductId()
        {
            int ProductId = -1;
            Assert.Throws<ArgumentException>(() => Cart.PRODUCT_ID = ProductId);
        }

        [Test]
        public void CheckInvalidId()
        {
            int Id = -1;
            Assert.Throws<ArgumentException>(() => Cart.Id = Id);
        }
        [Test]
        public void CheckInvalidQuantity()
        {
            int invalidQuantity = -10000;
            Assert.Throws<ArgumentException>(() => Cart.QUANTITY = invalidQuantity);
        }
    }
}
