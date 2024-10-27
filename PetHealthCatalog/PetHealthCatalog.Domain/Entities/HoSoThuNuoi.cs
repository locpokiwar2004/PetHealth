using System;
using System.ComponentModel.DataAnnotations;

namespace PetHealthCatalog.Domain.Entities
{
    public class HoSoThuNuoi
    {
        [Key]
        public int MaVatNuoi { get; set; }

        [Required(ErrorMessage = "Vui lòng nhập Tên thú cưng!")]
        [StringLength(100)]
        public string? TenThuCung { get; set; }

        [Required(ErrorMessage = "Vui lòng nhập Tên chủ thú nuôi!")]
        [StringLength(100)]
        public string? TenChu { get; set; }

        [Required(ErrorMessage = "Vui lòng nhập Tuổi!")]
        public int Tuoi { get; set; }

        [Required(ErrorMessage = "Vui lòng nhập Cân nặng!")]
        public int CanNang { get; set; }

        [Required(ErrorMessage = "Vui lòng nhập Tình trạng!")]
        [StringLength(225)]
        public string? TinhTrang { get; set; }

        [Required(ErrorMessage = "Vui lòng nhập Kết quả chuẩn đoán!")]
        [StringLength(225)]
        public string? ChuanDoan { get; set; }

        [Required(ErrorMessage = "Vui lòng chọn loại vật nuôi!")]
        public string? LoaiVatNuoi { get; set; }
    }
}
