using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCart.Messager.Warnings
{
    class MessagerMissingArgument
    {
        public string Messager_Missing_Argument()
        {
            Console.WriteLine("Missing argument");
            string Massenger = "Warning";
            return Massenger;
        }
        public override string ToString()
        {

            return "Missing argument";
        }
    }
}
