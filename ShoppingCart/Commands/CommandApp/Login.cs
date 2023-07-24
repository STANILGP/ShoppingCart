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
            string role;
            bool a = false;
            do
            {
                Console.WriteLine("Login As Admin/Client/Employee");
                role = Console.ReadLine();
                if (role == "Client")
                {
                    role = "Client";
                    a = true;
                }
                else if (role == "Employee")
                {
                    role = "Employee";
                    a = true;
                }
                else if (role == "Admin")
                {
                    role = "Admin";
                    a = true;
                }
                else
                {
                    Console.WriteLine("Error");
                }
            }
            while (a != true);

            return role;
        }
    }
}
