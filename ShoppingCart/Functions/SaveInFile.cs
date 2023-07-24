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
        public SaveInFile(List<ProductFields> products)
        {
            string filename = "Product.txt";
            using (StreamWriter writer = new StreamWriter(filename))
            {
                foreach (ProductFields field in products)
                {
                    writer.WriteLine(field.ToString());
                }
                writer.WriteLine();
            }
        }
    }
}
