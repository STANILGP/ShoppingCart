using ShoppingCart.Product;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCart.Functions
{
    public class ReadFromFile
    {
        public ReadFromFile(string filename, List<ProductFields> products)
        {
            using (StreamReader sr = new StreamReader(filename))
            {
                string line;

                while ((line = sr.ReadLine()) != "")
                {
                    string[] parts = line.Split('*');
                    int id = int.Parse(parts[1]);
                    string name = parts[2].Trim();
                    string description = parts[3].Trim(); ;
                    double price = double.Parse(parts[4].Trim());
                    int Quantity = int.Parse(parts[5].Trim());
                    products.Add(new ProductFields { Id = id, Article_NAME = name, DESCRIPTION = description, PRICE = price, QUANTITY = Quantity });
                }
            }
        }
    }
}

