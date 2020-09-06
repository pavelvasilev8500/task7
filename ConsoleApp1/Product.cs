using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Product
    {
        public string it;
        public string it1;
        public int co;
        public int co1;

        public void Water()
        {
            var item = "Water";
            var cost = 11;
            var product = new Products
            {
                Item = item,
                Cost = cost
            };
            it = item;
            co = cost;
        }

        public void Milk()
        {
            var item1 = "Milk";
            var cost1 = 14;
            var product1 = new Products
            {
                Item = item1,
                Cost = cost1
            };
            it1 = item1;
            co1 = cost1;
        }
    }
}
