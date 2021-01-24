using System;
using System.Collections.Generic;
using System.Text;

namespace App
{
    class Shop
    {
        public void ShopProductsList()
        {
            List<Products> shopproducts = new List<Products>();
            Console.WriteLine("Products in shop:");
            shopproducts.Add(new Products("milk", 15));
            shopproducts.Add(new Products("water", 10));
            shopproducts.Add(new Products("potato", 20));
            shopproducts.Add(new Products("cheese", 10));
            foreach (Products shopproduct in shopproducts)
            {
                Console.WriteLine($"Product: {shopproduct.Product}\nCost: {shopproduct.Cost}");
            }
        }
        public void User()
        {
            var customer = new Customer();
            customer.User();
        }
        public void Pay()
        {
            var order = new Order();
            order.Status();
        }
    }
}
