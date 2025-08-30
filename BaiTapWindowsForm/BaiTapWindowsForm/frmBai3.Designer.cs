namespace BaiTapWindowsForm
{
    partial class frmBai3
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
            this.label3 = new System.Windows.Forms.Label();
            this.txtSoA = new System.Windows.Forms.TextBox();
            this.txtSoB = new System.Windows.Forms.TextBox();
            this.txtSoN = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdTinhSoTong1n = new System.Windows.Forms.RadioButton();
            this.rdTinhSoTongAB = new System.Windows.Forms.RadioButton();
            this.btnXemKQ = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.lblKetQua = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 43);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Số a = ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 90);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Số n = ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(36, 66);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Số b = ";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // txtSoA
            // 
            this.txtSoA.Location = new System.Drawing.Point(82, 40);
            this.txtSoA.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtSoA.Name = "txtSoA";
            this.txtSoA.Size = new System.Drawing.Size(113, 20);
            this.txtSoA.TabIndex = 3;
            this.txtSoA.Text = "0";
            // 
            // txtSoB
            // 
            this.txtSoB.Location = new System.Drawing.Point(82, 63);
            this.txtSoB.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtSoB.Name = "txtSoB";
            this.txtSoB.Size = new System.Drawing.Size(113, 20);
            this.txtSoB.TabIndex = 4;
            this.txtSoB.Text = "0";
            this.txtSoB.TextChanged += new System.EventHandler(this.txtSoB_TextChanged);
            // 
            // txtSoN
            // 
            this.txtSoN.Location = new System.Drawing.Point(82, 87);
            this.txtSoN.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtSoN.Name = "txtSoN";
            this.txtSoN.Size = new System.Drawing.Size(113, 20);
            this.txtSoN.TabIndex = 5;
            this.txtSoN.Text = "0";
            this.txtSoN.TextChanged += new System.EventHandler(this.txtSoN_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdTinhSoTong1n);
            this.groupBox1.Controls.Add(this.rdTinhSoTongAB);
            this.groupBox1.Location = new System.Drawing.Point(39, 116);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Size = new System.Drawing.Size(150, 77);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Chọn phép toán";
            // 
            // rdTinhSoTong1n
            // 
            this.rdTinhSoTong1n.AutoSize = true;
            this.rdTinhSoTong1n.Location = new System.Drawing.Point(15, 46);
            this.rdTinhSoTong1n.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rdTinhSoTong1n.Name = "rdTinhSoTong1n";
            this.rdTinhSoTong1n.Size = new System.Drawing.Size(116, 17);
            this.rdTinhSoTong1n.TabIndex = 1;
            this.rdTinhSoTong1n.TabStop = true;
            this.rdTinhSoTong1n.Text = "Tính số tổng 1 -> n";
            this.rdTinhSoTong1n.UseVisualStyleBackColor = true;
            // 
            // rdTinhSoTongAB
            // 
            this.rdTinhSoTongAB.AutoSize = true;
            this.rdTinhSoTongAB.Location = new System.Drawing.Point(15, 17);
            this.rdTinhSoTongAB.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rdTinhSoTongAB.Name = "rdTinhSoTongAB";
            this.rdTinhSoTongAB.Size = new System.Drawing.Size(107, 17);
            this.rdTinhSoTongAB.TabIndex = 0;
            this.rdTinhSoTongAB.TabStop = true;
            this.rdTinhSoTongAB.Text = "Tính số tổng a, b";
            this.rdTinhSoTongAB.UseVisualStyleBackColor = true;
            // 
            // btnXemKQ
            // 
            this.btnXemKQ.Location = new System.Drawing.Point(77, 210);
            this.btnXemKQ.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnXemKQ.Name = "btnXemKQ";
            this.btnXemKQ.Size = new System.Drawing.Size(112, 30);
            this.btnXemKQ.TabIndex = 7;
            this.btnXemKQ.Text = "Xem Kết Quả";
            this.btnXemKQ.UseVisualStyleBackColor = true;
            this.btnXemKQ.Click += new System.EventHandler(this.btnXemKQ_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(39, 253);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "Kết quả là: ";
            // 
            // lblKetQua
            // 
            this.lblKetQua.AutoSize = true;
            this.lblKetQua.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKetQua.Location = new System.Drawing.Point(118, 253);
            this.lblKetQua.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblKetQua.Name = "lblKetQua";
            this.lblKetQua.Size = new System.Drawing.Size(16, 17);
            this.lblKetQua.TabIndex = 9;
            this.lblKetQua.Text = "0";
            // 
            // frmBai3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(290, 306);
            this.Controls.Add(this.lblKetQua);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnXemKQ);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtSoN);
            this.Controls.Add(this.txtSoB);
            this.Controls.Add(this.txtSoA);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmBai3";
            this.Text = "Bài 3";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSoA;
        private System.Windows.Forms.TextBox txtSoB;
        private System.Windows.Forms.TextBox txtSoN;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdTinhSoTong1n;
        private System.Windows.Forms.RadioButton rdTinhSoTongAB;
        private System.Windows.Forms.Button btnXemKQ;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblKetQua;
    }
}