# LTQL_QLBHDongHo
* Các công việc đã hoàn thành
1 Thiết kế Model chuyên sâu (Data Layer):

Hoàn thiện 9 thực thể chính trong QLBHDbContext, bao gồm các bảng quan trọng: SanPham, LoaiDongHo, HangSanXuat, ThongSoKyThuat, PhanQuyen.

Xây dựng thực thể giao dịch: HoaDon và ChiTietHoaDon để quản lý đơn hàng.

 2 Hệ thống hóa Giao diện (Forms Layer):

Triển khai bộ giao diện quản lý danh mục: frmSanPham, frmThuongHieu, frmKhachHang, frmNhanVien.

Xây dựng giao diện nghiệp vụ: frmHoaDon và ChiTiet_HoaDon (phục vụ việc tạo hóa đơn và xem chi tiết đơn hàng).

Thiết lập luồng đăng nhập (frmDangNhap) và trang chủ điều hướng (frmTrangChu).

3 Quản lý lịch sử thay đổi Database (Migrations):

Thực hiện chuỗi Migrations để cập nhật liên tục các thay đổi: từ việc khởi tạo 9 bảng đến việc bổ sung địa chỉ Khách hàng/Nhân viên.

Đảm bảo tính nhất quán của dữ liệu qua file ModelSnapshot.

**  Cấu trúc Project hiện tại
Data: Chứa các lớp POCO (Plain Old CLR Objects) định nghĩa cấu trúc bảng.

Forms: Chứa toàn bộ giao diện người dùng theo chuẩn đặt tên frm[Tên].

Migrations: Lưu trữ các bản cập nhật cấu trúc Database Code-First.

Resources: Lưu trữ tài nguyên hình ảnh đồng hồ cho hệ thống.

*** Ghi chú/Kế hoạch tiếp theo
Dự án đã vượt qua giai đoạn thiết kế khung (Skeleton).

Bước tiếp theo: Tập trung viết code xử lý sự kiện cho các nút chức năng (Thêm, Xóa, Sửa, Tìm kiếm) và kết nối dữ liệu từ Database lên DataGridView.
