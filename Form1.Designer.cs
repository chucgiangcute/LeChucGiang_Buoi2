namespace LeChucGiang_Buoi2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtn = new TextBox();
            txtle = new TextBox();
            txtnt = new TextBox();
            btnnhap = new Button();
            btntim = new Button();
            btntim1 = new Button();
            label4 = new Label();
            txtmang = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 13F);
            label1.Location = new Point(216, 128);
            label1.Name = "label1";
            label1.Size = new Size(129, 42);
            label1.TabIndex = 0;
            label1.Text = "Nhập n";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Tahoma", 13F);
            label2.Location = new Point(216, 475);
            label2.Name = "label2";
            label2.Size = new Size(433, 42);
            label2.TabIndex = 0;
            label2.Text = "Các phần tử lẻ trong mảng";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Tahoma", 13F);
            label3.Location = new Point(216, 641);
            label3.Name = "label3";
            label3.Size = new Size(477, 42);
            label3.TabIndex = 0;
            label3.Text = "Các số nguyên tố trong mảng";
            // 
            // txtn
            // 
            txtn.Font = new Font("Tahoma", 13F);
            txtn.Location = new Point(410, 129);
            txtn.Name = "txtn";
            txtn.Size = new Size(373, 49);
            txtn.TabIndex = 1;
            // 
            // txtle
            // 
            txtle.Font = new Font("Tahoma", 13F);
            txtle.Location = new Point(792, 468);
            txtle.Name = "txtle";
            txtle.Size = new Size(540, 49);
            txtle.TabIndex = 1;
            // 
            // txtnt
            // 
            txtnt.Font = new Font("Tahoma", 13F);
            txtnt.Location = new Point(792, 641);
            txtnt.Name = "txtnt";
            txtnt.Size = new Size(540, 49);
            txtnt.TabIndex = 1;
            // 
            // btnnhap
            // 
            btnnhap.Font = new Font("Tahoma", 13F);
            btnnhap.Location = new Point(885, 120);
            btnnhap.Name = "btnnhap";
            btnnhap.Size = new Size(150, 58);
            btnnhap.TabIndex = 2;
            btnnhap.Text = "Nhập";
            btnnhap.UseVisualStyleBackColor = true;
            btnnhap.Click += button1_Click;
            // 
            // btntim
            // 
            btntim.Font = new Font("Tahoma", 13F);
            btntim.Location = new Point(1419, 463);
            btntim.Name = "btntim";
            btntim.Size = new Size(150, 58);
            btntim.TabIndex = 2;
            btntim.Text = "Tìm";
            btntim.UseVisualStyleBackColor = true;
            btntim.Click += btntim_Click;
            // 
            // btntim1
            // 
            btntim1.Font = new Font("Tahoma", 13F);
            btntim1.Location = new Point(1430, 632);
            btntim1.Name = "btntim1";
            btntim1.Size = new Size(150, 58);
            btntim1.TabIndex = 2;
            btntim1.Text = "Tìm";
            btntim1.UseVisualStyleBackColor = true;
            btntim1.Click += btntim1_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Tahoma", 13F);
            label4.Location = new Point(216, 327);
            label4.Name = "label4";
            label4.Size = new Size(433, 42);
            label4.TabIndex = 0;
            label4.Text = "Các phần tử trong mảng là";
            // 
            // txtmang
            // 
            txtmang.Font = new Font("Tahoma", 13F);
            txtmang.Location = new Point(792, 341);
            txtmang.Name = "txtmang";
            txtmang.Size = new Size(777, 49);
            txtmang.TabIndex = 1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Silver;
            ClientSize = new Size(2106, 981);
            Controls.Add(btntim1);
            Controls.Add(btntim);
            Controls.Add(btnnhap);
            Controls.Add(txtnt);
            Controls.Add(txtmang);
            Controls.Add(txtle);
            Controls.Add(txtn);
            Controls.Add(label3);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtn;
        private TextBox txtle;
        private TextBox txtnt;
        private Button btnnhap;
        private Button btntim;
        private Button btntim1;
        private Label label4;
        private TextBox txtmang;
    }
}
