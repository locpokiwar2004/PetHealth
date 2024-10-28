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

        [Required(ErrorMessage = "Vui lòng nhập Giá Khám!")]
        public double GiaKham { get; set; } // Không cần [StringLength] vì đây là kiểu int

        [Required(ErrorMessage = "Vui lòng nhập Trạng Thái Thanh Toán!")]
        public bool TrangThaiTT { get; set; } // Không cần [StringLength] vì đây là kiểu bool

        [Required(ErrorMessage = "Vui lòng nhập Trạng Thái Hẹn!")]
        public bool TrangThaiHen { get; set; } // Không cần [StringLength] vì đây là kiểu bool

        [Required(ErrorMessage = "Vui lòng nhập Ngày Giờ Hẹn!")]
        public DateTime? NgayGioHen { get; set; } // Không cần [StringLength] vì đây là kiểu DateTime
    }
}
