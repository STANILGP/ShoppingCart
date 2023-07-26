using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCart.Messager.Errors
{
    class ErrorCommand
    {
        public string Error_Command()
        {
            Console.WriteLine("Wrong command");
            string type = "Error";
            return type;
        }
        public override string ToString()
        {

            return "Wrong command";
        }
    }
}
