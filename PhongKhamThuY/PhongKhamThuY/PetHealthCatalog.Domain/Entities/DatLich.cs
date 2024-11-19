using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetHealthCatalog.Domain.Entities
{
    public class DatLich
    {
        [Key]
        public int MaHen { get; set; }

        [Required(ErrorMessage = "Vui lòng nhập Số điện thoại!")]
        [StringLength(10, ErrorMessage = "Số điện thoại phải chứa đúng 10 ký tự")]
       
        public string? SoDienThoai { get; set; }

        [Required(ErrorMessage = "Vui lòng chọn Trạng Thái Thanh Toán!")]
        public string? TrangThaiTT { get; set; } 

        [Required(ErrorMessage = "Vui lòng chọn Trạng Thái Hẹn!")]
        public string? TrangThaiHen { get; set; } 

        [Required(ErrorMessage = "Vui lòng nhập Ngày Hẹn!")]
        public DateTime NgayHen { get; set; } 

        [Required(ErrorMessage = "Vui lòng nhập Tên Thú Cưng!")]
        public string? TenThuCung { get; set; }

        [Required(ErrorMessage = "Vui lòng nhập Họ và Tên Chủ Nuôi!")]
        public string? HovaTen { get; set; }

        [Required(ErrorMessage = "Vui lòng chọn loại Dịch Vụ!")]
        public string? DichVu { get; set; }

        public string? GhiChu { get; set; }
    }
}
