using System;
using System.Collections.Generic;
using System.Text;

namespace Homework_06
{
    // 客户类
    class Customer
    {
        // 客户姓名、地址
        public string Name { get; set; }
        public string Address { get; set; }

        // 构造方法
        public Customer() { }
        public Customer(string Name,string Address)
        {
            this.Name = Name;
            this.Address = Address;
        }

        // 重写
        private bool Equals(Customer Cust)
        {
            return Name == Cust.Name && Address == Cust.Address;
        }
        public override int GetHashCode()
        {
            return HashCode.Combine(Name, Address);
        }

        // 添加ToString方法，用来显示订单信息
        public override string ToString()
        {
            return $"{nameof(Name)}:{Name},{nameof(Address)}:{Address}";
        }

        
    }
}
