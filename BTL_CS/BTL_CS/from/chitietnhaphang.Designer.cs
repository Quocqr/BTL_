namespace BTL_CS
{
    partial class chitietnhaphang
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.soluongNUD = new System.Windows.Forms.NumericUpDown();
            this.thanhtientb = new System.Windows.Forms.TextBox();
            this.gianhaptb = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.masanpham = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.thoat = new System.Windows.Forms.Button();
            this.xoactnh = new System.Windows.Forms.Button();
            this.suactnh = new System.Windows.Forms.Button();
            this.themctnh = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.seachct = new System.Windows.Forms.Button();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.otimkiem = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.soluongNUD)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6});
            this.dataGridView1.Location = new System.Drawing.Point(12, 313);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(774, 193);
            this.dataGridView1.TabIndex = 0;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "MaNH";
            this.Column1.HeaderText = "mã nhập hàng ";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.Width = 125;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "MaSP";
            this.Column2.HeaderText = "mã sản phẩm ";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.Width = 125;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "TenSP";
            this.Column3.HeaderText = "tên sản phẩm ";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.Width = 125;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "SoLuong";
            this.Column4.HeaderText = "số lượng ";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.Width = 125;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "GiaNhap";
            this.Column5.HeaderText = "giá nhập ";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.Width = 125;
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "ThanhTien";
            this.Column6.HeaderText = "thành tiền ";
            this.Column6.MinimumWidth = 6;
            this.Column6.Name = "Column6";
            this.Column6.Width = 125;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.soluongNUD);
            this.groupBox1.Controls.Add(this.thanhtientb);
            this.groupBox1.Controls.Add(this.gianhaptb);
            this.groupBox1.Controls.Add(this.textBox3);
            this.groupBox1.Controls.Add(this.masanpham);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 43);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(390, 223);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // soluongNUD
            // 
            this.soluongNUD.Location = new System.Drawing.Point(117, 137);
            this.soluongNUD.Name = "soluongNUD";
            this.soluongNUD.Size = new System.Drawing.Size(56, 22);
            this.soluongNUD.TabIndex = 11;
            // 
            // thanhtientb
            // 
            this.thanhtientb.Enabled = false;
            this.thanhtientb.Location = new System.Drawing.Point(208, 170);
            this.thanhtientb.Name = "thanhtientb";
            this.thanhtientb.Size = new System.Drawing.Size(100, 22);
            this.thanhtientb.TabIndex = 10;
            this.thanhtientb.Text = "0";
            // 
            // gianhaptb
            // 
            this.gianhaptb.Location = new System.Drawing.Point(284, 136);
            this.gianhaptb.Name = "gianhaptb";
            this.gianhaptb.Size = new System.Drawing.Size(100, 22);
            this.gianhaptb.TabIndex = 9;
            this.gianhaptb.Validated += new System.EventHandler(this.gianhaptb_Validated);
            // 
            // textBox3
            // 
            this.textBox3.Enabled = false;
            this.textBox3.Location = new System.Drawing.Point(146, 102);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(139, 22);
            this.textBox3.TabIndex = 8;
            this.textBox3.Validating += new System.ComponentModel.CancelEventHandler(this.textBox3_Validating);
            // 
            // masanpham
            // 
            this.masanpham.Location = new System.Drawing.Point(146, 65);
            this.masanpham.Name = "masanpham";
            this.masanpham.Size = new System.Drawing.Size(139, 22);
            this.masanpham.TabIndex = 7;
            this.masanpham.Validating += new System.ComponentModel.CancelEventHandler(this.textBox2_Validating);
            // 
            // textBox1
            // 
            this.textBox1.Enabled = false;
            this.textBox1.Location = new System.Drawing.Point(234, 27);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(150, 22);
            this.textBox1.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(133, 176);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 17);
            this.label6.TabIndex = 5;
            this.label6.Text = "thành tiền :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(25, 102);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "tên sản phẩm ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(205, 139);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "giá nhập ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 137);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "số lượng ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(90, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "mã hóa đơn nhập :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "mã sản phẩm :";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.thoat);
            this.groupBox2.Controls.Add(this.xoactnh);
            this.groupBox2.Controls.Add(this.suactnh);
            this.groupBox2.Controls.Add(this.themctnh);
            this.groupBox2.Location = new System.Drawing.Point(424, 182);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(341, 111);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "groupBox2";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(186, 82);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(83, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "in hóa đơn ";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // thoat
            // 
            this.thoat.Location = new System.Drawing.Point(257, 43);
            this.thoat.Name = "thoat";
            this.thoat.Size = new System.Drawing.Size(75, 23);
            this.thoat.TabIndex = 3;
            this.thoat.Text = "thoát ";
            this.thoat.UseVisualStyleBackColor = true;
            this.thoat.Click += new System.EventHandler(this.thoat_Click);
            // 
            // xoactnh
            // 
            this.xoactnh.Location = new System.Drawing.Point(73, 82);
            this.xoactnh.Name = "xoactnh";
            this.xoactnh.Size = new System.Drawing.Size(83, 23);
            this.xoactnh.TabIndex = 2;
            this.xoactnh.Text = "xóa ";
            this.xoactnh.UseVisualStyleBackColor = true;
            this.xoactnh.Click += new System.EventHandler(this.xoactnh_Click);
            // 
            // suactnh
            // 
            this.suactnh.Location = new System.Drawing.Point(140, 43);
            this.suactnh.Name = "suactnh";
            this.suactnh.Size = new System.Drawing.Size(75, 23);
            this.suactnh.TabIndex = 1;
            this.suactnh.Text = "sửa ";
            this.suactnh.UseVisualStyleBackColor = true;
            this.suactnh.Click += new System.EventHandler(this.suactnh_Click);
            // 
            // themctnh
            // 
            this.themctnh.Location = new System.Drawing.Point(24, 43);
            this.themctnh.Name = "themctnh";
            this.themctnh.Size = new System.Drawing.Size(75, 23);
            this.themctnh.TabIndex = 0;
            this.themctnh.Text = "thêm ";
            this.themctnh.UseVisualStyleBackColor = true;
            this.themctnh.Click += new System.EventHandler(this.themctnh_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.seachct);
            this.groupBox3.Controls.Add(this.checkBox2);
            this.groupBox3.Controls.Add(this.checkBox1);
            this.groupBox3.Controls.Add(this.otimkiem);
            this.groupBox3.Location = new System.Drawing.Point(424, 43);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(345, 133);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "groupBox3";
            // 
            // seachct
            // 
            this.seachct.Location = new System.Drawing.Point(140, 94);
            this.seachct.Name = "seachct";
            this.seachct.Size = new System.Drawing.Size(75, 23);
            this.seachct.TabIndex = 3;
            this.seachct.Text = "tìm kiếm ";
            this.seachct.UseVisualStyleBackColor = true;
            this.seachct.Click += new System.EventHandler(this.seachct_Click);
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(169, 68);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(120, 21);
            this.checkBox2.TabIndex = 2;
            this.checkBox2.Text = "tên sản phẩm ";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(37, 67);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(119, 21);
            this.checkBox1.TabIndex = 1;
            this.checkBox1.Text = "mã sản phẩm ";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // otimkiem
            // 
            this.otimkiem.Location = new System.Drawing.Point(62, 24);
            this.otimkiem.Name = "otimkiem";
            this.otimkiem.Size = new System.Drawing.Size(207, 22);
            this.otimkiem.TabIndex = 0;
            // 
            // chitietnhaphang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(877, 518);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "chitietnhaphang";
            this.Text = "chitietnhaphang";
            this.Load += new System.EventHandler(this.chitietnhaphang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.soluongNUD)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox thanhtientb;
        private System.Windows.Forms.TextBox gianhaptb;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox masanpham;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.NumericUpDown soluongNUD;
        private System.Windows.Forms.Button suactnh;
        private System.Windows.Forms.Button themctnh;
        private System.Windows.Forms.Button thoat;
        private System.Windows.Forms.Button xoactnh;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox otimkiem;
        private System.Windows.Forms.Button seachct;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
    }
}