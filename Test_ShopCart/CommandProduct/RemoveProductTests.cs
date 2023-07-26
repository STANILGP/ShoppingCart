using ShoppingCart.Commands.CommandProduct;
using ShoppingCart.Product;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_ShopCart.CommandProduct
{
    [TestFixture]
    public class RemoveProductTests
    {
        [Test]
        public void Remove_Product_ExistingProduct_RemovesProduct()
        {
            List<ProductFields> products = new List<ProductFields>
            {
                new ProductFields(1, "Product1", "Description1", 19.99, 100),
                new ProductFields(2, "Product2", "Description2", 29.99, 50),
                new ProductFields(3, "Product3", "Description3", 9.99, 200)
            };
            int productIdToRemove = 2;

            RemoveProduct removeProduct = new RemoveProduct();
            removeProduct.Remove_Product(products, productIdToRemove);

            Assert.AreEqual(2, products.Count);
            Assert.IsNull(products.Find(p => p.Id == productIdToRemove));
        }

        [Test]
        public void Remove_Product_NonExistingProduct_DoesNotRemoveProduct()
        {
            List<ProductFields> products = new List<ProductFields>
            {
                new ProductFields(1, "Product1", "Description1", 19.99, 100),
                new ProductFields(2, "Product2", "Description2", 29.99, 50),
                new ProductFields(3, "Product3", "Description3", 9.99, 200)
            };
            int nonExistingProductId = 4;

            RemoveProduct removeProduct = new RemoveProduct();
            removeProduct.Remove_Product(products, nonExistingProductId);

            Assert.AreEqual(3, products.Count);
        }
    }
}
