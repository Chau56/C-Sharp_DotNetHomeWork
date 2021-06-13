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
    public partial class Form2 : Form
    {
        int quantity = 0;
        List<OrderDetails> list = null;
        Item item = Form1.Items[0];
        OrderDetails Detail { get; set; }

        public Form2()
        {
            InitializeComponent();



        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == null) return;
            quantity = Int32.Parse(textBox1.Text);
            if (quantity == 0) return;
            OrderDetails orderDetail;
            if (list == null)
            {
                if ((orderDetail = Form1.SelectedOrder.DetailsList.Find(d => d.TheItem.ItemName == item.ItemName)) != null)
                    orderDetail.ItemCounts += quantity;
                else
                    Form1.SelectedOrder.AddItem(new OrderDetails(item, quantity));
            }
            else
            {
                if ((orderDetail = list.Find(d => d.TheItem.ItemName == item.ItemName)) != null)
                    orderDetail.ItemCounts += quantity;
                else
                    list.Add(new OrderDetails(item, quantity));
            }
        }
    }
}
