namespace HomeWork_07
{
    partial class CayleyTree
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.btn_Draw = new System.Windows.Forms.Button();
            this.textBox_th2 = new System.Windows.Forms.TextBox();
            this.textBox_th1 = new System.Windows.Forms.TextBox();
            this.textBox_per2 = new System.Windows.Forms.TextBox();
            this.textBox_per1 = new System.Windows.Forms.TextBox();
            this.textBox_leng = new System.Windows.Forms.TextBox();
            this.textBox_n = new System.Windows.Forms.TextBox();
            this.label_pen = new System.Windows.Forms.Label();
            this.label_th2 = new System.Windows.Forms.Label();
            this.label_th1 = new System.Windows.Forms.Label();
            this.label_per2 = new System.Windows.Forms.Label();
            this.label_per1 = new System.Windows.Forms.Label();
            this.label_leng = new System.Windows.Forms.Label();
            this.label_n = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.radioButton3);
            this.panel1.Controls.Add(this.radioButton2);
            this.panel1.Controls.Add(this.radioButton1);
            this.panel1.Controls.Add(this.btn_Draw);
            this.panel1.Controls.Add(this.textBox_th2);
            this.panel1.Controls.Add(this.textBox_th1);
            this.panel1.Controls.Add(this.textBox_per2);
            this.panel1.Controls.Add(this.textBox_per1);
            this.panel1.Controls.Add(this.textBox_leng);
            this.panel1.Controls.Add(this.textBox_n);
            this.panel1.Controls.Add(this.label_pen);
            this.panel1.Controls.Add(this.label_th2);
            this.panel1.Controls.Add(this.label_th1);
            this.panel1.Controls.Add(this.label_per2);
            this.panel1.Controls.Add(this.label_per1);
            this.panel1.Controls.Add(this.label_leng);
            this.panel1.Controls.Add(this.label_n);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(270, 450);
            this.panel1.TabIndex = 0;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(191, 351);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(58, 19);
            this.radioButton3.TabIndex = 17;
            this.radioButton3.Text = "绿色";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(191, 326);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(58, 19);
            this.radioButton2.TabIndex = 16;
            this.radioButton2.Text = "红色";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Checked = true;
            this.radioButton1.Location = new System.Drawing.Point(191, 301);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(58, 19);
            this.radioButton1.TabIndex = 15;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "蓝色";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // btn_Draw
            // 
            this.btn_Draw.Location = new System.Drawing.Point(89, 393);
            this.btn_Draw.Name = "btn_Draw";
            this.btn_Draw.Size = new System.Drawing.Size(91, 34);
            this.btn_Draw.TabIndex = 14;
            this.btn_Draw.Text = "绘制";
            this.btn_Draw.UseVisualStyleBackColor = true;
            this.btn_Draw.Click += new System.EventHandler(this.btn_Draw_Click);
            // 
            // textBox_th2
            // 
            this.textBox_th2.Location = new System.Drawing.Point(195, 259);
            this.textBox_th2.Name = "textBox_th2";
            this.textBox_th2.Size = new System.Drawing.Size(54, 25);
            this.textBox_th2.TabIndex = 12;
            this.textBox_th2.Text = "20";
            // 
            // textBox_th1
            // 
            this.textBox_th1.Location = new System.Drawing.Point(195, 213);
            this.textBox_th1.Name = "textBox_th1";
            this.textBox_th1.Size = new System.Drawing.Size(54, 25);
            this.textBox_th1.TabIndex = 11;
            this.textBox_th1.Text = "30";
            this.textBox_th1.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // textBox_per2
            // 
            this.textBox_per2.Location = new System.Drawing.Point(195, 162);
            this.textBox_per2.Name = "textBox_per2";
            this.textBox_per2.Size = new System.Drawing.Size(54, 25);
            this.textBox_per2.TabIndex = 10;
            this.textBox_per2.Text = "0.7";
            // 
            // textBox_per1
            // 
            this.textBox_per1.Location = new System.Drawing.Point(195, 118);
            this.textBox_per1.Name = "textBox_per1";
            this.textBox_per1.Size = new System.Drawing.Size(54, 25);
            this.textBox_per1.TabIndex = 9;
            this.textBox_per1.Text = "0.6";
            // 
            // textBox_leng
            // 
            this.textBox_leng.Location = new System.Drawing.Point(195, 68);
            this.textBox_leng.Name = "textBox_leng";
            this.textBox_leng.Size = new System.Drawing.Size(54, 25);
            this.textBox_leng.TabIndex = 8;
            this.textBox_leng.Text = "100";
            // 
            // textBox_n
            // 
            this.textBox_n.Location = new System.Drawing.Point(195, 19);
            this.textBox_n.Name = "textBox_n";
            this.textBox_n.Size = new System.Drawing.Size(54, 25);
            this.textBox_n.TabIndex = 7;
            this.textBox_n.Text = "10";
            // 
            // label_pen
            // 
            this.label_pen.AutoSize = true;
            this.label_pen.Location = new System.Drawing.Point(27, 327);
            this.label_pen.Name = "label_pen";
            this.label_pen.Size = new System.Drawing.Size(115, 15);
            this.label_pen.TabIndex = 6;
            this.label_pen.Text = "画笔颜色(pen):";
            // 
            // label_th2
            // 
            this.label_th2.AutoSize = true;
            this.label_th2.Location = new System.Drawing.Point(27, 262);
            this.label_th2.Name = "label_th2";
            this.label_th2.Size = new System.Drawing.Size(130, 15);
            this.label_th2.TabIndex = 5;
            this.label_th2.Text = "左分支角度(th2):";
            // 
            // label_th1
            // 
            this.label_th1.AutoSize = true;
            this.label_th1.Location = new System.Drawing.Point(27, 216);
            this.label_th1.Name = "label_th1";
            this.label_th1.Size = new System.Drawing.Size(130, 15);
            this.label_th1.TabIndex = 4;
            this.label_th1.Text = "右分支角度(th1):";
            // 
            // label_per2
            // 
            this.label_per2.AutoSize = true;
            this.label_per2.Location = new System.Drawing.Point(27, 165);
            this.label_per2.Name = "label_per2";
            this.label_per2.Size = new System.Drawing.Size(153, 15);
            this.label_per2.TabIndex = 3;
            this.label_per2.Text = "左分支长度比(per2):";
            // 
            // label_per1
            // 
            this.label_per1.AutoSize = true;
            this.label_per1.Location = new System.Drawing.Point(27, 121);
            this.label_per1.Name = "label_per1";
            this.label_per1.Size = new System.Drawing.Size(153, 15);
            this.label_per1.TabIndex = 2;
            this.label_per1.Text = "右分支长度比(per1):";
            // 
            // label_leng
            // 
            this.label_leng.AutoSize = true;
            this.label_leng.Location = new System.Drawing.Point(27, 71);
            this.label_leng.Name = "label_leng";
            this.label_leng.Size = new System.Drawing.Size(123, 15);
            this.label_leng.TabIndex = 1;
            this.label_leng.Text = "主干长度(leng):";
            // 
            // label_n
            // 
            this.label_n.AutoSize = true;
            this.label_n.Location = new System.Drawing.Point(27, 22);
            this.label_n.Name = "label_n";
            this.label_n.Size = new System.Drawing.Size(99, 15);
            this.label_n.TabIndex = 0;
            this.label_n.Text = "递归深度(n):";
            // 
            // CayleyTree
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Name = "CayleyTree";
            this.Text = "CayleyTree";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label_pen;
        private System.Windows.Forms.Label label_th2;
        private System.Windows.Forms.Label label_th1;
        private System.Windows.Forms.Label label_per2;
        private System.Windows.Forms.Label label_per1;
        private System.Windows.Forms.Label label_leng;
        private System.Windows.Forms.Label label_n;
        private System.Windows.Forms.TextBox textBox_th2;
        private System.Windows.Forms.TextBox textBox_th1;
        private System.Windows.Forms.TextBox textBox_per2;
        private System.Windows.Forms.TextBox textBox_per1;
        private System.Windows.Forms.TextBox textBox_leng;
        private System.Windows.Forms.TextBox textBox_n;
        private System.Windows.Forms.Button btn_Draw;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
    }
}

