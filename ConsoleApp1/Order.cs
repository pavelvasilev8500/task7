using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApp1
{
    class Order
    {
        Customer c = new Customer();
        Product p = new Product();

        public int pay = 0;
        public int a = 1;

        public void Paid()
        {
            p.Water();
            p.Milk();
            c.Client();
            if (String.Equals(c.ord, p.it))
            {
                pay = pay + p.co;
                Console.WriteLine($"Order:\n Item: {p.it}\n Cost: {p.co}");
                if (c.cash >= pay)
                {
                    Console.WriteLine(" Status: Paid");
                }
                else
                {
                    Console.WriteLine(" Status: Unpaid");
                }
            }
            else
            {
                Console.WriteLine("False");
            }
            }
        }
}
