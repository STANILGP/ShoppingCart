using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCart.Messager.Warnings
{
    class MissingID
    {
        public string Missing_ID()
        {
            Console.WriteLine("Missing ID!");
            string Massenger = "Warning";
            return Massenger;
        }
        public override string ToString()
        {

            return "Missing ID!";
        }
    }
}
