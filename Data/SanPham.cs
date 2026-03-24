using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using LTQL_QLBHDongHo.Data;
using Microsoft.EntityFrameworkCore.ChangeTracking;


namespace LTQL_QLBHDongHo.Data
{
    public class SanPham
    {
        [Key]
        public int ID { get; set; } // Tương ứng với "Mã SP" trên giao diện

        [Required]
        [StringLength(200)]
        public string TenSanPham { get; set; } = string.Empty; // "Tên sản phẩm (*)"

        public int DonGia { get; set; } // "Giá bán"

        public int SoLuong { get; set; } // "Số lượng"

        [StringLength(500)]
        public string? HinhAnh { get; set; } // Lưu tên file ảnh

        public string? ChatLieuDay { get; set; } // MỚI: Khớp với ô "Chất liệu của dây"

        public string? MoTa { get; set; } // Dùng cho nút "Nhập Thông Số Kỹ Thuật"

        [Required]
        public int HangSanXuatID { get; set; } // Liên kết với "Hiệu thương hiệu"

        [Required]
        public int LoaiDongHoID { get; set; } // Liên kết với "Loại máy"

        // --- Liên kết ngoại ---
        [ForeignKey("HangSanXuatID")]
        public virtual HangSanXuat HangSanXuat { get; set; } = null!;

        [ForeignKey("LoaiDongHoID")]
        public virtual LoaiDongHo LoaiDongHo { get; set; } = null!;

        // Các danh sách liên kết để phục vụ logic nghiệp vụ
        public virtual ObservableCollectionListSource<ThongSoKyThuat> ThongSoKyThuat { get; } = new();
        public virtual ObservableCollectionListSource<HoaDonChiTiet> HoaDonChiTiet { get; } = new();
    }
}