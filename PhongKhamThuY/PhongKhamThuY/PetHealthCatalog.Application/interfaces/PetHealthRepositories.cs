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

        Task<List<Thuoc>> GetAllAsyncThuoc();
        Task<List<KhachHang>> GetAllAsyncKhachHang();
        Task<List<HoSoThuNuoi>> GetAllAsyncHoSo();
        Task<List<BacSi>> GetAllAsyncBacSi();
        Task<List<DatLich>> GetAllAsyncDatLich();

        Task<Thuoc> GetByIdAsyncThuoc(int id);
        Task<KhachHang> GetByIdAsyncKhachHang(int id);
        Task<HoSoThuNuoi> GetByIdAsyncHoSo(int id);
        Task<BacSi> GetByIdAsyncBacSi(int id);
        Task<DatLich> GetByIdAsyncDatLich(int id);

        Task UpdateAsyncThuoc(Thuoc thuoc);
        Task UpdateAsyncBacSi(BacSi bacSi);
        Task UpdateAsyncHoSo(HoSoThuNuoi HoSo);
        Task UpdateAsyncKhachHang(KhachHang KhangHang);
        Task UpdateAsyncDatLich(DatLich DatLich);

        Task DeleteByIdAsync(int id);
    }
}
