using System;
using System.ComponentModel.DataAnnotations;


namespace PetHealthCatalog.Domain.Entities
{
    public class HoaDon
    {
        [Key]
        public int MaHoaDon { get; set; }

        [Required(ErrorMessage = "Vui lòng nhập Ngày Lập Hóa Đơn!")]
        public DateTime NgayLapHoaDon { get; set; }

        [Required(ErrorMessage = "Vui lòng nhập Tên Nhân Viên!")]
        [StringLength(100)]
        public string? TenNhanVien { get; set; }

        [Required(ErrorMessage = "Vui lòng nhập Tên Khách Hàng!")]
        [StringLength(100)]
        public string? TenKhachHang { get; set; }

        [Required(ErrorMessage = "Vui lòng nhập Địa Chỉ!")]
        [StringLength(100)]
        public string? DiaChi { get; set; }

        [StringLength(10, ErrorMessage = "Số điện thoại phải chứa đúng 10 ký tự")]
        public string? SoDienThoai { get; set; }

        [Required(ErrorMessage = "Vui lòng chọn loại Dịch Vụ!")]
        public string? DichVu { get; set; }

        [Required(ErrorMessage = "Vui lòng nhập Phương Thức Thanh Toán!")]
        public string? PhuongThucThanhToan { get; set; }

        [Required(ErrorMessage = "Vui lòng nhập Giá Khám!")]
        public int GiaKham { get; set; }

        [Required(ErrorMessage = "Vui lòng nhập Giá Thuốc!")]
        public int GiaThuoc { get; set; }

        [Required(ErrorMessage = "Vui lòng nhập Tổng Tiền!")]
        public int TongTien { get; set; }

    }
}