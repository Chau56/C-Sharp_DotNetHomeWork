using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Homework_07
{
    public partial class CayleyTree : Form
    {
        public CayleyTree()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(graphics==null)
            {
                graphics = this.CreateGraphics();
            }
            drawCayleyTree(10, 200, 310, 100, -Math.PI / 2);
        }

        private Graphics graphics;
        double th1 = 30 * Math.PI / 180;    //右分支角度
        double th2 = 20 * Math.PI / 180;    //左分支角度
        double per1 = 0.6;                  //右分支长度比
        double per2 = 0.7;                  //左分支长度比

        Dictionary<int, Pen> pairs = new Dictionary<int, Pen>()
        {{0,Pens.Black },{ 1,Pens.Blue} ,{ 2,Pens.Red},{ 3,Pens.Green},{4,Pens.Orange } };
        private object numericUpDown1;
        private object numericUpDown2;
        private object panel2;

        void drawCayleyTree(int n,double x0,double y0,double leng,double th)        //n是递归深度，leng是主干长度
        {
            if (n == 0) return;

            double x1 = x0 + leng * Math.Cos(th);
            double y1 = y0 + leng * Math.Sin(th);

            drawLine(x0, y0, x1, y1);

            drawCayleyTree(n - 1, x1, y1, per1 * leng, th + th1);
            drawCayleyTree(n - 1, x1, y1, per2 * leng, th - th2);
        }

        void drawLine(double x0,double y0,double x1,double y1)
        {
            graphics.DrawLine(Pens.Blue, (int)x0, (int)y0, (int)x1, (int)y1);
        }

        private void label1_Click(object sender, EventArgs e)
        {
            if (graphics == null)
            {
                graphics = panel2.CreateGraphics();
            }
            graphics.Clear(BackColor);
            DrawCayleyTree((int)numericUpDown1.Value, 200, 310, (double)numericUpDown2.Value, -Math.PI / 2);
        }

        private void DrawCayleyTree(int value1, int v1, int v2, double value2, double v3)
        {
            throw new NotImplementedException();
        }

        private void splitter1_SplitterMoved(object sender, SplitterEventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void numericUpDown3_ValueChanged(object sender, EventArgs e)
        {
            per1 = (double)numberUpDown3.Value;
        }

        private void numericUpDown4_ValueChanged(object sender, EventArgs e)
        {
            per2 = (double)numberUpDown4.Value;
        }

        private void numericUpDown5_ValueChanged(object sender, EventArgs e)
        {
            th1 = ((int)numberUpDown5.Value) * Math.PI / 180;
        }

        private void numericUpDown6_ValueChanged(object sender, EventArgs e)
        {
            th2 = ((int)numberUpDown6.Value) * Math.PI / 180;
        }
    }
}
