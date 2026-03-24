namespace LTQL_QLBHDongHo.Forms
{
    partial class frmSanPham
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.GroupBox groupInfo;
        private System.Windows.Forms.Label lblMaSP;
        private System.Windows.Forms.TextBox txtMaSP;
        private System.Windows.Forms.Label lblTenSP;
        private System.Windows.Forms.TextBox txtTenSP;
        private System.Windows.Forms.Label lblGiaBan;
        private System.Windows.Forms.TextBox txtGiaBan;
        private System.Windows.Forms.Label lblThuongHieu;
        private System.Windows.Forms.ComboBox cboThuongHieu;
        private System.Windows.Forms.Label lblLoaiMay;
        private System.Windows.Forms.ComboBox cboLoaiMay;
        private System.Windows.Forms.Label lblChatLieuDay;
        private System.Windows.Forms.TextBox txtChatLieuDay;
        private System.Windows.Forms.Label lblSoLuong;
        private System.Windows.Forms.NumericUpDown numSoLuong;
        private System.Windows.Forms.Button btnChonAnh;
        private System.Windows.Forms.FlowLayoutPanel flowButtons;
        private System.Windows.Forms.Button btnThemSp;
        private System.Windows.Forms.Button btnSuaSP;
        private System.Windows.Forms.Button btnXoaSP;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Panel panelListTop;
        private System.Windows.Forms.Label lblListTitle;
        private System.Windows.Forms.DataGridView dgvDanhSach;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;

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
            groupInfo = new GroupBox();
            picHinhAnh = new PictureBox();
            btnXoayAnh = new Button();
            btnNhapThongSoKyThuat = new Button();
            btnDoiAnh = new Button();
            btnChonAnh = new Button();
            lblMaSP = new Label();
            txtMaSP = new TextBox();
            lblTenSP = new Label();
            txtTenSP = new TextBox();
            lblGiaBan = new Label();
            txtGiaBan = new TextBox();
            lblThuongHieu = new Label();
            cboThuongHieu = new ComboBox();
            lblLoaiMay = new Label();
            cboLoaiMay = new ComboBox();
            lblChatLieuDay = new Label();
            txtChatLieuDay = new TextBox();
            lblSoLuong = new Label();
            numSoLuong = new NumericUpDown();
            flowButtons = new FlowLayoutPanel();
            btnThemSp = new Button();
            btnSuaSP = new Button();
            btnXoaSP = new Button();
            btnLuu = new Button();
            btnHuy = new Button();
            btnTimKiem = new Button();
            panelListTop = new Panel();
            lblListTitle = new Label();
            dgvDanhSach = new DataGridView();
            cStt = new DataGridViewTextBoxColumn();
            cMaSP = new DataGridViewTextBoxColumn();
            cTen = new DataGridViewTextBoxColumn();
            cThuongHieu = new DataGridViewTextBoxColumn();
            cGia = new DataGridViewTextBoxColumn();
            cSoLuong = new DataGridViewTextBoxColumn();
            Anh = new DataGridViewImageColumn();
            Xem = new DataGridViewButtonColumn();
            openFileDialog1 = new OpenFileDialog();
            groupInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picHinhAnh).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numSoLuong).BeginInit();
            flowButtons.SuspendLayout();
            panelListTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDanhSach).BeginInit();
            SuspendLayout();
            // 
            // groupInfo
            // 
            groupInfo.Controls.Add(picHinhAnh);
            groupInfo.Controls.Add(btnXoayAnh);
            groupInfo.Controls.Add(btnNhapThongSoKyThuat);
            groupInfo.Controls.Add(btnDoiAnh);
            groupInfo.Controls.Add(btnChonAnh);
            groupInfo.Controls.Add(lblMaSP);
            groupInfo.Controls.Add(txtMaSP);
            groupInfo.Controls.Add(lblTenSP);
            groupInfo.Controls.Add(txtTenSP);
            groupInfo.Controls.Add(lblGiaBan);
            groupInfo.Controls.Add(txtGiaBan);
            groupInfo.Controls.Add(lblThuongHieu);
            groupInfo.Controls.Add(cboThuongHieu);
            groupInfo.Controls.Add(lblLoaiMay);
            groupInfo.Controls.Add(cboLoaiMay);
            groupInfo.Controls.Add(lblChatLieuDay);
            groupInfo.Controls.Add(txtChatLieuDay);
            groupInfo.Controls.Add(lblSoLuong);
            groupInfo.Controls.Add(numSoLuong);
            groupInfo.Controls.Add(flowButtons);
            groupInfo.Dock = DockStyle.Top;
            groupInfo.Location = new Point(0, 0);
            groupInfo.Margin = new Padding(4);
            groupInfo.Name = "groupInfo";
            groupInfo.Padding = new Padding(15);
            groupInfo.Size = new Size(1233, 345);
            groupInfo.TabIndex = 0;
            groupInfo.TabStop = false;
            groupInfo.Text = "Thông tin sản phẩm";
            // 
            // picHinhAnh
            // 
            picHinhAnh.Location = new Point(866, 62);
            picHinhAnh.Name = "picHinhAnh";
            picHinhAnh.Size = new Size(275, 188);
            picHinhAnh.TabIndex = 20;
            picHinhAnh.TabStop = false;
            // 
            // btnXoayAnh
            // 
            btnXoayAnh.Location = new Point(638, 62);
            btnXoayAnh.Name = "btnXoayAnh";
            btnXoayAnh.Size = new Size(178, 59);
            btnXoayAnh.TabIndex = 19;
            btnXoayAnh.Text = "Xoay Ảnh";
            btnXoayAnh.UseVisualStyleBackColor = true;
            // 
            // btnNhapThongSoKyThuat
            // 
            btnNhapThongSoKyThuat.Location = new Point(418, 193);
            btnNhapThongSoKyThuat.Name = "btnNhapThongSoKyThuat";
            btnNhapThongSoKyThuat.Size = new Size(398, 56);
            btnNhapThongSoKyThuat.TabIndex = 18;
            btnNhapThongSoKyThuat.Text = "Nhập Thông Số Kỹ Thuật";
            btnNhapThongSoKyThuat.UseVisualStyleBackColor = true;
            // 
            // btnDoiAnh
            // 
            btnDoiAnh.Location = new Point(638, 127);
            btnDoiAnh.Name = "btnDoiAnh";
            btnDoiAnh.Size = new Size(178, 59);
            btnDoiAnh.TabIndex = 17;
            btnDoiAnh.Text = "Đổi Ảnh";
            btnDoiAnh.UseVisualStyleBackColor = true;
            // 
            // btnChonAnh
            // 
            btnChonAnh.Location = new Point(867, 263);
            btnChonAnh.Margin = new Padding(4);
            btnChonAnh.Name = "btnChonAnh";
            btnChonAnh.Size = new Size(275, 51);
            btnChonAnh.TabIndex = 15;
            btnChonAnh.Text = "Chọn tệp ảnh";
            btnChonAnh.Click += btnChonAnh_Click;
            // 
            // lblMaSP
            // 
            lblMaSP.AutoSize = true;
            lblMaSP.Location = new Point(15, 35);
            lblMaSP.Margin = new Padding(4, 0, 4, 0);
            lblMaSP.Name = "lblMaSP";
            lblMaSP.Size = new Size(62, 25);
            lblMaSP.TabIndex = 0;
            lblMaSP.Text = "Mã SP";
            // 
            // txtMaSP
            // 
            txtMaSP.BackColor = SystemColors.ButtonHighlight;
            txtMaSP.Location = new Point(15, 65);
            txtMaSP.Margin = new Padding(4);
            txtMaSP.Name = "txtMaSP";
            txtMaSP.ReadOnly = true;
            txtMaSP.Size = new Size(124, 31);
            txtMaSP.TabIndex = 1;
            // 
            // lblTenSP
            // 
            lblTenSP.AutoSize = true;
            lblTenSP.Location = new Point(162, 35);
            lblTenSP.Margin = new Padding(4, 0, 4, 0);
            lblTenSP.Name = "lblTenSP";
            lblTenSP.Size = new Size(144, 25);
            lblTenSP.TabIndex = 2;
            lblTenSP.Text = "Tên sản phẩm (*)";
            // 
            // txtTenSP
            // 
            txtTenSP.Location = new Point(162, 65);
            txtTenSP.Margin = new Padding(4);
            txtTenSP.Name = "txtTenSP";
            txtTenSP.Size = new Size(449, 31);
            txtTenSP.TabIndex = 3;
            // 
            // lblGiaBan
            // 
            lblGiaBan.AutoSize = true;
            lblGiaBan.Location = new Point(15, 115);
            lblGiaBan.Margin = new Padding(4, 0, 4, 0);
            lblGiaBan.Name = "lblGiaBan";
            lblGiaBan.Size = new Size(72, 25);
            lblGiaBan.TabIndex = 4;
            lblGiaBan.Text = "Giá bán";
            // 
            // txtGiaBan
            // 
            txtGiaBan.Location = new Point(15, 141);
            txtGiaBan.Margin = new Padding(4);
            txtGiaBan.Name = "txtGiaBan";
            txtGiaBan.Size = new Size(199, 31);
            txtGiaBan.TabIndex = 5;
            // 
            // lblThuongHieu
            // 
            lblThuongHieu.AutoSize = true;
            lblThuongHieu.Location = new Point(238, 115);
            lblThuongHieu.Margin = new Padding(4, 0, 4, 0);
            lblThuongHieu.Name = "lblThuongHieu";
            lblThuongHieu.Size = new Size(150, 25);
            lblThuongHieu.TabIndex = 6;
            lblThuongHieu.Text = "Hiệu thương hiệu";
            // 
            // cboThuongHieu
            // 
            cboThuongHieu.DropDownStyle = ComboBoxStyle.DropDownList;
            cboThuongHieu.Location = new Point(238, 145);
            cboThuongHieu.Margin = new Padding(4);
            cboThuongHieu.Name = "cboThuongHieu";
            cboThuongHieu.Size = new Size(249, 33);
            cboThuongHieu.TabIndex = 7;
            // 
            // lblLoaiMay
            // 
            lblLoaiMay.AutoSize = true;
            lblLoaiMay.Location = new Point(15, 188);
            lblLoaiMay.Margin = new Padding(4, 0, 4, 0);
            lblLoaiMay.Name = "lblLoaiMay";
            lblLoaiMay.Size = new Size(83, 25);
            lblLoaiMay.TabIndex = 8;
            lblLoaiMay.Text = "Loại máy";
            // 
            // cboLoaiMay
            // 
            cboLoaiMay.DropDownStyle = ComboBoxStyle.DropDownList;
            cboLoaiMay.Location = new Point(13, 217);
            cboLoaiMay.Margin = new Padding(4);
            cboLoaiMay.Name = "cboLoaiMay";
            cboLoaiMay.Size = new Size(149, 33);
            cboLoaiMay.TabIndex = 9;
            // 
            // lblChatLieuDay
            // 
            lblChatLieuDay.AutoSize = true;
            lblChatLieuDay.Location = new Point(182, 188);
            lblChatLieuDay.Margin = new Padding(4, 0, 4, 0);
            lblChatLieuDay.Name = "lblChatLieuDay";
            lblChatLieuDay.Size = new Size(146, 25);
            lblChatLieuDay.TabIndex = 10;
            lblChatLieuDay.Text = "Chất liệu của dây";
            // 
            // txtChatLieuDay
            // 
            txtChatLieuDay.Location = new Point(182, 218);
            txtChatLieuDay.Margin = new Padding(4);
            txtChatLieuDay.Name = "txtChatLieuDay";
            txtChatLieuDay.Size = new Size(206, 31);
            txtChatLieuDay.TabIndex = 11;
            // 
            // lblSoLuong
            // 
            lblSoLuong.AutoSize = true;
            lblSoLuong.Location = new Point(511, 115);
            lblSoLuong.Margin = new Padding(4, 0, 4, 0);
            lblSoLuong.Name = "lblSoLuong";
            lblSoLuong.Size = new Size(85, 25);
            lblSoLuong.TabIndex = 12;
            lblSoLuong.Text = "Số lượng";
            // 
            // numSoLuong
            // 
            numSoLuong.Location = new Point(511, 147);
            numSoLuong.Margin = new Padding(4);
            numSoLuong.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            numSoLuong.Name = "numSoLuong";
            numSoLuong.Size = new Size(100, 31);
            numSoLuong.TabIndex = 13;
            numSoLuong.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // flowButtons
            // 
            flowButtons.Controls.Add(btnThemSp);
            flowButtons.Controls.Add(btnSuaSP);
            flowButtons.Controls.Add(btnXoaSP);
            flowButtons.Controls.Add(btnLuu);
            flowButtons.Controls.Add(btnHuy);
            flowButtons.Controls.Add(btnTimKiem);
            flowButtons.Location = new Point(15, 260);
            flowButtons.Margin = new Padding(4);
            flowButtons.Name = "flowButtons";
            flowButtons.Size = new Size(801, 55);
            flowButtons.TabIndex = 16;
            // 
            // btnThemSp
            // 
            btnThemSp.Location = new Point(4, 4);
            btnThemSp.Margin = new Padding(4);
            btnThemSp.Name = "btnThemSp";
            btnThemSp.Size = new Size(125, 48);
            btnThemSp.TabIndex = 0;
            btnThemSp.Text = "Thêm mới";
            btnThemSp.UseVisualStyleBackColor = true;
            btnThemSp.Click += btnThemSp_Click;
            // 
            // btnSuaSP
            // 
            btnSuaSP.Location = new Point(137, 4);
            btnSuaSP.Margin = new Padding(4);
            btnSuaSP.Name = "btnSuaSP";
            btnSuaSP.Size = new Size(125, 48);
            btnSuaSP.TabIndex = 1;
            btnSuaSP.Text = "Sửa";
            btnSuaSP.UseVisualStyleBackColor = true;
            btnSuaSP.Click += btnSuaSP_Click;
            // 
            // btnXoaSP
            // 
            btnXoaSP.Location = new Point(270, 4);
            btnXoaSP.Margin = new Padding(4);
            btnXoaSP.Name = "btnXoaSP";
            btnXoaSP.Size = new Size(125, 48);
            btnXoaSP.TabIndex = 2;
            btnXoaSP.Text = "Xóa";
            btnXoaSP.UseVisualStyleBackColor = true;
            btnXoaSP.Click += btnXoaSP_Click;
            // 
            // btnLuu
            // 
            btnLuu.Location = new Point(403, 4);
            btnLuu.Margin = new Padding(4);
            btnLuu.Name = "btnLuu";
            btnLuu.Size = new Size(125, 48);
            btnLuu.TabIndex = 3;
            btnLuu.Text = "Lưu";
            btnLuu.UseVisualStyleBackColor = true;
            btnLuu.Click += btnLuu_Click;
            // 
            // btnHuy
            // 
            btnHuy.Location = new Point(536, 4);
            btnHuy.Margin = new Padding(4);
            btnHuy.Name = "btnHuy";
            btnHuy.Size = new Size(125, 48);
            btnHuy.TabIndex = 4;
            btnHuy.Text = "Hủy";
            btnHuy.UseVisualStyleBackColor = true;
            btnHuy.Click += btnHuy_Click;
            // 
            // btnTimKiem
            // 
            btnTimKiem.Location = new Point(669, 4);
            btnTimKiem.Margin = new Padding(4);
            btnTimKiem.Name = "btnTimKiem";
            btnTimKiem.Size = new Size(125, 48);
            btnTimKiem.TabIndex = 5;
            btnTimKiem.Text = "Tìm Kiếm ";
            btnTimKiem.UseVisualStyleBackColor = true;
            // 
            // panelListTop
            // 
            panelListTop.Controls.Add(lblListTitle);
            panelListTop.Dock = DockStyle.Top;
            panelListTop.Location = new Point(0, 345);
            panelListTop.Margin = new Padding(4);
            panelListTop.Name = "panelListTop";
            panelListTop.Padding = new Padding(15);
            panelListTop.Size = new Size(1233, 45);
            panelListTop.TabIndex = 1;
            // 
            // lblListTitle
            // 
            lblListTitle.AutoSize = true;
            lblListTitle.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblListTitle.Location = new Point(15, 12);
            lblListTitle.Margin = new Padding(4, 0, 4, 0);
            lblListTitle.Name = "lblListTitle";
            lblListTitle.Size = new Size(255, 25);
            lblListTitle.TabIndex = 0;
            lblListTitle.Text = "Danh sách mặt hàng hiện tại";
            // 
            // dgvDanhSach
            // 
            dgvDanhSach.AllowUserToAddRows = false;
            dgvDanhSach.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvDanhSach.BackgroundColor = Color.White;
            dgvDanhSach.BorderStyle = BorderStyle.None;
            dgvDanhSach.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDanhSach.Columns.AddRange(new DataGridViewColumn[] { cStt, cMaSP, cTen, cThuongHieu, cGia, cSoLuong, Anh, Xem });
            dgvDanhSach.Dock = DockStyle.Fill;
            dgvDanhSach.Location = new Point(0, 390);
            dgvDanhSach.Margin = new Padding(4);
            dgvDanhSach.Name = "dgvDanhSach";
            dgvDanhSach.ReadOnly = true;
            dgvDanhSach.RowHeadersVisible = false;
            dgvDanhSach.RowHeadersWidth = 62;
            dgvDanhSach.RowTemplate.Height = 28;
            dgvDanhSach.Size = new Size(1233, 360);
            dgvDanhSach.TabIndex = 2;
            // 
            // cStt
            // 
            cStt.FillWeight = 5F;
            cStt.HeaderText = "STT";
            cStt.MinimumWidth = 8;
            cStt.Name = "cStt";
            cStt.ReadOnly = true;
            // 
            // cMaSP
            // 
            cMaSP.DataPropertyName = "ID";
            cMaSP.FillWeight = 12F;
            cMaSP.HeaderText = "MÃ SP";
            cMaSP.MinimumWidth = 8;
            cMaSP.Name = "cMaSP";
            cMaSP.ReadOnly = true;
            // 
            // cTen
            // 
            cTen.DataPropertyName = "TenSanPham";
            cTen.FillWeight = 40F;
            cTen.HeaderText = "TÊN ĐỒNG HỒ";
            cTen.MinimumWidth = 8;
            cTen.Name = "cTen";
            cTen.ReadOnly = true;
            // 
            // cThuongHieu
            // 
            cThuongHieu.DataPropertyName = "ThuongHieu";
            cThuongHieu.FillWeight = 25F;
            cThuongHieu.HeaderText = "THƯƠNG HIỆU";
            cThuongHieu.MinimumWidth = 8;
            cThuongHieu.Name = "cThuongHieu";
            cThuongHieu.ReadOnly = true;
            // 
            // cGia
            // 
            cGia.DataPropertyName = "DonGia";
            cGia.FillWeight = 15F;
            cGia.HeaderText = "GIÁ BÁN";
            cGia.MinimumWidth = 8;
            cGia.Name = "cGia";
            cGia.ReadOnly = true;
            // 
            // cSoLuong
            // 
            cSoLuong.DataPropertyName = "SoLuong";
            cSoLuong.FillWeight = 10F;
            cSoLuong.HeaderText = "SỐ LƯỢNG";
            cSoLuong.MinimumWidth = 8;
            cSoLuong.Name = "cSoLuong";
            cSoLuong.ReadOnly = true;
            // 
            // Anh
            // 
            Anh.FillWeight = 10F;
            Anh.HeaderText = "ẢNH";
            Anh.MinimumWidth = 8;
            Anh.Name = "Anh";
            Anh.ReadOnly = true;
            // 
            // Xem
            // 
            Xem.DataPropertyName = "Xem";
            Xem.FillWeight = 5F;
            Xem.HeaderText = "XEM";
            Xem.MinimumWidth = 8;
            Xem.Name = "Xem";
            Xem.ReadOnly = true;
            // 
            // openFileDialog1
            // 
            openFileDialog1.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp|All files (*.*)|*.*";
            // 
            // frmSanPham
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1233, 750);
            Controls.Add(dgvDanhSach);
            Controls.Add(panelListTop);
            Controls.Add(groupInfo);
            Margin = new Padding(4);
            Name = "frmSanPham";
            Text = "Quản lý sản phẩm";
            groupInfo.ResumeLayout(false);
            groupInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picHinhAnh).EndInit();
            ((System.ComponentModel.ISupportInitialize)numSoLuong).EndInit();
            flowButtons.ResumeLayout(false);
            panelListTop.ResumeLayout(false);
            panelListTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDanhSach).EndInit();
            ResumeLayout(false);

        }

        #endregion

        private Button btnNhapThongSoKyThuat;
        private Button btnDoiAnh;
        private Button btnTimKiem;
        private Button btnXoayAnh;
        private DataGridViewTextBoxColumn cStt;
        private DataGridViewTextBoxColumn cMaSP;
        private DataGridViewTextBoxColumn cTen;
        private DataGridViewTextBoxColumn cThuongHieu;
        private DataGridViewTextBoxColumn cGia;
        private DataGridViewTextBoxColumn cSoLuong;
        private DataGridViewImageColumn Anh;
        private DataGridViewButtonColumn Xem;
        private PictureBox picHinhAnh;
    }
}