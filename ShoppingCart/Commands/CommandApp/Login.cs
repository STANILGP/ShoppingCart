using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCart.Commands.CommandApp
{
    public class Login
    {
         public string LoginRole() 
         {
            //while
            Console.WriteLine("Login As Admin/Client");
            string role=Console.ReadLine();
            if (role == "Client")
            {
                role = "Client";
            }
            else if (role == "Admin")
            {
                role = "Admin";
            }
            else 
            { 
                LoginRole();
            }
            return role;
         }
    }
}
