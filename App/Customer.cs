using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace App
{
    class UserInfo
    {
        public string UserName { get; set; }
        public int UserMoney { get; set; }
        public UserInfo(string username, int usermoney)
        {
            UserName = username;
            UserMoney = usermoney;
        }
    }

    class UserProductList
    {
        public string Product { get; set; }

        public UserProductList(string product)
        {
            Product = product;
        }
    }

    class Customer
    {
        public void User()
        {
            int i = 0;
            List<UserInfo> userInfo = new List<UserInfo>();
            userInfo.Add(new UserInfo("User", 80));
            List<UserProductList> userProducts = new List<UserProductList>();
            userProducts.Add(new UserProductList("milk"));
            userProducts.Add(new UserProductList("water"));
            userProducts.Add(new UserProductList("potato"));
            userProducts.Add(new UserProductList("cheese"));
            foreach(UserInfo info in userInfo) 
            {
                Console.WriteLine($"Name: {info.UserName}\nMoney: {info.UserMoney}");
            }
            foreach(UserProductList productList in userProducts)
            {
                i++;
                Console.WriteLine($"Product {i}: {productList.Product}");
            }
        }

        public int UM()
        {
            var user = new UserInfo("User", 80);
            return user.UserMoney;
        }
    }
}
