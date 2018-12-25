using System;
using System.Collections.Generic;
using System.Text;

namespace OOP.Models
{
    class OrderItem : EntityBase
    {
        public string Product { get; }
        public int Quantity { get; set; }
        public int PurchasePrice { get; set; }

        public OrderItem()
        {
        }

        public OrderItem(Product productName)
        {
            Product = productName.Name;
        }

        public override void DisplayEntityInfo()
        {
            Console.WriteLine($"product name - {Product}");
        }

        public new bool Validate()
        {
            var isValid = true;
            if (string.IsNullOrWhiteSpace(Product)) isValid = false;
            return isValid;
        }
    }
}
