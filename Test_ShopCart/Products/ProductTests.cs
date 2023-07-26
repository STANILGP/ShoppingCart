using ShoppingCart.Product;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_ShopCart.Products
{
    public class ProductTests
    {
        private ProductFields product;
        [SetUp]
        public void Setup()
        {
            product = new ProductFields();
            {
                product.Id = 1;
                product.Article_NAME = "Test";
                product.PRICE = 1;
                product.DESCRIPTION = "Test for product";
                product.QUANTITY = 2;
            };
        }
        [Test]
        public void CheckInvalidId()
        {
            int invalidId = -1;
            Assert.Throws<ArgumentException>(() => product.PRICE = invalidId);
        }
        [Test]
        public void CheckInvalidProductName()
        {
            string invalidName = "Apple@";
            Assert.Throws<ArgumentException>(() => product.Article_NAME = invalidName);
        }
        [Test]
        public void CheckInvalidPrice()
        {
            int invalidPrice = -1;
            Assert.Throws<ArgumentException>(() => product.PRICE = invalidPrice);
        }
        [Test]
        public void CheckInvalidQuantity()
        {
            int invalidQuantity = -10000;
            Assert.Throws<ArgumentException>(() => product.QUANTITY = invalidQuantity);
        }
        [Test]
        public void CheckInvalidDescription()
        {
            string invalidDes = "asdfghjklasdfghjklasasdfghjklaasdfghjklasadfghjklaasdfghjkllk";
            Assert.Throws<ArgumentException>(() => product.DESCRIPTION = invalidDes);
        }
    }
}
