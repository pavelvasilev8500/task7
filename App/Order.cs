using System;
using System.Collections.Generic;
using System.Text;

namespace App
{
    class Order
    {
        public int GetProduct()
        {
            var product = new Products("milk", 15);
            var product_1 = new Products("water", 10);
            var product_2 = new Products("potato", 20);
            var product_3 = new Products("cheese", 15);
            int sum = product.Cost + product_1.Cost + product_2.Cost + product_3.Cost;
            return sum;
        }
        public void GetCost()
        {
            int s = GetProduct();
            Console.WriteLine(s);
        }
        public void Status()
        {
            var customer = new Customer();
            if(GetProduct() <= customer.UM())
            {
                Console.WriteLine("Status: Pay");
            }
            else
            {
                Console.WriteLine("Status:  UnPay");
            }
        }
    }
}
