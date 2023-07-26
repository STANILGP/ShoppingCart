using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCart.Product
{
    public class CartItemFileds : Program
    {
        protected int ID;
        protected int ProductID;
        protected int Quantity;

        public CartItemFileds()
        {
        }

        public CartItemFileds(int iD, int PRODUCT_ID, int QUANTITY)
        {
            ID = iD;
            ProductID = PRODUCT_ID;
            Quantity = QUANTITY;
        }
        public int Id
        {
            get { return ID; }
            set {
                if (value >= 0)
                {
                    ID = value;
                }
                else
                {
                    throw new ArgumentException("Invalid id.");
                }
            }
        }
        public int PRODUCT_ID
        {
            get { return ProductID; }
            set {
                if (value >= 0)
                {
                    ProductID = value;
                }
                else
                {
                    throw new ArgumentException("Invalid product id.");
                }
            }
        }
        public int QUANTITY
        {
            get { return Quantity; }
            set {
                if (value >= 0)
                {
                    Quantity = value;
                }
                else
                {
                    throw new ArgumentException("Invalid Quantity.");
                }
            }
        }
        public override string ToString()
        {
            return $"ID:{ID} ProductID{ProductID} Quamtity:{Quantity}";
        }
    }
}
