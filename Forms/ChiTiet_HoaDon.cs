using System;
using System.Linq;
using System.Windows.Forms;
using LTQL_QLBHDongHo.Data;
using Microsoft.EntityFrameworkCore;

namespace LTQL_QLBHDongHo.Forms
{
    public partial class ChiTiet_HoaDon : Form
    {
        private readonly int? hoaDonId;
        private readonly QLBHDbContext context = new QLBHDbContext();

        public ChiTiet_HoaDon(int? id = null)
        {
            InitializeComponent();
            hoaDonId = id;
            this.Load += ChiTiet_HoaDon_Load;
        }

        private void ChiTiet_HoaDon_Load(object? sender, EventArgs e)
        {
            if (!hoaDonId.HasValue) return;
            var hd = context.HoaDon
                .Include(h => h.HoaDonChiTiet)
                .ThenInclude(ct => ct.SanPham)
                .Include(h => h.NhanVien)
                .Include(h => h.KhachHang)
                .AsNoTracking()
                .FirstOrDefault(h => h.ID == hoaDonId.Value);
            if (hd == null) return;

            // header
            lblMaHoaDon.Text = "HD" + hd.ID.ToString("D6");
            lblThoiGian.Text = hd.NgayLap.ToString("HH:mm - dd/MM/yyyy");
            lblNhanVien.Text = hd.NhanVien?.HoVaTen ?? "";
            lblKhachHang.Text = hd.KhachHang?.HoVaTen ?? "Khách lẻ";
            lblBanPhucVu.Text = ""; // nếu có thông tin bàn
            lblTrangThai.Text = "Chưa thanh toán"; // có thể map từ hd.TrangThai

            // details
            var rows = hd.HoaDonChiTiet.Select((ct, idx) => new
            {
                STT = idx + 1,
                Ten = ct.SanPham?.TenSanPham ?? string.Empty,
                DVT = "cái",
                SL = ct.SoLuongBan,
                DonGia = ct.DonGiaBan,
                ThanhTien = (long)ct.DonGiaBan * ct.SoLuongBan
            }).ToList();

            dgvChiTiet.DataSource = rows;

            // totals
            var tong = rows.Sum(r => (long)r.ThanhTien);
            lblTamTinhValue.Text = tong.ToString("N0") + " đ";
            lblGiamGiaValue.Text = "0 đ"; // placeholder
            lblTongValue.Text = tong.ToString("N0") + " đ";

            // notes
            txtGhiChu.Text = hd.GhiChuHoaDon ?? "Không có ghi chú hóa đơn.";
        }

        private void BtnIn_Click(object? sender, EventArgs e)
        {
            MessageBox.Show("Chức năng in hóa đơn chưa được triển khai.", "In hóa đơn", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void lblMaHD_Click(object sender, EventArgs e)
        {

        }

        private void panelTotals_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
