using Microsoft.EntityFrameworkCore;
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

        Task PetHealthRepository.AddAsyncThuoc(Thuoc thuoc)
        {
            context.Thuocs.Add(thuoc);
            return context.SaveChangesAsync();
        }

        Task PetHealthRepository.AddAsyncBacSi(BacSi BacSi)
        {
            context.BacSis.Add(BacSi);
            return context.SaveChangesAsync();
        }

        Task PetHealthRepository.AddAsyncKhachHang(KhachHang KhachHang)
        {
            context.KhachHangs.Add(KhachHang);
            return context.SaveChangesAsync();
        }

        Task PetHealthRepository.AddAsyncHoSo(HoSoThuNuoi HoSoThuNuoi)
        {
            context.HoSoThuNuois.Add(HoSoThuNuoi);
            return context.SaveChangesAsync();
        }

        Task PetHealthRepository.UpdateAsyncThuoc(Thuoc thuoc)
        {
            context.Entry(thuoc).State = EntityState.Modified;
            return context.SaveChangesAsync(); throw new NotImplementedException();
        }

        Task PetHealthRepository.UpdateAsyncBacSi(BacSi bacSi)
        {
            context.Entry(bacSi).State = EntityState.Modified;
            return context.SaveChangesAsync();
        }

        Task PetHealthRepository.UpdateAsyncHoSo(HoSoThuNuoi HoSo)
        {
            context.Entry(HoSo).State = EntityState.Modified;
            return context.SaveChangesAsync();
        }

        Task PetHealthRepository.UpdateAsyncKhachHang(KhachHang KhangHang)
        {
            context.Entry(KhangHang).State = EntityState.Modified;
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

        public Task UpdateAsyncDatLich(DatLich DatLich)
        {
            context.Entry(DatLich).State = EntityState.Modified;
            return context.SaveChangesAsync(); throw new NotImplementedException();
        }
    }
}
