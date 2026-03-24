namespace LTQL_QLBHDongHo.Forms
{
    partial class frmHoaDon
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
            panel1 = new Panel();
            label1 = new Label();
            textNhapSDTKH = new TextBox();
            label2 = new Label();
            dgvHoaDonGanDay = new DataGridView();
            panel2 = new Panel();
            panel3 = new Panel();
            dataGridView2 = new DataGridView();
            lblListTitle = new Label();
            label3 = new Label();
            textBox1 = new TextBox();
            label4 = new Label();
            btnThanhToan = new Button();
            colMaHD = new DataGridViewTextBoxColumn();
            colTenKH = new DataGridViewTextBoxColumn();
            NGLAP = new DataGridViewTextBoxColumn();
            colThoiGian = new DataGridViewTextBoxColumn();
            colTongTien = new DataGridViewTextBoxColumn();
            TT = new DataGridViewTextBoxColumn();
            Xem = new DataGridViewButtonColumn();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvHoaDonGanDay).BeginInit();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(label4);
            panel1.Controls.Add(textBox1);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(textNhapSDTKH);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(1, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(936, 351);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(214, 21);
            label1.Name = "label1";
            label1.Size = new Size(181, 25);
            label1.TabIndex = 0;
            label1.Text = "Nhập sdt khách hàng";
            // 
            // textNhapSDTKH
            // 
            textNhapSDTKH.Location = new Point(220, 49);
            textNhapSDTKH.Name = "textNhapSDTKH";
            textNhapSDTKH.Size = new Size(232, 31);
            textNhapSDTKH.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(15, 74);
            label2.Name = "label2";
            label2.Size = new Size(0, 25);
            label2.TabIndex = 2;
            label2.Click += label2_Click;
            // 
            // dgvHoaDonGanDay
            // 
            dgvHoaDonGanDay.AllowUserToAddRows = false;
            dgvHoaDonGanDay.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvHoaDonGanDay.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvHoaDonGanDay.Columns.AddRange(new DataGridViewColumn[] { colMaHD, colTenKH, NGLAP, colThoiGian, colTongTien, TT, Xem });
            dgvHoaDonGanDay.Location = new Point(3, 32);
            dgvHoaDonGanDay.Name = "dgvHoaDonGanDay";
            dgvHoaDonGanDay.ReadOnly = true;
            dgvHoaDonGanDay.RowHeadersWidth = 62;
            dgvHoaDonGanDay.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvHoaDonGanDay.Size = new Size(930, 262);
            dgvHoaDonGanDay.TabIndex = 1;
            // 
            // panel2
            // 
            panel2.Controls.Add(lblListTitle);
            panel2.Controls.Add(dgvHoaDonGanDay);
            panel2.Location = new Point(1, 352);
            panel2.Name = "panel2";
            panel2.Size = new Size(936, 297);
            panel2.TabIndex = 2;
            // 
            // panel3
            // 
            panel3.Controls.Add(btnThanhToan);
            panel3.Controls.Add(dataGridView2);
            panel3.Location = new Point(940, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(670, 649);
            panel3.TabIndex = 3;
            // 
            // dataGridView2
            // 
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(3, 3);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowHeadersWidth = 62;
            dataGridView2.Size = new Size(667, 225);
            dataGridView2.TabIndex = 1;
            // 
            // lblListTitle
            // 
            lblListTitle.AutoSize = true;
            lblListTitle.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblListTitle.Location = new Point(4, 4);
            lblListTitle.Margin = new Padding(4, 0, 4, 0);
            lblListTitle.Name = "lblListTitle";
            lblListTitle.Size = new Size(248, 25);
            lblListTitle.TabIndex = 2;
            lblListTitle.Text = "Danh sách hóa đơn gần đây";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(23, 21);
            label3.Name = "label3";
            label3.Size = new Size(68, 25);
            label3.TabIndex = 3;
            label3.Text = "Mã HĐ";
            label3.Click += label3_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(24, 49);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(150, 31);
            textBox1.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(434, 163);
            label4.Name = "label4";
            label4.Size = new Size(0, 25);
            label4.TabIndex = 5;
            // 
            // btnThanhToan
            // 
            btnThanhToan.BackColor = SystemColors.MenuHighlight;
            btnThanhToan.ForeColor = Color.Navy;
            btnThanhToan.Location = new Point(441, 541);
            btnThanhToan.Name = "btnThanhToan";
            btnThanhToan.Size = new Size(207, 87);
            btnThanhToan.TabIndex = 2;
            btnThanhToan.Text = "Thanh Toán";
            btnThanhToan.UseVisualStyleBackColor = false;
            // 
            // colMaHD
            // 
            colMaHD.FillWeight = 10F;
            colMaHD.HeaderText = "ID";
            colMaHD.MinimumWidth = 8;
            colMaHD.Name = "colMaHD";
            colMaHD.ReadOnly = true;
            // 
            // colTenKH
            // 
            colTenKH.FillWeight = 20F;
            colTenKH.HeaderText = "Khách Hàng";
            colTenKH.MinimumWidth = 8;
            colTenKH.Name = "colTenKH";
            colTenKH.ReadOnly = true;
            // 
            // NGLAP
            // 
            NGLAP.FillWeight = 20F;
            NGLAP.HeaderText = "Người Lập";
            NGLAP.MinimumWidth = 8;
            NGLAP.Name = "NGLAP";
            NGLAP.ReadOnly = true;
            // 
            // colThoiGian
            // 
            colThoiGian.FillWeight = 15F;
            colThoiGian.HeaderText = "Ngày Lập";
            colThoiGian.MinimumWidth = 8;
            colThoiGian.Name = "colThoiGian";
            colThoiGian.ReadOnly = true;
            // 
            // colTongTien
            // 
            colTongTien.FillWeight = 15F;
            colTongTien.HeaderText = "Tổng Tiền";
            colTongTien.MinimumWidth = 8;
            colTongTien.Name = "colTongTien";
            colTongTien.ReadOnly = true;
            // 
            // TT
            // 
            TT.FillWeight = 10F;
            TT.HeaderText = "Trạng Thái";
            TT.MinimumWidth = 8;
            TT.Name = "TT";
            TT.ReadOnly = true;
            // 
            // Xem
            // 
            Xem.FillWeight = 8F;
            Xem.HeaderText = "Xem Chi Tiết";
            Xem.MinimumWidth = 8;
            Xem.Name = "Xem";
            Xem.ReadOnly = true;
            // 
            // frmHoaDon
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(247, 249, 252);
            ClientSize = new Size(1616, 650);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "frmHoaDon";
            Text = "Lập Hóa Đơn";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvHoaDonGanDay).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private TextBox textNhapSDTKH;
        private Label label1;
        private Label label2;
        private DataGridView dgvHoaDonGanDay;
        private Panel panel2;
        private Panel panel3;
        private DataGridView dataGridView2;
        private Label lblListTitle;
        private TextBox textBox1;
        private Label label3;
        private Label label4;
        private DataGridViewTextBoxColumn colMaHD;
        private DataGridViewTextBoxColumn colTenKH;
        private DataGridViewTextBoxColumn NGLAP;
        private DataGridViewTextBoxColumn colThoiGian;
        private DataGridViewTextBoxColumn colTongTien;
        private DataGridViewTextBoxColumn TT;
        private DataGridViewButtonColumn Xem;
        private Button btnThanhToan;
    }
}