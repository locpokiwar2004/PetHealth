using Microsoft.EntityFrameworkCore;
using Microsoft.SqlServer.Server;
using PetHealthCatalog.Domain.Entities;
using System.Reflection;
using System.Threading.Tasks;

namespace PetHealthCatalog.Application.interfaces
{
    public interface PetHealthRepository
    {
        Task AddAsyncThuoc(Thuoc thuoc);
        Task AddAsyncBacSi(BacSi BacSi);
        Task AddAsyncKhachHang(KhachHang KhachHang);
        Task AddAsyncHoSo(HoSoThuNuoi HoSoThuNuoi);
        Task AddAsyncDatLich(DatLich DatLich);
        Task AddAsyncHoaDon(HoaDon HoaDon);

        Task<List<Thuoc>> GetAllAsyncThuoc();
        Task<List<KhachHang>> GetAllAsyncKhachHang();
        Task<List<HoSoThuNuoi>> GetAllAsyncHoSo();
        Task<List<BacSi>> GetAllAsyncBacSi();
        Task<List<DatLich>> GetAllAsyncDatLich();
        Task<List<HoaDon>> GetAllAsyncHoaDon();

        Task<Thuoc> GetByIdAsyncThuoc(int id);
        Task<KhachHang> GetByIdAsyncKhachHang(int id);
        Task<HoSoThuNuoi> GetByIdAsyncHoSo(int id);
        Task<BacSi> GetByIdAsyncBacSi(int id);
        Task<DatLich> GetByIdAsyncDatLich(int id);
        Task<HoaDon> GetByIdAsyncHoaDon(int id);

        Task UpdateAsyncThuoc(Thuoc thuoc);
        Task UpdateAsyncBacSi(BacSi bacSi);
        Task UpdateAsyncHoSo(HoSoThuNuoi HoSo);
        Task UpdateAsyncKhachHang(KhachHang KhangHang);
        Task UpdateAsyncDatLich(DatLich DatLich);
        Task UpdateAsyncHoaDon(HoaDon thuoc);

        Task DeleteByIdAsync(int id);

        Task<List<KhachHang>> SearchKhachHangAsync(string searchTerm);
        Task<List<BacSi>> SearchBacSiAsync(string searchTerm);
        Task<List<Thuoc>> SearchThuocAsync(string searchTerm);
        Task<List<HoSoThuNuoi>> SearchHoSoAsync(string searchTerm);
        Task<List<DatLich>> SearchDatLichAsync(string searchTerm);
        Task<List<HoaDon>> SearchHoaDonAsync(string searchTerm);

    }
}
