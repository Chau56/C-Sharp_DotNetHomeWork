using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_08
{
    // 货物类
    class Item
    {
        // 商品名称、编号、价格
        public string ItemName { get; set; }
        public int ItemId { get; set; }
        public double ItemPrice { get; set; }

        // 构造方法
        public Item() { }
        public Item(string name, int id, double price)
        {
            ItemName = name;
            ItemId = id;
            ItemPrice = price;
        }

        // 添加ToString方法，用来显示订单信息
        public override string ToString()
        {
            return $"{nameof(ItemName)}: {ItemName}, {nameof(ItemId)}: {ItemId}, {nameof(ItemPrice)}: {ItemPrice}";
        }
    }
}
