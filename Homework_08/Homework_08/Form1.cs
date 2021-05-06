using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Homework_08
{
    public partial class Form1 : Form
    {
        OrderService orderService = new OrderService();
        List<Customer> customers = new List<Customer>();
        List<Order> orders = new List<Order>();
        int FunctionCode;
        private static List<Item> items = new List<Item>();
        private static Order selectedOrder;
        internal static Order SelectedOrder { get => selectedOrder; set => selectedOrder = value; }
        internal static List<Item> Items { get => items; set => items = value; }

        public Form1()
        {
            InitializeComponent();
            

            OrderDetails detail1 = new OrderDetails(new Item("clothes", 001, 100), 1);
            OrderDetails detail2 = new OrderDetails(new Item("pen", 002, 5), 10);
            OrderDetails detail3 = new OrderDetails(new Item("cake", 003, 15.5), 2);

            List<OrderDetails> list1 = new List<OrderDetails>() { detail1 };
            List<OrderDetails> list2 = new List<OrderDetails>() { detail2 };
            List<OrderDetails> list3 = new List<OrderDetails>() { detail1, detail3 };
            List<OrderDetails> list4 = new List<OrderDetails>() { detail1, detail2, detail3 };
            
            orderService.AddOrder(new Order(list1, new Customer("Lee", "广州")));
            orderService.AddOrder(new Order(list2, new Customer("Juile", "武汉")));
            orderService.AddOrder(new Order(list3, new Customer("Mike", "北京")));
            orderService.AddOrder(new Order(list3, new Customer("Chau", "汕头")));
            orderService.AddOrder(new Order(list4, new Customer("Salar", "重庆")));

            bdsOrders.DataSource = orders;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.CurrentRow.DataBoundItem == null)
            {
                SelectedOrder = null;
                bdsDetails.DataSource = new List<OrderDetails>();
            }
            else
            {
                SelectedOrder = (Order)dataGridView1.CurrentRow.DataBoundItem;
                bdsDetails.DataSource = SelectedOrder.DetailsList;
            }
            bdsDetails.ResetBindings(true);
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                orders.Remove((Order)dataGridView1.CurrentRow.DataBoundItem);
                bdsOrders.ResetBindings(true);
                bdsDetails.DataSource = new List<OrderDetails>();
                bdsDetails.ResetBindings(true);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            new Form2().ShowDialog();
            bdsOrders.ResetBindings(true);
            bdsDetails.ResetBindings(true);
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            bdsOrders.DataSource = orderService.Enquery(cbxField, txtInput.Text);
            bdsOrders.ResetBindings(true);
        }

        private void cbxField_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cbxField.SelectedItem.ToString())
            {
                case "Order Number": FunctionCode = 0; break;
                case "Customer": FunctionCode = 1; break;
                case "Item": FunctionCode = 2; break;
                default: break;
            }
        }
    }
}
