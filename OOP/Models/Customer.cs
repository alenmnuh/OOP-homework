using System;
using System.Collections.Generic;
using System.Text;

namespace OOP.Models
{
    public class Customer : EntityBase
    {
        public Customer()
            : this(0, string.Empty)
        {
        }
        public Customer(int customerId, string name)
        {
            base.Id = customerId;
            base.Name = name;
            AddressList = new List<Address>();
        }
        public List<Address> AddressList { get; set; }
        public int CustomerType { get; set; }
        public static int InstanceCount { get; set; }
        public string LastName { get; set; }
        public string EmailAddress { get; set; }

        public override void DisplayEntityInfo()
        {
            Console.WriteLine($"Customer Id - {base.Id}, first name - {base.Name}, last name - {this.LastName}");
        }
        public new bool Validate()
        {
            var isValid = true;
            if (string.IsNullOrWhiteSpace(LastName)) isValid = false;
            if (string.IsNullOrWhiteSpace(EmailAddress)) isValid = false;
            return isValid;
        }
    }
}
