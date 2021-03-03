namespace Calculator02
{
    partial class Calculator
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
            this.deal = new System.Windows.Forms.Button();
            this.First = new System.Windows.Forms.TextBox();
            this.Second = new System.Windows.Forms.TextBox();
            this.result = new System.Windows.Forms.TextBox();
            this.Operator = new System.Windows.Forms.ComboBox();
            this.equals = new System.Windows.Forms.Label();
            this.introduce = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // deal
            // 
            this.deal.Location = new System.Drawing.Point(331, 319);
            this.deal.Name = "deal";
            this.deal.Size = new System.Drawing.Size(111, 43);
            this.deal.TabIndex = 0;
            this.deal.Text = "button1";
            this.deal.UseVisualStyleBackColor = true;
            this.deal.Click += new System.EventHandler(this.deal_Click);
            // 
            // First
            // 
            this.First.Location = new System.Drawing.Point(164, 245);
            this.First.Name = "First";
            this.First.Size = new System.Drawing.Size(70, 25);
            this.First.TabIndex = 1;
            this.First.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // Second
            // 
            this.Second.Location = new System.Drawing.Point(372, 244);
            this.Second.Name = "Second";
            this.Second.Size = new System.Drawing.Size(70, 25);
            this.Second.TabIndex = 2;
            // 
            // result
            // 
            this.result.Location = new System.Drawing.Point(531, 245);
            this.result.Name = "result";
            this.result.Size = new System.Drawing.Size(100, 25);
            this.result.TabIndex = 3;
            // 
            // Operator
            // 
            this.Operator.FormattingEnabled = true;
            this.Operator.Location = new System.Drawing.Point(278, 245);
            this.Operator.Name = "Operator";
            this.Operator.Size = new System.Drawing.Size(55, 23);
            this.Operator.TabIndex = 4;
            this.Operator.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // equals
            // 
            this.equals.AutoSize = true;
            this.equals.Location = new System.Drawing.Point(468, 250);
            this.equals.Name = "equals";
            this.equals.Size = new System.Drawing.Size(55, 15);
            this.equals.TabIndex = 5;
            this.equals.Text = "label1";
            this.equals.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // introduce
            // 
            this.introduce.Location = new System.Drawing.Point(235, 105);
            this.introduce.Name = "introduce";
            this.introduce.Size = new System.Drawing.Size(299, 75);
            this.introduce.TabIndex = 6;
            this.introduce.Text = "";
            this.introduce.TextChanged += new System.EventHandler(this.introduce_TextChanged);
            // 
            // Calculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.introduce);
            this.Controls.Add(this.equals);
            this.Controls.Add(this.Operator);
            this.Controls.Add(this.result);
            this.Controls.Add(this.Second);
            this.Controls.Add(this.First);
            this.Controls.Add(this.deal);
            this.Name = "Calculator";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button deal;
        private System.Windows.Forms.TextBox First;
        private System.Windows.Forms.TextBox Second;
        private System.Windows.Forms.TextBox result;
        private System.Windows.Forms.ComboBox Operator;
        private System.Windows.Forms.Label equals;
        private System.Windows.Forms.RichTextBox introduce;
    }
}

