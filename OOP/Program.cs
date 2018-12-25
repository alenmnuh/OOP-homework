using System;
using System.Collections.Generic;
using System.Text;

namespace OOP.Models
{
    class Program
    {
        static void Main(string[] args)
        {
            var address1 = new Address(1);
            address1.City = "Poltava";
            address1.Country = "Ukraine";

            var customer1 = new Customer(1, "Andrii");
            customer1.LastName = "Kononenko";

            var product1 = new Product(1, "Product1");
            product1.Description = "Description1";
            product1.CurrentPrice = 14;

            DateTime date1 = new DateTime(2008, 6, 1);
            var order1 = new Order(customer1, date1, "AdressOrder1");

            OrderItem orderItem1 = new OrderItem(product1);

            // Сокрытие методов
            address1.DisplayEntityInfo();
            customer1.DisplayEntityInfo();
            product1.DisplayEntityInfo();
            order1.DisplayEntityInfo();
            orderItem1.DisplayEntityInfo();
            Console.ReadLine();
        }
    }
}
