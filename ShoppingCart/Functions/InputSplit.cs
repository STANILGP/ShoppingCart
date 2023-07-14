using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCart.Functions
{
    public class InputSplit
    {
        public string[] Split_Input(string input)
        {
            string[] productsPreformance=input.Split('*');

            return productsPreformance;
            
        }
    }
}
