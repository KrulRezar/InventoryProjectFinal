using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventoryProjectFinal
{
    public class InventoryItems
    {
        private static int currentID = 0;

        private string name;
        private string category;
        private int quantity;
        private double price;
        private string status;

        public int ID { get; private set; }
        public string Name
        {
            get { return name; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new InvalidExpressionException("Name cannot be empty.");
                }
                name = value;
            }
        }
        public string Category
        {
            get { return category; }
            set { category = value; }
        }
        public int Quantity
        {
            get { return quantity; }
            set
            {
                if (value <= 0)
                {
                    throw new InvalidExpressionException("Quantity must be greater than zero.");
                }
                quantity = value;
            }
        }
        public double Price
        {
            get { return price; }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Price must be positive and greater than zero.");
                }
                price = value;
            }
        }
        public string Status
        {
            get { return status; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new InvalidExpressionException("Status cannot be empty.");
                }
                status = value;
            }
        }

        public InventoryItems(string name, string category, int quantity, double price, string status)
        {
            ID = ++currentID;
            Name = name;
            Category = category;
            Quantity = quantity;
            Price = price;
            Status = status;
        }

        public InventoryItems(int id, string name, string category, int quantity, double price, string status)
        {
            ID = id;
            Name = name;
            Category = category;
            Quantity = quantity;
            Price = price;
            Status = status;
        }

        public static void SetCurrentID(int id)
        {
            currentID = id;
        }
    }
}