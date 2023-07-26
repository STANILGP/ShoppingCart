using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCart.Messager.Errors
{
    class IncorectSyntax
    {
        public string Incorect_Syntax()
        {
            Console.WriteLine("Incorect Syntax!");
            string Massenger = "Error";
            return Massenger;
        }
        public override string ToString()
        {

            return "Incorect Syntax!";
        }
    }
}
