using System;
using System.ComponentModel.DataAnnotations;

namespace PetHealthCatalog.Domain.Entities
{
        public class Thuoc
        {
            [Key]
            public int MaSoThuoc { get; set; }

            [Required(ErrorMessage = "Hãy Nhập Tên Thuốc")]
            [StringLength(100)]
            public string? TenThuoc { get; set; }

            [Required(ErrorMessage = "Hãy Nhập Ngày Sản Xuất")]
            public DateTime? NgaySanXuat { get; set; }

            [Required(ErrorMessage = "Hãy Nhập Hạn Sử Dụng")]
            public DateTime? HanSuDung { get; set; }

            [Required(ErrorMessage = "Hãy Nhập Số Lượng Thuốc")]
            public int SoLuongThuoc { get; set; }

            [Required(ErrorMessage = "Hãy Nhập Giá Bán")]
            public double GiaBan { get; set; }

            [Required(ErrorMessage = "Hãy Nhập Tên Nhà Sản Xuất")]
            [StringLength(100)]
            public string? TenNSX { get; set; }

            [Required(ErrorMessage = "Hãy Nhập Loại Thuốc")]
            public string? LoaiThuoc { get; set; }

            public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
            {
                if (NgaySanXuat.HasValue && HanSuDung.HasValue)
                {
                    if (HanSuDung.Value <= NgaySanXuat.Value)
                    {
                        yield return new ValidationResult("Hạn sử dụng phải sau ngày sản xuất.", new[] { nameof(HanSuDung) });
                    }
                }
            }
        }
    }

