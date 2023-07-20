using ShoppingCart.Product;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCart.Functions
{
    public class SaveInFile
    {
        public SaveInFile(string filename, List<ProductFields> products, List<CartItemFileds> cartItems)
        {
            using (StreamWriter writer = new StreamWriter(filename))
            {
                writer.WriteLine("Products:");
                writer.WriteLine();
                foreach (ProductFields field in products)
                {
                    writer.WriteLine(field.ToString());
                }
                writer.WriteLine();
            }
        }
    }
}
