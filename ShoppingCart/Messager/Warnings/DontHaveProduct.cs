using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCart.Messager.Warnings
{
    class DontHaveProduct
    {
        public string Dont_Have_Product()
        {
            Console.WriteLine("Dont have product wiht this IDs!");
            string Massenger = "Warning";
            return Massenger;
        }
        public override string ToString()
        {

            return "Dont have product wiht this IDs!";
        }
    }
}
