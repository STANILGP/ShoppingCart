using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCart.Messager.Warnings
{
    class YouMustBeAdmin
    {
        public string You_Must_Be_Admin()
        {
            Console.WriteLine("You must be Admin for this command!");
            string Massenger = "Warning";
            return Massenger;
        }
        public override string ToString()
        {

            return "You must be Admin for this command!";
        }
    }
}
