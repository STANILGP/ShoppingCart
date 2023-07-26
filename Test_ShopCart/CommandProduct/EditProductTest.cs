using NUnit.Framework;
using ShoppingCart.Commands.CommandProduct;
using ShoppingCart.Product;
using System;
using System.Collections.Generic;
using System.IO;

namespace ShoppingCart.Tests
{
    [TestFixture]
    public class EditProductTests
    {
        
        [Test]
        public void Edit_Product_WithAdminRole_ChangeDescription()
        {
          
            List<ProductFields> products = new List<ProductFields>
            {
                new ProductFields(1, "Product", "Description1", 19.99, 100)
            };
            int productId = 1;
            string role = "Admin";

            using (StringReader sr = new StringReader("Description\nNew Product Description\n"))
            {
                Console.SetIn(sr);

             
                EditProduct editProduct = new EditProduct();
                editProduct.Edit_Product(products, productId, role);

               
                Assert.AreEqual("New Product Description", products[0].DESCRIPTION);
            }
        }
    }
}
