using System;
using System.Collections.Generic;
using System.Text;

namespace App
{
    class Products
    {
        public string Product { get; set; }
        public int Cost { get; set; }
        public Products(string product, int cost)
        {
            Product = product;
            Cost = cost;
        }
    }
}
