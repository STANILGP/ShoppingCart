using ShoppingCart.Commands.CommandCart;
using ShoppingCart.Product;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_ShopCart.CommandCart
{
    [TestFixture]
    public class RemoveCartItemTests
    {
        [Test]
        public void Remove_CartItem_ExistingItem_RemovesItem()
        {
            List<CartItemFileds> cartItems = new List<CartItemFileds>
            {
                new CartItemFileds(1, 123, 5),
                new CartItemFileds(2, 456, 2),
                new CartItemFileds(3, 789, 3)
            };
            int itemIdToRemove = 2;
           
            RemoveCartItem removeCartItem = new RemoveCartItem();
            removeCartItem.Remove_CartItem(cartItems, itemIdToRemove);

            Assert.AreEqual(2, cartItems.Count);
            Assert.IsNull(cartItems.Find(p => p.Id == itemIdToRemove));
        }

        [Test]
        public void Remove_CartItem_NonExistingItem_ItemNotFound()
        {
            List<CartItemFileds> cartItems = new List<CartItemFileds>
            {
                new CartItemFileds(1, 123, 5),
                new CartItemFileds(2, 456, 2),
                new CartItemFileds(3, 789, 3)
            };
            int nonExistingItemId = 4;

            RemoveCartItem removeCartItem = new RemoveCartItem();
            removeCartItem.Remove_CartItem(cartItems, nonExistingItemId);

            Assert.AreEqual(3, cartItems.Count);
        }
    }
}
