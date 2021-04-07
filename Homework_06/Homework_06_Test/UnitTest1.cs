using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Text;
using Homework_06;

namespace Homework_06_Test
{
    // 对订单程序中OrderService的各个Public方法添加测试用例
    [TestClass]
    public class UnitTest1
    {
        public OrderService orderService;
        public Item item1, item2, item3;
        public Customer customer1, customer2;
        public OrderDetails details1, details2, details3;
        public Order order1, order2, order3;

        [TestInitialize]
        public void initialize()
        {
            orderService = new OrderService();
            item1 = new Item("clothes", 001, 100);
            item2 = new Item("pen", 002, 5);
            item3 = new Item("cake", 003, 15.5);
            customer1 = new Customer("Chau");
            customer2 = new Customer("Juile");
            details1 = new OrderDetails(item1, 1);
            details2 = new OrderDetails(item2, 10);
            details3 = new OrderDetails(item3, 2);
            order1 = new Order(new List<OrderDetails>() { details1 }, customer1);
            order2 = new Order(new List<OrderDetails>() { details2 }, customer2);
            order3 = new Order(new List<OrderDetails>() { details3 }, customer2);
        }
        [TestMethod]
        public void AddOrderTest()
        {
            orderService.AddOrder(order1);
            orderService.AddOrder(order2);
            Assert.AreEqual(2, orderService.OrderList.Count);
        }

        [TestMethod]
        public void RemoveOrderTest()
        {
            orderService.AddOrder(order1);
            orderService.RemoveOrder("Juile");
            Assert.AreEqual(0, orderService.OrderList.Count);
        }

        [TestMethod]
        public void EnqueryTest()
        {
            orderService.AddOrder(order1);
            orderService.AddOrder(order2);
            orderService.AddOrder(order3);
            List<Order> result = orderService.Enquery(0, "1");
            Assert.IsTrue(result[0].Equals(order2));
            result = orderService.Enquery(1, "pen");
            Assert.IsTrue(result[0].Equals(order2));
            result = orderService.Enquery(1, "Chau");
            Assert.IsTrue(result[0].Equals(order3));
        }

        [TestMethod]
        public void SortTest()
        {
            orderService.AddOrder(order3);
            orderService.AddOrder(order2);
            orderService.AddOrder(order1);
            orderService.Sort();
            Assert.IsTrue(orderService.OrderList[0].Equals(order1));
        }

        [TestMethod]
        public void SortBySumTest()
        {
            orderService.AddOrder(order3);
            orderService.AddOrder(order2);
            orderService.AddOrder(order1);
            orderService.SortBySum();
            Assert.IsTrue(orderService.OrderList[0].Equals(order3));
        }

        [TestMethod]
        public void ExportTest()
        {
            orderService.AddOrder(order1);
            orderService.AddOrder(order2);
            orderService.Export();
            orderService.AddOrder(order3);
            orderService.Import();
            Assert.AreEqual(1, orderService.Enquery(2, "Rogger").Count);
        }

        [TestMethod]
        public void ImportTest()
        {
            Assert.Fail();
        }
    }
}
