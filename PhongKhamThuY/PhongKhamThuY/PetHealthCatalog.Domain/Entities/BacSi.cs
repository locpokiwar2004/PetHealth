using System;
using System.ComponentModel.DataAnnotations;


namespace PetHealthCatalog.Domain.Entities
{
    public class BacSi
    {
        [Key]
        public int MaBacSi { get; set; }


        [Required(ErrorMessage = "Vui lòng nhập Tên Bác Sĩ!")]
        public string? TenBacSi { get; set; }

        
        [StringLength(10, ErrorMessage = "Số điện thoại phải chứa đúng 10 ký tự")]
        
        public string? SoDienThoai { get; set; }

        
        [StringLength(200)]
        [Required(ErrorMessage = "Vui lòng nhập Email!")]
        public string? Email { get; set; }

        [Required(ErrorMessage = "Vui lòng nhập Địa Chỉ!")]
        [StringLength(100)]
        public string? DiaChi { get; set; }
    }
}
