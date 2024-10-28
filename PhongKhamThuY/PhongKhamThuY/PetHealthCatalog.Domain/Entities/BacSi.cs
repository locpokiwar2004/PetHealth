using System;
using System.ComponentModel.DataAnnotations;


namespace PetHealthCatalog.Domain.Entities
{
    public class BacSi
    {
        [Key]
        public int MaBacSi { get; set; }

        [Required(ErrorMessage = "Vui lòng nhập Họ và Tên!")]
        [StringLength(100)]
        public string? TenBacSi { get; set; }

        [Required(ErrorMessage = "Vui lòng nhập Số điện thoại!")]
        [StringLength(10)]
        public string? SoDienThoai { get; set; }

        [Required(ErrorMessage = "Vui lòng nhập Email!")]
        [StringLength(200)]
        public string? Email { get; set; }

        [Required(ErrorMessage = "Vui lòng nhập Địa chỉ!")]
        [StringLength(100)]
        public string? DiaChi { get; set; }
    }
}
