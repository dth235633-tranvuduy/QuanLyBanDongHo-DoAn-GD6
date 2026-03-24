using System;
using System.IO;
using System.Linq;
using System.Drawing;
using System.Windows.Forms;
using System.Collections.Generic;
using LTQL_QLBHDongHo.Data;
using Microsoft.EntityFrameworkCore;

namespace LTQL_QLBHDongHo.Forms
{
    public partial class frmSanPham : Form
    {
        private QLBHDbContext context = new QLBHDbContext();
        private bool isThemMoi = false;
        private string duongDanAnhTaiLen = "";

        // Thư mục lưu ảnh: Tự động nhận diện trong Debug hoặc Release
        private string thuMucAnh = Path.Combine(Application.StartupPath, "Images");

        // Dùng BindingSource để quản lý dữ liệu đồng bộ
        private BindingSource bindingSource = new BindingSource();

        public frmSanPham()
        {
            InitializeComponent();
            if (!Directory.Exists(thuMucAnh)) Directory.CreateDirectory(thuMucAnh);

            this.Load += frmSanPham_Load;
            dgvDanhSach.SelectionChanged += DgvDanhSach_SelectionChanged;
        }
                   private void BatTatChucNang(bool giaTri)
        {
            btnLuu.Enabled = giaTri;
            btnHuy.Enabled = giaTri;
            cboThuongHieu.Enabled = giaTri;
            cboLoaiMay.Enabled = giaTri;
            txtTenSP.Enabled = giaTri;
            numSoLuong.Enabled = giaTri;
            txtGiaBan.Enabled = giaTri;
        
            picHinhAnh.Enabled = giaTri;
            btnThemSp.Enabled = !giaTri;
            btnDoiAnh.Enabled = !giaTri;
            btnSuaSP.Enabled = !giaTri;
            btnXoaSP.Enabled = !giaTri;
            btnTimKiem.Enabled = !giaTri;
            
        }
       
        public void LayHangSanXuatVaoComboBox()
        {
            // Tương tự LayLoaiSanPhamVaoComboBox()
            cboThuongHieu.DataSource = context.ThuongHieu.ToList();
            cboThuongHieu.ValueMember = "ID";
            cboThuongHieu.DisplayMember = "TenHangSanXuat";

        }
        private void frmSanPham_Load(object sender, EventArgs e)
        {
            dgvDanhSach.AutoGenerateColumns = false;
            BatTatChucNang(false);
            LayHangSanXuatVaoComboBox();
         

            List<DanhSachSanPham> sp = new List<DanhSachSanPham>();
            sp = context.SanPham.Select(r => new DanhSachSanPham
            {
                ID = r.ID,
                LoaiSanPhamID = r.LoaiSanPhamID,
                TenLoai = r.LoaiDongHoID.TenLoai,
                HangSanXuatID = r.HangSanXuatID,
                TenHangSanXuat = r.HangSanXuat.TenHangSanXuat,
                TenSanPham = r.TenSanPham,
                SoLuong = r.SoLuong,
                DonGia = r.DonGia,
                HinhAnh = r.HinhAnh,
            }).ToList();
            BindingSource bindingSource = new BindingSource();
            bindingSource.DataSource = sp;

          cboLoaiMay.DataBindings.Clear();
            cboLoaiMay.DataBindings.Add("SelectedValue", bindingSource, "LoaiSanPhamID", false, DataSourceUpdateMode.Never);

            cboThuongHieu.DataBindings.Clear();
            cboThuongHieu.DataBindings.Add("SelectedValue", bindingSource, "HangSanXuatID", false, DataSourceUpdateMode.Never);

            txtTenSP.DataBindings.Clear();
            txtTenSP.DataBindings.Add("Text", bindingSource, "TenSanPham", false, DataSourceUpdateMode.Never);

            numSoLuong.DataBindings.Clear();
            numSoLuong.DataBindings.Add("Value", bindingSource, "SoLuong", false, DataSourceUpdateMode.Never);

            txtGiaBan.DataBindings.Clear();
            txtGiaBan.DataBindings.Add("Value", bindingSource, "DonGia", false, DataSourceUpdateMode.Never);

            picHinhAnh.DataBindings.Clear();
            Binding hinhAnh = new Binding("ImageLocation", bindingSource, "HinhAnh");
            hinhAnh.Format += (s, e) =>
            {
                if (e.Value != null)
                    e.Value = Path.Combine(imagesFolder, e.Value.ToString());
                else
                    e.Value = null;
            };

            picHinhAnh.DataBindings.Add(hinhAnh);

            dataGridView.DataSource = bindingSource;

        }

        private void ResetO_Nhap()
        {
            txtMaSP.Text = "";
            txtTenSP.Text = "";
            txtGiaBan.Text = "";
            txtChatLieuDay.Text = "";
            numSoLuong.Value = 1;
            pbHinhAnh.ImageLocation = null;
            duongDanAnhTaiLen = "";
        }

        private void LoadDanhSach()
        {
            var danhSach = context.SanPham
                .Include(s => s.HangSanXuat)
                .AsNoTracking()
                .Select(s => new
                {
                    s.ID,
                    MaSP = "SP" + s.ID.ToString("D3"),
                    s.TenSanPham,
                    ThuongHieu = s.HangSanXuat != null ? s.HangSanXuat.TenHangSanXuat : string.Empty,
                    s.DonGia,
                    s.SoLuong,
                    s.HinhAnh
                }).ToList();

            bindingSource.DataSource = danhSach;
            dgvDanhSach.DataSource = bindingSource;
        }

        // ---1. CÁC HÀM HỖ TRỢ ---

        private void LoadComboBox()
        {
            // Load Thương hiệu (Hãng sản xuất)
            cboThuongHieu.DataSource = context.HangSanXuat.AsNoTracking().ToList();
            cboThuongHieu.DisplayMember = "TenHangSanXuat";
            cboThuongHieu.ValueMember = "ID";

            // Load Loại máy
            cboLoaiMay.DataSource = context.LoaiDongHo.AsNoTracking().ToList();
            cboLoaiMay.DisplayMember = "TenLoai";
            cboLoaiMay.ValueMember = "ID";
        }

        private void btnThemSp_Click(object sender, EventArgs e)
        {
            isThemMoi = true;
            ResetO_Nhap();
            TrangThaiNut(false);
            txtTenSP.Focus();
        }

        private void btnSuaSP_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMaSP.Text))
            {
                MessageBox.Show("Vui lòng chọn một sản phẩm dưới bảng để sửa!");
                return;
            }
            isThemMoi = false;
            TrangThaiNut(false);
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            TrangThaiNut(true);
            ResetO_Nhap();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtTenSP.Text) || string.IsNullOrEmpty(txtGiaBan.Text))
            {
                MessageBox.Show("Vui lòng nhập đủ Tên và Giá bán!");
                return;
            }

            try
            {
                SanPham sp;
                if (isThemMoi)
                {
                    sp = new SanPham();
                    context.SanPham.Add(sp);
                }
                else
                {
                    int id = int.Parse(txtMaSP.Text.Replace("SP", ""));
                    sp = context.SanPham.Find(id);
                }

                // Cập nhật thông tin
                sp.TenSanPham = txtTenSP.Text;
                sp.DonGia = (int)decimal.Parse(txtGiaBan.Text);
                sp.SoLuong = (int)numSoLuong.Value;
                sp.MoTa = txtChatLieuDay.Text;
                sp.HangSanXuatID = cboThuongHieu.SelectedValue != null ? (int)cboThuongHieu.SelectedValue : 0;
                sp.LoaiDongHoID = cboLoaiMay.SelectedValue != null ? (int)cboLoaiMay.SelectedValue : 0;

                // Xử lý lưu ảnh nếu người dùng có chọn ảnh mới
                if (!string.IsNullOrEmpty(duongDanAnhTaiLen))
                {
                    string tenFileAnh = Path.GetFileName(duongDanAnhTaiLen);
                    string duongDanDich = Path.Combine(thuMucAnh, tenFileAnh);
                    File.Copy(duongDanAnhTaiLen, duongDanDich, true);
                    sp.HinhAnh = tenFileAnh;
                }

                context.SaveChanges();
                MessageBox.Show("Lưu thành công!");

                TrangThaiNut(true);
                LoadDanhSach();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi lưu: " + ex.Message);
            }
        }

        private void btnXoaSP_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMaSP.Text)) return;

            if (MessageBox.Show("Bạn có chắc muốn xóa sản phẩm này?", "Xác nhận", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                int id = int.Parse(txtMaSP.Text.Replace("SP", ""));
                var sp = context.SanPham.Find(id);
                if (sp != null)
                {
                    context.SanPham.Remove(sp);
                    context.SaveChanges();
                    LoadDanhSach();
                    ResetO_Nhap();
                }
            }
        }

        private void btnChonAnh_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Filter = "Image Files|*.jpg;*.jpeg;*.png";
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    duongDanAnhTaiLen = ofd.FileName;
                    pbHinhAnh.ImageLocation = duongDanAnhTaiLen; // Hiển thị ảnh lên khung
                }
            }
        }

        private void DgvDanhSach_SelectionChanged(object? sender, EventArgs e)
        {
            try
            {
                if (dgvDanhSach.CurrentRow == null) return;
                var item = dgvDanhSach.CurrentRow.DataBoundItem as dynamic;
                if (item == null) return;
                txtMaSP.Text = item.MaSP;
                txtTenSP.Text = item.TenSanPham;
                txtGiaBan.Text = item.DonGia.ToString();
                numSoLuong.Value = item.SoLuong;
                txtChatLieuDay.Text = item.MoTa ?? string.Empty;
                if (!string.IsNullOrEmpty((string)item.HinhAnh))
                {
                    var full = Path.Combine(thuMucAnh, (string)item.HinhAnh);
                    if (File.Exists(full)) pbHinhAnh.ImageLocation = full; else pbHinhAnh.ImageLocation = null;
                }
                else pbHinhAnh.ImageLocation = null;

                // set cbo selection by matching value
                if (item.ThuongHieu != null)
                {
                    var list = (List<HangSanXuat>)cboThuongHieu.DataSource;
                    var match = list.FirstOrDefault(x => x.TenHangSanXuat == item.ThuongHieu);
                    if (match != null) cboThuongHieu.SelectedValue = match.ID;
                }
            }
            catch { }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
