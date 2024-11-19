using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Hosting;
using PetHealthCatalog.Application.interfaces;
using PetHealthCatalog.Domain.Entities;
using PetHealthCatalog.Infrastucture.Context;

namespace PetHealthCatalog.Infrastucture.Repositories
{
    public class ModelRepositories:PetHealthRepository
    {
        private readonly PetHealthDBContext context;

        public ModelRepositories(IDbContextFactory<PetHealthDBContext> factory)
        {
            context = factory.CreateDbContext();
        }

        async Task PetHealthRepository.DeleteByIdAsync(int id)
        {
            var thuoc = await ((PetHealthRepository)this).GetByIdAsyncThuoc(id);
            var bacSi = await ((PetHealthRepository)this).GetByIdAsyncBacSi(id);
            var khachHang = await ((PetHealthRepository)this).GetByIdAsyncKhachHang(id);
            var hoSoThuNuoi = await ((PetHealthRepository)this).GetByIdAsyncHoSo(id);
            var datlich = await ((PetHealthRepository)this).GetByIdAsyncDatLich(id);
            var hoadon = await ((PetHealthRepository)this).GetByIdAsyncHoaDon(id);

            if (hoSoThuNuoi is not null)
            {
                context.HoSoThuNuois.Remove(hoSoThuNuoi); ;
                await context.SaveChangesAsync();
            }
            if (thuoc is not null)
            {
                context.Thuocs.Remove(thuoc); ;
                await context.SaveChangesAsync();
            }
            if (khachHang is not null)
            {
                context.KhachHangs.Remove(khachHang); ;
                await context.SaveChangesAsync();
            }
            if (bacSi is not null)
            {
                context.BacSis.Remove(bacSi); ;
                await context.SaveChangesAsync();
            }
            if (datlich is not null)
            {
                context.DatLichs.Remove(datlich); ;
                await context.SaveChangesAsync();
            }
            if (hoadon is not null)
            {
                context.HoaDons.Remove(hoadon); ;
                await context.SaveChangesAsync();
            }

        }

        async Task<List<Thuoc>> PetHealthRepository.GetAllAsyncThuoc()
        {
           
            var thuoc= await context.Thuocs.ToListAsync();
            return thuoc;
        }
        async Task<List<BacSi>> PetHealthRepository.GetAllAsyncBacSi()
        {

            var bacSi = await context.BacSis.ToListAsync();
            return bacSi;
        }
        async Task<List<KhachHang>> PetHealthRepository.GetAllAsyncKhachHang()
        {

            var khachHang = await context.KhachHangs.ToListAsync();
            return khachHang;
        }
        async Task<List<HoSoThuNuoi>> PetHealthRepository.GetAllAsyncHoSo()
        {

            var HosoThuNuoi = await context.HoSoThuNuois.ToListAsync();
            return HosoThuNuoi;
        }

        async Task<Thuoc?> PetHealthRepository.GetByIdAsyncThuoc(int id)
        {
            var thuoc = await context.Thuocs.FirstOrDefaultAsync(e => e.MaSoThuoc == id);
            return thuoc;
        }
        async Task<BacSi?> PetHealthRepository.GetByIdAsyncBacSi(int id)
        {
            var bacSi = await context.BacSis.FirstOrDefaultAsync(e => e.MaBacSi == id);
            return bacSi;
        }
        async Task<KhachHang?> PetHealthRepository.GetByIdAsyncKhachHang(int id)
        {
            var khachHang = await context.KhachHangs.FirstOrDefaultAsync(e => e.MaKhachHang == id);
            return khachHang;
        }
        async Task<HoSoThuNuoi?> PetHealthRepository.GetByIdAsyncHoSo(int id)
        {
            var hoSo = await context.HoSoThuNuois.FirstOrDefaultAsync(e => e.MaVatNuoi == id);
            return hoSo;
        }

        public Task AddAsyncThuoc(Thuoc thuoc)
        {
            context.Thuocs.Add(thuoc);
            return context.SaveChangesAsync();
        }

        public Task AddAsyncBacSi(BacSi BacSi)
        {
            context.BacSis.Add(BacSi);
            return context.SaveChangesAsync();
        }

        public Task AddAsyncKhachHang(KhachHang KhachHang)
        {
            context.KhachHangs.Add(KhachHang);
            return context.SaveChangesAsync();
        }

        public Task AddAsyncHoSo(HoSoThuNuoi HoSoThuNuoi)
        {
            context.HoSoThuNuois.Add(HoSoThuNuoi);
            return context.SaveChangesAsync();
        }
        public Task AddAsyncDatLich(DatLich DatLich)
        {
            context.DatLichs.Add(DatLich);
            return context.SaveChangesAsync();
        }

        public async Task<List<DatLich>> GetAllAsyncDatLich()
        {
            var datlich = await context.DatLichs.ToListAsync();
            return datlich;
        }

        public async Task<DatLich> GetByIdAsyncDatLich(int id)
        {
            var datlich = await context.DatLichs.FirstOrDefaultAsync(e => e.MaHen == id);
            return datlich;
        }

       

        public Task AddAsyncHoaDon(HoaDon HoaDon)
        {
            context.HoaDons.Add(HoaDon);
            return context.SaveChangesAsync();
        }

        public async Task<List<HoaDon>> GetAllAsyncHoaDon()
        {
            var hoadon = await context.HoaDons.ToListAsync();
            return hoadon;
        }

        public async Task<HoaDon> GetByIdAsyncHoaDon(int id)
        {
            var hoadon = await context.HoaDons.FirstOrDefaultAsync(e => e.MaHoaDon == id);
            return hoadon;
        }

        public async Task UpdateAsyncHoaDon(HoaDon hoaDon)
        {
            context.Entry(hoaDon).State = EntityState.Modified;
            await context.SaveChangesAsync(); 
        }

        public async Task UpdateAsyncThuoc(Thuoc thuoc)
        {
            context.Entry(thuoc).State = EntityState.Modified;
            await context.SaveChangesAsync();
        }

        public async Task UpdateAsyncBacSi(BacSi bacSi)
        {
            context.Entry(bacSi).State = EntityState.Modified;
            await context.SaveChangesAsync();
        }

        public async Task UpdateAsyncHoSo(HoSoThuNuoi HoSo)
        {
            context.Entry(HoSo).State = EntityState.Modified;
            await context.SaveChangesAsync();
        }

        public async Task UpdateAsyncKhachHang(KhachHang KhangHang)
        {
            context.Entry(KhangHang).State = EntityState.Modified;
            await context.SaveChangesAsync();
        }

        public async Task UpdateAsyncDatLich(DatLich DatLich)
        {
            context.Entry(DatLich).State = EntityState.Modified;
            await context.SaveChangesAsync();
        }

        public async Task<List<KhachHang>> SearchKhachHangAsync(string searchTerm)
        {
            if (string.IsNullOrWhiteSpace(searchTerm))
                return await ((PetHealthRepository)this).GetAllAsyncKhachHang();

            searchTerm = searchTerm.ToLower();
            return await context.KhachHangs
                .Where(k => k.TenKhachHang.ToLower().Contains(searchTerm))
                .ToListAsync();
        }

        public async Task<List<BacSi>> SearchBacSiAsync(string searchTerm)
        {
            if (string.IsNullOrWhiteSpace(searchTerm))
                return await ((PetHealthRepository)this).GetAllAsyncBacSi();

            searchTerm = searchTerm.ToLower();
            return await context.BacSis
                .Where(k => k.TenBacSi.ToLower().Contains(searchTerm))
                .ToListAsync();
        }

        public async Task<List<DatLich>> SearchDatLichAsync(string searchTerm)
        {
            if (string.IsNullOrWhiteSpace(searchTerm))
                return await ((PetHealthRepository)this).GetAllAsyncDatLich();

            searchTerm = searchTerm.ToLower();
            return await context.DatLichs
                .Where(k => k.HovaTen.ToLower().Contains(searchTerm))
                .ToListAsync();
        }

        public async Task<List<HoaDon>> SearchHoaDonAsync(string searchTerm)
        {
            if (string.IsNullOrWhiteSpace(searchTerm))
                return await ((PetHealthRepository)this).GetAllAsyncHoaDon();

            searchTerm = searchTerm.ToLower();
            return await context.HoaDons
                .Where(k => k.TenKhachHang.ToLower().Contains(searchTerm))
                .ToListAsync();
        }

        public async Task<List<Thuoc>> SearchThuocAsync(string searchTerm)
        {
            if (string.IsNullOrWhiteSpace(searchTerm))
                return await ((PetHealthRepository)this).GetAllAsyncThuoc();

            searchTerm = searchTerm.ToLower();
            return await context.Thuocs
                .Where(k => k.TenThuoc.ToLower().Contains(searchTerm))
                .ToListAsync();
        }

        public async Task<List<HoSoThuNuoi>> SearchHoSoAsync(string searchTerm)
        {
            if (string.IsNullOrWhiteSpace(searchTerm))
                return await ((PetHealthRepository)this).GetAllAsyncHoSo();

            searchTerm = searchTerm.ToLower();
            return await context.HoSoThuNuois
                .Where(k => k.TenThuCung.ToLower().Contains(searchTerm))
                .ToListAsync();
        }
    }
}
