namespace CSharp_Bai6
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.bttinh = new System.Windows.Forms.Button();
            this.txthk1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txthk2 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtdtb = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtkq = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtxlht = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(365, 68);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(182, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kết Quả Học Tập";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(86, 136);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Điểm HKI";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // bttinh
            // 
            this.bttinh.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttinh.ForeColor = System.Drawing.Color.DarkGreen;
            this.bttinh.Location = new System.Drawing.Point(399, 447);
            this.bttinh.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.bttinh.Name = "bttinh";
            this.bttinh.Size = new System.Drawing.Size(117, 59);
            this.bttinh.TabIndex = 2;
            this.bttinh.Text = "Xem Kết Quả";
            this.bttinh.UseVisualStyleBackColor = true;
            this.bttinh.Click += new System.EventHandler(this.button1_Click);
            // 
            // txthk1
            // 
            this.txthk1.Location = new System.Drawing.Point(252, 136);
            this.txthk1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txthk1.Name = "txthk1";
            this.txthk1.Size = new System.Drawing.Size(420, 21);
            this.txthk1.TabIndex = 3;
            this.txthk1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(86, 187);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 15);
            this.label3.TabIndex = 1;
            this.label3.Text = "Điểm HKII";
            this.label3.Click += new System.EventHandler(this.label2_Click);
            // 
            // txthk2
            // 
            this.txthk2.Location = new System.Drawing.Point(252, 187);
            this.txthk2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txthk2.Name = "txthk2";
            this.txthk2.Size = new System.Drawing.Size(420, 21);
            this.txthk2.TabIndex = 3;
            this.txthk2.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(86, 241);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 15);
            this.label4.TabIndex = 1;
            this.label4.Text = "ĐiểmTB";
            this.label4.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtdtb
            // 
            this.txtdtb.Location = new System.Drawing.Point(252, 241);
            this.txtdtb.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtdtb.Name = "txtdtb";
            this.txtdtb.Size = new System.Drawing.Size(420, 21);
            this.txtdtb.TabIndex = 3;
            this.txtdtb.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(86, 293);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 15);
            this.label5.TabIndex = 1;
            this.label5.Text = "Kết Quả";
            this.label5.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtkq
            // 
            this.txtkq.Location = new System.Drawing.Point(252, 293);
            this.txtkq.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtkq.Name = "txtkq";
            this.txtkq.Size = new System.Drawing.Size(420, 21);
            this.txtkq.TabIndex = 3;
            this.txtkq.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Red;
            this.label6.Location = new System.Drawing.Point(86, 346);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(98, 15);
            this.label6.TabIndex = 1;
            this.label6.Text = "Xếp Loại Học Tập";
            this.label6.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtxlht
            // 
            this.txtxlht.Location = new System.Drawing.Point(252, 346);
            this.txtxlht.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtxlht.Name = "txtxlht";
            this.txtxlht.Size = new System.Drawing.Size(420, 21);
            this.txtxlht.TabIndex = 3;
            this.txtxlht.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(886, 564);
            this.Controls.Add(this.txtxlht);
            this.Controls.Add(this.txtkq);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtdtb);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txthk2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txthk1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.bttinh);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Black;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Form1";
            this.Text = "Bảng Điểm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button bttinh;
        private System.Windows.Forms.TextBox txthk1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txthk2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtdtb;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtkq;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtxlht;
    }
}

