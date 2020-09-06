using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Shop
    {
        Order o = new Order();
        Product p = new Product();

        public void shop()
        {
            p.Water();
            p.Milk();

            Console.WriteLine("Products:");
            Console.WriteLine($"|Item: {p.it}\n" + $"|Cost: {p.co}\n");
            Console.WriteLine($"|Item: {p.it1}\n" + $"|Cost: {p.co1}\n");

            o.Paid();
        }
    }
}
