namespace LuongDinhHoang_ThiHetMon
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
            flowLayoutPanel1 = new FlowLayoutPanel();
            panel1 = new Panel();
            lbdoanhthu = new Label();
            button1 = new Button();
            btnsua1 = new Button();
            label4 = new Label();
            txtmadonhang1 = new TextBox();
            label10 = new Label();
            btnxoa1 = new Button();
            btnthem1 = new Button();
            txtkhoiluong1 = new TextBox();
            txtdiachi1 = new TextBox();
            txttenkh1 = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            dt1 = new DataGridView();
            panel2 = new Panel();
            btnsua2 = new Button();
            label8 = new Label();
            txtmadonhang2 = new TextBox();
            label11 = new Label();
            btnxoa2 = new Button();
            btnthem2 = new Button();
            txtkhoiluong2 = new TextBox();
            txtdiachi2 = new TextBox();
            txttenkh2 = new TextBox();
            label7 = new Label();
            dt2 = new DataGridView();
            label6 = new Label();
            label5 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dt1).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dt2).BeginInit();
            SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Dock = DockStyle.Top;
            flowLayoutPanel1.Location = new Point(0, 0);
            flowLayoutPanel1.Margin = new Padding(4, 5, 4, 5);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(1488, 15);
            flowLayoutPanel1.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(255, 192, 192);
            panel1.Controls.Add(lbdoanhthu);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(btnsua1);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(txtmadonhang1);
            panel1.Controls.Add(label10);
            panel1.Controls.Add(btnxoa1);
            panel1.Controls.Add(btnthem1);
            panel1.Controls.Add(txtkhoiluong1);
            panel1.Controls.Add(txtdiachi1);
            panel1.Controls.Add(txttenkh1);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(dt1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 15);
            panel1.Margin = new Padding(4, 5, 4, 5);
            panel1.Name = "panel1";
            panel1.Size = new Size(1488, 333);
            panel1.TabIndex = 1;
            // 
            // lbdoanhthu
            // 
            lbdoanhthu.AutoSize = true;
            lbdoanhthu.Location = new Point(630, 36);
            lbdoanhthu.Name = "lbdoanhthu";
            lbdoanhthu.Size = new Size(143, 23);
            lbdoanhthu.TabIndex = 9;
            lbdoanhthu.Text = "Tổng doanh thu: ";
            // 
            // button1
            // 
            button1.FlatAppearance.BorderColor = Color.Lime;
            button1.FlatAppearance.BorderSize = 3;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Location = new Point(467, 30);
            button1.Margin = new Padding(4, 5, 4, 5);
            button1.Name = "button1";
            button1.Size = new Size(148, 35);
            button1.TabIndex = 8;
            button1.Text = "Doanh Thu";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // btnsua1
            // 
            btnsua1.FlatAppearance.BorderColor = Color.Lime;
            btnsua1.FlatAppearance.BorderSize = 3;
            btnsua1.FlatStyle = FlatStyle.Flat;
            btnsua1.Location = new Point(630, 152);
            btnsua1.Margin = new Padding(4, 5, 4, 5);
            btnsua1.Name = "btnsua1";
            btnsua1.Size = new Size(96, 35);
            btnsua1.TabIndex = 7;
            btnsua1.Text = "Sửa";
            btnsua1.UseVisualStyleBackColor = true;
            btnsua1.Click += btnsua1_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(473, 106);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(113, 23);
            label4.TabIndex = 6;
            label4.Text = "Mã đơn hàng";
            // 
            // txtmadonhang1
            // 
            txtmadonhang1.Location = new Point(599, 101);
            txtmadonhang1.Margin = new Padding(4, 5, 4, 5);
            txtmadonhang1.Name = "txtmadonhang1";
            txtmadonhang1.Size = new Size(171, 30);
            txtmadonhang1.TabIndex = 5;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI Black", 27.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label10.Location = new Point(29, 24);
            label10.Margin = new Padding(4, 0, 4, 0);
            label10.Name = "label10";
            label10.Size = new Size(406, 50);
            label10.TabIndex = 4;
            label10.Text = "Giao hàng tiêu chuẩn";
            // 
            // btnxoa1
            // 
            btnxoa1.FlatAppearance.BorderColor = Color.Red;
            btnxoa1.FlatAppearance.BorderSize = 3;
            btnxoa1.FlatStyle = FlatStyle.Flat;
            btnxoa1.Location = new Point(486, 152);
            btnxoa1.Margin = new Padding(4, 5, 4, 5);
            btnxoa1.Name = "btnxoa1";
            btnxoa1.Size = new Size(96, 35);
            btnxoa1.TabIndex = 3;
            btnxoa1.Text = "Xóa";
            btnxoa1.UseVisualStyleBackColor = true;
            btnxoa1.Click += btnxoa1_Click;
            // 
            // btnthem1
            // 
            btnthem1.Location = new Point(207, 254);
            btnthem1.Margin = new Padding(4, 5, 4, 5);
            btnthem1.Name = "btnthem1";
            btnthem1.Size = new Size(96, 35);
            btnthem1.TabIndex = 3;
            btnthem1.Text = "Thêm";
            btnthem1.UseVisualStyleBackColor = true;
            btnthem1.Click += btnthem1_Click;
            // 
            // txtkhoiluong1
            // 
            txtkhoiluong1.Location = new Point(207, 205);
            txtkhoiluong1.Margin = new Padding(4, 5, 4, 5);
            txtkhoiluong1.Name = "txtkhoiluong1";
            txtkhoiluong1.Size = new Size(236, 30);
            txtkhoiluong1.TabIndex = 2;
            // 
            // txtdiachi1
            // 
            txtdiachi1.Location = new Point(208, 152);
            txtdiachi1.Margin = new Padding(4, 5, 4, 5);
            txtdiachi1.Name = "txtdiachi1";
            txtdiachi1.Size = new Size(236, 30);
            txtdiachi1.TabIndex = 2;
            // 
            // txttenkh1
            // 
            txttenkh1.Location = new Point(208, 101);
            txttenkh1.Margin = new Padding(4, 5, 4, 5);
            txttenkh1.Name = "txttenkh1";
            txttenkh1.Size = new Size(236, 30);
            txttenkh1.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(52, 209);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(93, 23);
            label3.TabIndex = 1;
            label3.Text = "Khối lượng";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(53, 156);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(62, 23);
            label2.TabIndex = 1;
            label2.Text = "Địa chỉ";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(53, 103);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(130, 23);
            label1.TabIndex = 1;
            label1.Text = "Tên khách hàng";
            // 
            // dt1
            // 
            dt1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dt1.Dock = DockStyle.Right;
            dt1.Location = new Point(804, 0);
            dt1.Margin = new Padding(4, 5, 4, 5);
            dt1.Name = "dt1";
            dt1.Size = new Size(684, 333);
            dt1.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ActiveCaption;
            panel2.Controls.Add(btnsua2);
            panel2.Controls.Add(label8);
            panel2.Controls.Add(txtmadonhang2);
            panel2.Controls.Add(label11);
            panel2.Controls.Add(btnxoa2);
            panel2.Controls.Add(btnthem2);
            panel2.Controls.Add(txtkhoiluong2);
            panel2.Controls.Add(txtdiachi2);
            panel2.Controls.Add(txttenkh2);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(dt2);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(label5);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 348);
            panel2.Margin = new Padding(4, 5, 4, 5);
            panel2.Name = "panel2";
            panel2.Size = new Size(1488, 351);
            panel2.TabIndex = 2;
            // 
            // btnsua2
            // 
            btnsua2.FlatAppearance.BorderColor = Color.Lime;
            btnsua2.FlatAppearance.BorderSize = 3;
            btnsua2.FlatStyle = FlatStyle.Flat;
            btnsua2.Location = new Point(640, 163);
            btnsua2.Margin = new Padding(4, 5, 4, 5);
            btnsua2.Name = "btnsua2";
            btnsua2.Size = new Size(96, 35);
            btnsua2.TabIndex = 7;
            btnsua2.Text = "Sửa";
            btnsua2.UseVisualStyleBackColor = true;
            btnsua2.Click += btnsua2_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(473, 114);
            label8.Margin = new Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new Size(113, 23);
            label8.TabIndex = 6;
            label8.Text = "Mã đơn hàng";
            // 
            // txtmadonhang2
            // 
            txtmadonhang2.Location = new Point(599, 109);
            txtmadonhang2.Margin = new Padding(4, 5, 4, 5);
            txtmadonhang2.Name = "txtmadonhang2";
            txtmadonhang2.Size = new Size(171, 30);
            txtmadonhang2.TabIndex = 5;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI Black", 27.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label11.Location = new Point(53, 23);
            label11.Margin = new Padding(4, 0, 4, 0);
            label11.Name = "label11";
            label11.Size = new Size(332, 50);
            label11.TabIndex = 4;
            label11.Text = "Giao hàng nhanh";
            // 
            // btnxoa2
            // 
            btnxoa2.FlatAppearance.BorderColor = Color.Red;
            btnxoa2.FlatAppearance.BorderSize = 3;
            btnxoa2.FlatStyle = FlatStyle.Flat;
            btnxoa2.Location = new Point(496, 163);
            btnxoa2.Margin = new Padding(4, 5, 4, 5);
            btnxoa2.Name = "btnxoa2";
            btnxoa2.Size = new Size(96, 35);
            btnxoa2.TabIndex = 3;
            btnxoa2.Text = "Xóa";
            btnxoa2.UseVisualStyleBackColor = true;
            btnxoa2.Click += btnxoa2_Click;
            // 
            // btnthem2
            // 
            btnthem2.Location = new Point(207, 271);
            btnthem2.Margin = new Padding(4, 5, 4, 5);
            btnthem2.Name = "btnthem2";
            btnthem2.Size = new Size(96, 35);
            btnthem2.TabIndex = 3;
            btnthem2.Text = "Thêm";
            btnthem2.UseVisualStyleBackColor = true;
            btnthem2.Click += btnthem2_Click;
            // 
            // txtkhoiluong2
            // 
            txtkhoiluong2.Location = new Point(208, 222);
            txtkhoiluong2.Margin = new Padding(4, 5, 4, 5);
            txtkhoiluong2.Name = "txtkhoiluong2";
            txtkhoiluong2.Size = new Size(236, 30);
            txtkhoiluong2.TabIndex = 2;
            // 
            // txtdiachi2
            // 
            txtdiachi2.Location = new Point(208, 159);
            txtdiachi2.Margin = new Padding(4, 5, 4, 5);
            txtdiachi2.Name = "txtdiachi2";
            txtdiachi2.Size = new Size(236, 30);
            txtdiachi2.TabIndex = 2;
            // 
            // txttenkh2
            // 
            txttenkh2.Location = new Point(208, 105);
            txttenkh2.Margin = new Padding(4, 5, 4, 5);
            txttenkh2.Name = "txttenkh2";
            txttenkh2.Size = new Size(236, 30);
            txttenkh2.TabIndex = 2;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(53, 228);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(93, 23);
            label7.TabIndex = 1;
            label7.Text = "Khối lượng";
            // 
            // dt2
            // 
            dt2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dt2.Dock = DockStyle.Right;
            dt2.Location = new Point(804, 0);
            dt2.Margin = new Padding(4, 5, 4, 5);
            dt2.Name = "dt2";
            dt2.Size = new Size(684, 351);
            dt2.TabIndex = 0;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(53, 166);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(62, 23);
            label6.TabIndex = 1;
            label6.Text = "Địa chỉ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(53, 112);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(130, 23);
            label5.TabIndex = 1;
            label5.Text = "Tên khách hàng";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1488, 699);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(flowLayoutPanel1);
            Font = new Font("Segoe UI", 12.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4, 5, 4, 5);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Chương trình quản lý đơn hàng 2024";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dt1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dt2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel flowLayoutPanel1;
        private Panel panel1;
        private Button btnxoa1;
        private Button btnthem1;
        private TextBox txtkhoiluong1;
        private TextBox txtdiachi1;
        private TextBox txttenkh1;
        private Label label3;
        private Label label2;
        private Label label1;
        private DataGridView dt1;
        private Panel panel2;
        private Button btnxoa2;
        private Button btnthem2;
        private TextBox txtkhoiluong2;
        private TextBox txtdiachi2;
        private TextBox txttenkh2;
        private Label label7;
        private DataGridView dt2;
        private Label label6;
        private Label label5;
        private Label label10;
        private Label label11;
        private Label label4;
        private TextBox txtmadonhang1;
        private Label label8;
        private TextBox txtmadonhang2;
        private Button btnsua1;
        private Button btnsua2;
        private Button button1;
        private Label lbdoanhthu;
    }
}
