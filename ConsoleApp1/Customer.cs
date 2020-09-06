using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Customer
    {
        public int cash;
        public string ord;
        public void Client()
        {
            var id = 1;
            var name = "Name";
            var surname = "Surname";
            var address = "Address";
            var phone = "Phone";
            var order = "Water";
            var money = 15;
            var customer = new Customers()
            {
                Id = id,
                Name = name,
                Surname = surname,
                Address = address,
                Phone = phone,
                Order = order,
                Money = money,
            };
            Console.WriteLine($"|Client: {id}\n\n"
                                + $"|Name: {name}\n"
                                + $"|Surname: {surname}\n"
                                + $"|Address: {address}\n"
                                + $"|Phone: {phone}\n"
                                + $"|Order: {order}\n"
                                + $"|Money: {money}\n"
                                + "\n");
            cash = money;
            ord = order;
        }
        
    }
}
