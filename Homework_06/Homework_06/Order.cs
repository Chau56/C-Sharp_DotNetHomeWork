using System;
using System.Collections.Generic;
using System.Text;

namespace Homework_06
{
    // 订单类
    class Order
    {
        // 订单ID号、商品名称、客户、订单金额
        public int OrderID { get; set; }
        public Customer OrderCust { get; set; }
        public static int count = 0;
        public double sum = 0;
        public double Sum { get => sum; }

        // 具体的订单明细表 
        public List<OrderDetails> DetailsList { get; set; }

        // 构造方法
        public Order() { }
        public Order(List<OrderDetails> detailList, Customer customer)
        {
            OrderID = count++;
            DetailsList = detailList;
            OrderCust = customer;
            foreach (OrderDetails orderDetails in DetailsList)
            {
                sum += (orderDetails.TheItem.ItemPrice) * (orderDetails.ItemCounts);
            }
        }

        // 添加订单
        public void AddItem(OrderDetails details)
        {
            DetailsList.Add(details);
            sum += (details.TheItem.ItemPrice) * (details.ItemCounts);
        }

        // 删除订单
        public void RemoveItem(string theName)
        {
            bool tag = false;
            OrderDetails target = null;
            foreach (OrderDetails detail in DetailsList)
                if (detail.TheItem.ItemName == theName)
                {
                    tag = true;
                    sum -= (detail.TheItem.ItemPrice) * (detail.ItemCounts);
                    target = detail;
                }
            // 在订单删除失败时，能够产生异常并显示给客户错误信息
            if (tag)
                DetailsList.Remove(target);
            else
                throw new Exception("Incorrect detail info! ");
        }

        // 重写Equals方法，确保添加的订单不重复
        public override bool Equals(object obj)
        {
            return obj is Order order &&
                   OrderID == order.OrderID;
        }
        public override int GetHashCode()
        {
            return HashCode.Combine(OrderID);
        }

        // 添加ToString方法，用来显示订单信息
        public override string ToString()
        {
            StringBuilder s = new StringBuilder();
            s.Append("Order ID: ").Append(OrderID).Append("\n");
            s.Append("Customer name: ").Append(OrderCust).Append("\n");
            s.Append("Details: ").Append("\n");
            foreach (OrderDetails orderDetails in DetailsList)
                s.Append(orderDetails.ToString()).Append("\n");
            return s.ToString();
        }
    }
}
