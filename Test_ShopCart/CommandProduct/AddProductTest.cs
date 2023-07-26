using ShoppingCart.Commands.CommandProduct;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_ShopCart.CommandProduct
{
    [TestFixture]
    public class AddProductTest
    {
        [Test]
        public void AddProduct_Constructor_ShouldSetProperties()
        {
            int id = 1;
            string articleName = "Product1";
            string description = "Description1";
            double price = 19.99;
            int quantity = 100;

            AddProduct addProduct = new AddProduct(id, articleName, description, price, quantity);

            Assert.AreEqual(id, addProduct.Id);
            Assert.AreEqual(articleName, addProduct.Article_NAME);
            Assert.AreEqual(description, addProduct.DESCRIPTION);
            Assert.AreEqual(price, addProduct.PRICE);
            Assert.AreEqual(quantity, addProduct.QUANTITY);
        }
    }
}
