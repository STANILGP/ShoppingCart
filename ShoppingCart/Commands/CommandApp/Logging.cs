using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCart.Commands.CommandApp
{
    internal class Logging
    {
        public string LoginMessager()
        {
            string LogLevel;
            bool a = false;
            do
            {
                Console.WriteLine("Log level: Error/Warnings/Info/Debug");
                LogLevel = Console.ReadLine();
                if (LogLevel == "Error")
                {
                    LogLevel = "Error";
                    a = true;
                }
                else if (LogLevel == "Warnings")
                {
                    LogLevel = "Warnings";
                    a = true;
                }
                else if (LogLevel == "Info")
                {
                    LogLevel = "Info";
                    a = true;
                }
                else if (LogLevel == "Debug")
                {
                    LogLevel = "Debug";
                    a = true;
                }
                else
                {
                    Console.WriteLine("Error");
                }
            }
            while (a != true);

            return LogLevel;
        }
    }
}
