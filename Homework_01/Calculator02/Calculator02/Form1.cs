using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator02
{
    public partial class Calculator : Form
    {
        public Calculator()
        {
            InitializeComponent();
            equals.Text = "  =  ";
            deal.Text = "计算";
            introduce.Text = "简易计算器：\r\n在两个文本框中输入数字，在组合框中选择运算符，点计算按钮后显示出计算结果";
            Operator.Items.Add("+");
            Operator.Items.Add("-");
            Operator.Items.Add("*");
            Operator.Items.Add("/");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void deal_Click(object sender, EventArgs e)
        {
            float a, b, c;
            a = Convert.ToSingle(First.Text);
            b = Convert.ToSingle(Second.Text);
            if (Operator.Text == "+")
                result.Text = (a + b).ToString();
            else if (Operator.Text == "-")
                result.Text = (a - b).ToString();
            else if (Operator.Text == "*")
                result.Text = (a * b).ToString();
            else
                result.Text = (a / b).ToString();
        }

        private void textBox1_TextChanged_2(object sender, EventArgs e)
        {

        }


        private void introduce_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
