using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HomeWork_07
{
    public partial class CayleyTree : Form
    {
        public CayleyTree()
        {
            InitializeComponent();
        }

        private Graphics graphics;
        double th = -Math.PI / 2;

        int n = 10;                         //递归深度
        int leng = 100;                     //主干长度
        double th1 = 30 * Math.PI / 180;    //右分支角度
        double th2 = 20 * Math.PI / 180;    //左分支角度
        double per1 = 0.6;                  //右分支长度比
        double per2 = 0.7;                  //左分支长度比
        Pen pen = Pens.Red;                 //画笔颜色

        void drawCayleyTree(int n, double x0, double y0, double leng, double th,
            double th1, double th2, double per1, double per2, Pen pen) 
        {
            if (n == 0) return;

            double x1 = x0 + leng * Math.Cos(th);
            double y1 = y0 + leng * Math.Sin(th);

            drawLine(x0, y0, x1, y1);

            drawCayleyTree(n - 1, x1, y1, per1 * leng, th + th1, th1, th2, per1, per2, pen);
            drawCayleyTree(n - 1, x1, y1, per2 * leng, th - th2, th1, th2, per1, per2, pen);
        }

        private void btn_Draw_Click(object sender, EventArgs e)
        {
            if (graphics == null)
            {
                graphics = this.CreateGraphics();
            }

            n = int.Parse(textBox_n.Text);
            leng = int.Parse(textBox_leng.Text);
            per1 = double.Parse(textBox_per1.Text);
            per2 = double.Parse(textBox_per2.Text);
            th1 = double.Parse(textBox_th1.Text);
            th2 = double.Parse(textBox_th2.Text);

            if(radioButton1.Checked)
            {
                pen = Pens.Blue;
            }
            else if (radioButton2.Checked)
            {
                pen = Pens.Red;
            }
            else if (radioButton3.Checked)
            {
                pen = Pens.Green;
            }

            drawCayleyTree(n, 400, 310, leng, th, th1, th2, per1, per2, pen);
        }


        void drawLine(double x0, double y0, double x1, double y1)
        {
            graphics.DrawLine(pen, (int)x0, (int)y0, (int)x1, (int)y1);
        }




        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        
    }
}
