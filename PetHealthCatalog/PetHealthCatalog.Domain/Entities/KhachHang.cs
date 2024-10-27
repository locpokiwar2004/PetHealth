using System;
using System.ComponentModel.DataAnnotations;

namespace PetHealthCatalog.Domain.Entities
{
    public class KhachHang
    {
        [Key]
        public int MaKhachHang { get; set; }

        [Required(ErrorMessage = "Vui lòng nhập Họ và Tên!")]
        [StringLength(100)]
        public string? TenKhachHang { get; set; }

        [Required(ErrorMessage = "Vui lòng nhập Số điện thoại!")]
        [StringLength(10)]
        public string? SoDienThoai { get; set; }

        [Required(ErrorMessage = "Vui lòng nhập Email!")]
        [StringLength(200)]
        public string? Email { get; set; }

        [Required(ErrorMessage = "Vui lòng nhập Địa chỉ!")]
        [StringLength(100)]
        public string? DiaChi { get; set; }

        [Required(ErrorMessage = "Vui lòng nhập Tên thú cưng!")]
        [StringLength(100)]
        public string? TenThuCung { get; set; }
    }
}
