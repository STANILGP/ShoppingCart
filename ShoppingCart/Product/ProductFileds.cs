using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCart.Product
{
    public class ProductFields
    {
        protected int ID;
        protected string Article_Name;
        protected string Desciption;
        protected double Price;
        protected int Available_Quantity;

        public ProductFields(int id, string article_Name, string desciption, double price, int available_Quantity)
        {
            ID = id;
            Article_Name = article_Name;
            Desciption = desciption;
            Price = price;
            Available_Quantity = available_Quantity;
        }
        public int Id
        {
            get { return ID; }
            set { ID = value; }
        }
        public string Article_NAME
        {
            get { return Article_Name; }
            set { Article_Name = value; }
        }
        public string DESCOPTION
        {
            get { return Desciption; }
            set { Desciption = value; }
        }
        public double PRICE
        {
            get { return Price; }
            set { Price = value; }
        }
        public int QUANTITY
        {
            get { return Available_Quantity; }
            set { Available_Quantity = value; }
        }
        public override string ToString()
        {
            return $"ID:{ID} Name:{Article_Name} Descoption:{Desciption} Price:{Price} Quantity:{Available_Quantity}";
        }
    }
}
