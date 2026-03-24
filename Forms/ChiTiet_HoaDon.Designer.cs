namespace LTQL_QLBHDongHo.Forms
{
    partial class ChiTiet_HoaDon
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Label lblMaHD;
        private System.Windows.Forms.Label lblThoiGian;
        private System.Windows.Forms.Label lblNhanVien;
        private System.Windows.Forms.Label lblKhachHang;
        private System.Windows.Forms.Label lblTrangThaiLabel;

        private System.Windows.Forms.DataGridView dgvChiTiet;

        private System.Windows.Forms.Panel panelBottom;
        private System.Windows.Forms.Label lblGhiChuTitle;
        private System.Windows.Forms.Panel panelTotals;
        private System.Windows.Forms.Label lblTamTinhLabel;
        private System.Windows.Forms.Label lblTamTinhValue;
        private System.Windows.Forms.Label lblGiamGiaLabel;
        private System.Windows.Forms.Label lblTongLabel;
        private System.Windows.Forms.Label lblTongValue;
        private System.Windows.Forms.Button btnDong;
        private System.Windows.Forms.Button btnIn;

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
            panelHeader = new Panel();
            lblMaHD = new Label();
            lblThoiGian = new Label();
            lblNhanVien = new Label();
            lblKhachHang = new Label();
            lblTrangThaiLabel = new Label();
            dgvChiTiet = new DataGridView();
            panelBottom = new Panel();
            lblGhiChuTitle = new Label();
            panelTotals = new Panel();
            lblTamTinhLabel = new Label();
            lblTamTinhValue = new Label();
            lblGiamGiaLabel = new Label();
            lblTongLabel = new Label();
            lblTongValue = new Label();
            btnDong = new Button();
            btnIn = new Button();
            lblSDT = new Label();
            panel1 = new Panel();
            cStt = new DataGridViewTextBoxColumn();
            cTen = new DataGridViewTextBoxColumn();
            cSl = new DataGridViewTextBoxColumn();
            cThanhTien = new DataGridViewTextBoxColumn();
            panelHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvChiTiet).BeginInit();
            panelBottom.SuspendLayout();
            panelTotals.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panelHeader
            // 
            panelHeader.BackColor = Color.WhiteSmoke;
            panelHeader.Controls.Add(lblSDT);
            panelHeader.Controls.Add(lblMaHD);
            panelHeader.Controls.Add(lblThoiGian);
            panelHeader.Controls.Add(lblNhanVien);
            panelHeader.Controls.Add(lblKhachHang);
            panelHeader.Controls.Add(lblTrangThaiLabel);
            panelHeader.Dock = DockStyle.Top;
            panelHeader.Location = new Point(0, 0);
            panelHeader.Name = "panelHeader";
            panelHeader.Padding = new Padding(12);
            panelHeader.Size = new Size(832, 145);
            panelHeader.TabIndex = 2;
            // 
            // lblMaHD
            // 
            lblMaHD.AutoSize = true;
            lblMaHD.Font = new Font("Segoe UI", 9F);
            lblMaHD.Location = new Point(12, 12);
            lblMaHD.Name = "lblMaHD";
            lblMaHD.Size = new Size(113, 25);
            lblMaHD.TabIndex = 0;
            lblMaHD.Text = "Mã hóa đơn:";
            lblMaHD.Click += lblMaHD_Click;
            // 
            // lblThoiGian
            // 
            lblThoiGian.AutoSize = true;
            lblThoiGian.Font = new Font("Segoe UI", 9F);
            lblThoiGian.Location = new Point(12, 55);
            lblThoiGian.Name = "lblThoiGian";
            lblThoiGian.Size = new Size(118, 25);
            lblThoiGian.TabIndex = 2;
            lblThoiGian.Text = "Thời gian lập:";
            // 
            // lblNhanVien
            // 
            lblNhanVien.AutoSize = true;
            lblNhanVien.Font = new Font("Segoe UI", 9F);
            lblNhanVien.Location = new Point(12, 99);
            lblNhanVien.Name = "lblNhanVien";
            lblNhanVien.Size = new Size(95, 25);
            lblNhanVien.TabIndex = 4;
            lblNhanVien.Text = "Nhân viên:\r\n";
            // 
            // lblKhachHang
            // 
            lblKhachHang.AutoSize = true;
            lblKhachHang.Font = new Font("Segoe UI", 9F);
            lblKhachHang.Location = new Point(357, 12);
            lblKhachHang.Name = "lblKhachHang";
            lblKhachHang.Size = new Size(108, 25);
            lblKhachHang.TabIndex = 8;
            lblKhachHang.Text = "Khách hàng:";
            // 
            // lblTrangThaiLabel
            // 
            lblTrangThaiLabel.AutoSize = true;
            lblTrangThaiLabel.Font = new Font("Segoe UI", 9F);
            lblTrangThaiLabel.Location = new Point(357, 99);
            lblTrangThaiLabel.Name = "lblTrangThaiLabel";
            lblTrangThaiLabel.Size = new Size(93, 25);
            lblTrangThaiLabel.TabIndex = 10;
            lblTrangThaiLabel.Text = "Trạng thái:";
            // 
            // dgvChiTiet
            // 
            dgvChiTiet.AllowUserToAddRows = false;
            dgvChiTiet.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvChiTiet.ColumnHeadersHeight = 34;
            dgvChiTiet.Columns.AddRange(new DataGridViewColumn[] { cStt, cTen, cSl, cThanhTien });
            dgvChiTiet.Dock = DockStyle.Top;
            dgvChiTiet.Location = new Point(0, 145);
            dgvChiTiet.Name = "dgvChiTiet";
            dgvChiTiet.RowHeadersWidth = 62;
            dgvChiTiet.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvChiTiet.Size = new Size(832, 320);
            dgvChiTiet.TabIndex = 1;
            // 
            // panelBottom
            // 
            panelBottom.BackColor = Color.WhiteSmoke;
            panelBottom.Controls.Add(panel1);
            panelBottom.Controls.Add(panelTotals);
            panelBottom.Controls.Add(btnDong);
            panelBottom.Controls.Add(btnIn);
            panelBottom.Dock = DockStyle.Fill;
            panelBottom.Location = new Point(0, 465);
            panelBottom.Name = "panelBottom";
            panelBottom.Padding = new Padding(12);
            panelBottom.Size = new Size(832, 276);
            panelBottom.TabIndex = 0;
            // 
            // lblGhiChuTitle
            // 
            lblGhiChuTitle.AutoSize = true;
            lblGhiChuTitle.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblGhiChuTitle.Location = new Point(8, 9);
            lblGhiChuTitle.Name = "lblGhiChuTitle";
            lblGhiChuTitle.Size = new Size(157, 25);
            lblGhiChuTitle.TabIndex = 0;
            lblGhiChuTitle.Text = "Ghi chú hóa đơn:";
            // 
            // panelTotals
            // 
            panelTotals.BorderStyle = BorderStyle.FixedSingle;
            panelTotals.Controls.Add(lblTamTinhLabel);
            panelTotals.Controls.Add(lblTamTinhValue);
            panelTotals.Controls.Add(lblGiamGiaLabel);
            panelTotals.Controls.Add(lblTongLabel);
            panelTotals.Controls.Add(lblTongValue);
            panelTotals.Location = new Point(424, 13);
            panelTotals.Name = "panelTotals";
            panelTotals.Size = new Size(396, 148);
            panelTotals.TabIndex = 2;
            panelTotals.Paint += panelTotals_Paint;
            // 
            // lblTamTinhLabel
            // 
            lblTamTinhLabel.AutoSize = true;
            lblTamTinhLabel.Location = new Point(12, 12);
            lblTamTinhLabel.Name = "lblTamTinhLabel";
            lblTamTinhLabel.Size = new Size(138, 25);
            lblTamTinhLabel.TabIndex = 0;
            lblTamTinhLabel.Text = "Cộng tiền hàng:";
            // 
            // lblTamTinhValue
            // 
            lblTamTinhValue.AutoSize = true;
            lblTamTinhValue.Location = new Point(217, 12);
            lblTamTinhValue.Name = "lblTamTinhValue";
            lblTamTinhValue.Size = new Size(38, 25);
            lblTamTinhValue.TabIndex = 1;
            lblTamTinhValue.Text = "0 đ";
            // 
            // lblGiamGiaLabel
            // 
            lblGiamGiaLabel.AutoSize = true;
            lblGiamGiaLabel.Location = new Point(12, 42);
            lblGiamGiaLabel.Name = "lblGiamGiaLabel";
            lblGiamGiaLabel.Size = new Size(0, 25);
            lblGiamGiaLabel.TabIndex = 2;
            // 
            // lblTongLabel
            // 
            lblTongLabel.AutoSize = true;
            lblTongLabel.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblTongLabel.Location = new Point(8, 73);
            lblTongLabel.Name = "lblTongLabel";
            lblTongLabel.Size = new Size(214, 28);
            lblTongLabel.TabIndex = 4;
            lblTongLabel.Text = "TỔNG THANH TOÁN:";
            // 
            // lblTongValue
            // 
            lblTongValue.AutoSize = true;
            lblTongValue.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblTongValue.ForeColor = Color.DarkRed;
            lblTongValue.Location = new Point(272, 65);
            lblTongValue.Name = "lblTongValue";
            lblTongValue.Size = new Size(59, 38);
            lblTongValue.TabIndex = 5;
            lblTongValue.Text = "0 đ";
            // 
            // btnDong
            // 
            btnDong.ForeColor = Color.Red;
            btnDong.Location = new Point(463, 180);
            btnDong.Name = "btnDong";
            btnDong.Size = new Size(129, 67);
            btnDong.TabIndex = 3;
            btnDong.Text = "Đóng";
            // 
            // btnIn
            // 
            btnIn.ForeColor = SystemColors.Highlight;
            btnIn.Location = new Point(642, 180);
            btnIn.Name = "btnIn";
            btnIn.Size = new Size(120, 67);
            btnIn.TabIndex = 4;
            btnIn.Text = "In Lại Hóa Đơn";
            btnIn.Click += BtnIn_Click;
            // 
            // lblSDT
            // 
            lblSDT.AutoSize = true;
            lblSDT.Font = new Font("Segoe UI", 9F);
            lblSDT.Location = new Point(357, 55);
            lblSDT.Name = "lblSDT";
            lblSDT.Size = new Size(144, 25);
            lblSDT.TabIndex = 11;
            lblSDT.Text = "SĐT khách hàng:";
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(lblGhiChuTitle);
            panel1.Location = new Point(18, 13);
            panel1.Name = "panel1";
            panel1.Size = new Size(389, 127);
            panel1.TabIndex = 5;
            // 
            // cStt
            // 
            cStt.DataPropertyName = "STT";
            cStt.FillWeight = 8F;
            cStt.HeaderText = "STT";
            cStt.MinimumWidth = 8;
            cStt.Name = "cStt";
            cStt.ReadOnly = true;
            // 
            // cTen
            // 
            cTen.DataPropertyName = "Ten";
            cTen.FillWeight = 30F;
            cTen.HeaderText = "Sản Phẩm";
            cTen.MinimumWidth = 8;
            cTen.Name = "cTen";
            cTen.ReadOnly = true;
            // 
            // cSl
            // 
            cSl.DataPropertyName = "SL";
            cSl.FillWeight = 5F;
            cSl.HeaderText = "SL";
            cSl.MinimumWidth = 8;
            cSl.Name = "cSl";
            cSl.ReadOnly = true;
            // 
            // cThanhTien
            // 
            cThanhTien.DataPropertyName = "ThanhTien";
            cThanhTien.HeaderText = "Thành Tiền";
            cThanhTien.MinimumWidth = 8;
            cThanhTien.Name = "cThanhTien";
            cThanhTien.ReadOnly = true;
            // 
            // ChiTiet_HoaDon
            // 
            ClientSize = new Size(832, 741);
            Controls.Add(panelBottom);
            Controls.Add(dgvChiTiet);
            Controls.Add(panelHeader);
            Name = "ChiTiet_HoaDon";
            Text = "Chi Tiết Hóa Đơn";
            panelHeader.ResumeLayout(false);
            panelHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvChiTiet).EndInit();
            panelBottom.ResumeLayout(false);
            panelTotals.ResumeLayout(false);
            panelTotals.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label lblSDT;
        private Panel panel1;
        private DataGridViewTextBoxColumn cStt;
        private DataGridViewTextBoxColumn cTen;
        private DataGridViewTextBoxColumn cSl;
        private DataGridViewTextBoxColumn cThanhTien;
    }
}