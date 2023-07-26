using ShoppingCart.Product;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCart.Commands.CommandApp
{
    class LoggigFun
    {
        public void Loggig_Fun(string type,List<string>logs,string role,List<string>c) 
        {
            string filename = "Log.txt";
            using (StreamWriter writer = new StreamWriter(filename))
            {
                
                foreach (string log in logs)
                {
                    if (type == "Error" && log.Contains("Error"))
                    {
                        
                        writer.WriteLine($"{log} , {role} ");
                        writer.WriteLine();

                    }
                    else if(type == "Warning" && (log.Contains("Warning") || log.Contains("Error"))) 
                    {
                        writer.WriteLine($"{log} , {role} ");
                        writer.WriteLine();
                    }
                   
                }
                if (type == "Info")
                {
                    foreach (string log in logs)
                    {
                            writer.WriteLine($"{log} , {role}");
                            writer.WriteLine();
                    }
                    foreach (string com in c)
                    {
                        writer.WriteLine($"Info , {com} , {role}");
                        writer.WriteLine();
                    }
                }
                else if (type == "Debug")
                {
                    writer.WriteLine($"Start loggig()");
                    foreach (string log in logs)
                    {
                       
                        writer.WriteLine($"{log} , {role}");
                        writer.WriteLine();

                    }
                    foreach (string com in c)
                    {
                        writer.WriteLine($"Info , {com} , {role}");
                        writer.WriteLine();
                    }
                    writer.WriteLine($"Exiting loggig()");
                }
            }
        }
    }
}
