using System;
using System.Collections.Generic;
using System.Text;

namespace OOP.Models
{
    public class Product : EntityBase
    {
        public Product()
            : this(0, string.Empty)
        {
        }
        public Product(int productId, string name)
        {
            base.Id = productId;
            base.Name = name;
        }

        public string ProductName { get; set; }
        public string Description { get; set; }
        public int CurrentPrice { get; set; }

        public override void DisplayEntityInfo()
        {
            Console.WriteLine($"Product Id - {base.Id}, product name - {base.Name}");
        }

        public new bool Validate()
        {
            var isValid = true;
            if (string.IsNullOrWhiteSpace(Description)) isValid = false;
            if (CurrentPrice < 0) isValid = false;
            return isValid;
        }
    }
}
