using System;
using System.Collections.Generic;
using System.Text;

namespace Homework_06
{
    // 订单明细类
    class OrderDetails
    {
        // 对应的商品、数量
        public Item TheItem { get; set; }
        public int ItemCounts { get; set; }

        // 构造方法
        public OrderDetails() { }
        public OrderDetails(Item item, int counts)
        {
            TheItem = item;
            ItemCounts = counts;
        }

        // 重写Equals方法，确保每个订单的订单明细不重复
        public override bool Equals(object obj)
        {
            return obj is OrderDetails details &&
                   EqualityComparer<Item>.Default.Equals(TheItem, details.TheItem) &&
                   ItemCounts == details.ItemCounts;
        }
        public override int GetHashCode()
        {
            return HashCode.Combine(TheItem, ItemCounts);
        }

        // 添加ToString方法，用来显示订单信息
        public override string ToString()
        {
            return $"{nameof(Item)}: {TheItem}, {nameof(ItemCounts)}: {ItemCounts}";
        }
    }
}
