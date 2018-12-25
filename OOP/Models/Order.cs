using System;
using System.Collections.Generic;
using System.Text;

namespace OOP.Models
{
    public class Order : EntityBase
    {
        public string CustomerName { get; set; }
        public DateTime OrderDate { get; }
        public string ShippingAdress { get; set; }

        public Order()           
        {
        }
        public Order(Customer customerName, DateTime orderDate, string shippingAdress)
        {
            CustomerName = customerName.Name;
            OrderDate = orderDate;
            ShippingAdress = shippingAdress;
        }

        public override void DisplayEntityInfo()
        {
            Console.WriteLine($"Customer Name - {CustomerName}, order date - {OrderDate.Date.ToString("d")}, Shipping Adress - {ShippingAdress}");
        }

        public new bool Validate()
        {
            var isValid = true;
            if (string.IsNullOrWhiteSpace(ShippingAdress)) isValid = false;
            return isValid;
        }
    }
}
