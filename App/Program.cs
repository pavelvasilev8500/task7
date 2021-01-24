using System;
using System.Collections;
using System.Collections.Generic;

namespace App
{
    class Program
    {
        static void Main(string[] args)
        {
            var shop = new Shop();
            shop.ShopProductsList();
            Console.WriteLine("");
            shop.User();
            Console.WriteLine("");
            shop.Pay();
        }
    }
}
