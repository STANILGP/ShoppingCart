using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCart.Product
{
    public class CartItemFileds
    {
        protected string ID;
        protected string ProductID;
        protected int Quantity;

        public CartItemFileds(string iD, string PRODUCT_ID, int QUANTITY)
        {
            ID = iD;
            ProductID = PRODUCT_ID;
            Quantity = QUANTITY;
        }
        public string Id
        {
            get { return ID; }
            set { ID = value; }
        }
        public string PRODUCT_ID
        {
            get { return ProductID; }
            set { ProductID = value; }
        }
        public int QUANTITY
        {
            get { return Quantity; }
            set { Quantity = value; }
        }
        public override string ToString()
        {
            return $"ID:{ID} Product ID:{ProductID} Quantity:{Quantity}";
        }
    }
}
