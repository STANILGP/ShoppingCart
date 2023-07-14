using ShoppingCart.Product;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCart.Commands.CommandProduct
{
    public class RemoveProduct 
    {
        public bool Remove_Product(List<ProductFields> products,int id)
        {
            
           ProductFields ids = products.Find(x => x.Id == id);
            if (ids != null)
            {
                products.Remove(ids);
                return true;
            }
            else { return false; }
        }
    }
}
