using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ShoppingCart.Product
{
    public class ProductFields : Program
    {
        protected int ID;
        protected string Article_Name;
        protected string Description;
        protected double Price;
        protected int Available_Quantity;

        public ProductFields(int id, string article_Name, string description, double price, int available_Quantity)
        {
            ID = id;
            Article_Name = article_Name;
            Description = description;
            Price = price;
            Available_Quantity = available_Quantity;
        }
        public ProductFields()
        {
            ID = 1000;
            Article_Name = "apple";
            Description = "red";
            Price = 0.98;
            Available_Quantity = 10;
        }

        public int Id
        {
            get { return ID; }
            set
            {
                if (value >= 0)
                {
                    Price = value;
                }
                else
                {
                    throw new ArgumentException("Invalid id.");
                }
            }
        }
        public string Article_NAME
        {
            get { return Article_Name; }
            set {
                if (!string.IsNullOrWhiteSpace(value) && value.Length <= 10 && value.All(char.IsLetter))
                {
                    Article_Name = value;
                }
                else
                {
                    throw new ArgumentException("Invalid product name");
                }
            }
        }
        public string DESCRIPTION
        {
            get { return Description; }
            set 
            {
                if (value.Length <= 50)
                { 
                    Description= value;
                }
                else
                {
                    throw new ArgumentException("Invalid product description");
                }
            }
        }
        public double PRICE
        {
            get { return Price; }
            set {
                if (value >= 0)
                {
                    Price = value;
                }
                else
                {
                    throw new ArgumentException("Invalid product price.");
                }
            }
        }
        public int QUANTITY
        {
            get { return Available_Quantity; }
            set {
                if (value >= 0)
                {
                    Available_Quantity = value;
                }
                else
                {
                    throw new ArgumentException("Invalid product quantity");
                }
            }
        }
        public override string ToString()
        {

            return $"*{ID}*{Article_Name}*{Description}*{Price}*{Available_Quantity}*";
        }
    }
}
