﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Homework_05
{
    // 订单服务类:添加订单、删除订单、修改订单、查询订单（按照订单号、商品名称、客户、订单金额等进行查询）功能
    // Add order, delete order, modify order, query order
    class OrderService
    {
        // 订单数据可以保存在一个List中
        private List<Order> OrderList = new List<Order>() { };
        public List<Order> GetOrderList { get => OrderList; }


        // 添加订单
        public void AddOrder(Order order)
        {
            if (order == null)
            {
                throw new NullReferenceException("该订单为空!");
            }

            // 在订单添加失败时，能够产生异常并显示给客户错误信息
            if (OrderList.Exists(o => Equals(o, order)))
                throw new Exception("该订单已存在，请不要重复添加!");

            OrderList.Add(order);
        }

        // 删除订单
        public void RemoveOrder(int theID)
        {
            bool tag = false;
            Order target = null;
            foreach(Order temp in OrderList)           
                if (temp.OrderID == theID) {
                    target = temp;
                    tag = true;
                }

            // 在订单删除失败时，能够产生异常并显示给客户错误信息
            if (tag)
                OrderList.Remove(target);
            else
                throw new Exception("Incorrect Order Number! ");
        }
        public void RemoveOrder(string theName)
        {
            bool tag = false;
            Order target = null;
            foreach (Order temp in OrderList)
                if (temp.OrderCust.Name == theName)
                {
                    target = temp;
                    tag = true;
                }

            // 在订单删除失败时，能够产生异常并显示给客户错误信息
            if (tag)
                OrderList.Remove(target);
            else
                throw new Exception("Order(s) from the Customer Not Found! ");
        }

        // 查询订单
        // 使用LINQ语言实现各种查询功能，查询结果按照订单总金额排序返回
        public List<Order> Enquery(int functioncode)
        {
            switch (functioncode)
            {
                case 0:     // 按照订单号查询
                    string s1 = Console.ReadLine();
                    var numberQuery = OrderList.Where(o => o.OrderID.ToString().Contains(s1)).OrderBy(o => o.Sum);
                    return numberQuery.ToList();
                case 1:     // 按照商品名称查询
                    string s2 = Console.ReadLine();
                    var itemNameQuery = OrderList.Where(o => {
                        foreach (OrderDetails details in o.DetailsList)
                            if (details.TheItem.ItemName.Contains(s2)) return true;
                        return false;
                    }).OrderBy(o => o.Sum);
                    return itemNameQuery.ToList();
                case 2:     // 按照客户查询
                    string s3 = Console.ReadLine();
                    var customerNameQuery = OrderList.Where(o => o.OrderCust.Name == s3).OrderBy(o => o.Sum);
                    return customerNameQuery.ToList();
                default:
                    return null;
            }
        }

        // 提供排序方法对保存的订单进行排序。默认按照订单号排序，也可以使用Lambda表达式进行自定义排序
        public void Sort()
        {
            OrderList.Sort((o1, o2) => o1.OrderID - o2.OrderID);
        }
        public void SortBySum()
        {
            OrderList.Sort((o1, o2) => (int)(o1.Sum - o2.Sum));
        }
    }
}