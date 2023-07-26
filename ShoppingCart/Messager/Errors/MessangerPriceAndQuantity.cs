using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCart.Messager.Errors
{
    class MessangerPriceAndQuantity
    {
        public string Messanger_Price_And_Quantity()
        {
            Console.WriteLine("Price and Quantity cant be a negative numbers!");
            string Massenger = "Error";
            return Massenger;
        }
        public override string ToString()
        {

            return "Price and Quantity cant be a negative numbers!";
        }
    }
}
