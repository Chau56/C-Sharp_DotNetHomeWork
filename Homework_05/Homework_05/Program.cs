using System;
using System.Collections.Generic;

namespace Homework_05
{
    class Program
    {
        static void Main(string[] args)
        {
            // 调用OrderService的方法完成各种订单操作
            OrderService orderService = new OrderService();

            OrderDetails detail1 = new OrderDetails(new Item("clothes", 001, 100), 1);
            OrderDetails detail2 = new OrderDetails(new Item("pen", 002, 5), 10);
            OrderDetails detail3 = new OrderDetails(new Item("cake", 003, 15.5), 2);

            List<OrderDetails> list1 = new List<OrderDetails>() { detail1 };
            List<OrderDetails> list2 = new List<OrderDetails>() { detail2 };
            List<OrderDetails> list3 = new List<OrderDetails>() { detail1, detail3 };
            List<OrderDetails> list4 = new List<OrderDetails>() { detail1, detail2, detail3 };

            // 添加订单
            orderService.AddOrder(new Order(list1, new Customer("Lee","广州")));
            orderService.AddOrder(new Order(list2, new Customer("Juile", "武汉")));
            orderService.AddOrder(new Order(list3, new Customer("Mike", "北京")));
            orderService.AddOrder(new Order(list3, new Customer("Chau", "汕头")));
            orderService.AddOrder(new Order(list4, new Customer("Salar", "重庆")));
            Console.WriteLine("Orders added successfully! ");

            // 查询订单
            Console.WriteLine("Inquiring orders!");
            foreach (Order o in orderService.Enquery(0)) Console.WriteLine(o);
            foreach (Order o in orderService.Enquery(1)) Console.WriteLine(o);
            foreach (Order o in orderService.Enquery(2)) Console.WriteLine(o);

            // 删除订单
            Console.WriteLine("Delete and modify orders!");
            orderService.RemoveOrder(3);
            orderService.RemoveOrder("Mike");

            orderService.GetOrderList[0].AddItem(detail2);
            orderService.GetOrderList[2].RemoveItem("cake");

            foreach (Order o in orderService.GetOrderList) Console.WriteLine(o);

            Console.WriteLine("Orders sorting!");
            orderService.Sort();
            foreach (Order o in orderService.GetOrderList) Console.WriteLine(o);
            orderService.SortBySum();
            foreach (Order o in orderService.GetOrderList) Console.WriteLine(o);
        }
    }
}
