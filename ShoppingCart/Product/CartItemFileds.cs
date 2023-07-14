using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCart.Product
{
    public class CartItemFileds
    {
        protected int ID;
        protected int ProductID;
        protected int Quantity;

        public CartItemFileds(int iD, int PRODUCT_ID, int QUANTITY)
        {
            ID = iD;
            ProductID = PRODUCT_ID;
            Quantity = QUANTITY;
        }
        public int Id
        {
            get { return ID; }
            set { ID = value; }
        }
        public int PRODUCT_ID
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
