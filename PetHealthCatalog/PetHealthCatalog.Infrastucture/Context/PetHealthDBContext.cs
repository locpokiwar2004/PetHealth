using Microsoft.EntityFrameworkCore;
using PetHealthCatalog.Domain.Entities;
using System.Numerics;

namespace PetHealthCatalog.Infrastucture.Context
{
    public class PetHealthDBContext : DbContext
    {
        public PetHealthDBContext(DbContextOptions<PetHealthDBContext> options) : base(options)
        {

        }
        public DbSet<Thuoc> Thuocs { get; set; }
        public DbSet<KhachHang> KhachHangs { get; set; }
        public DbSet<HoSoThuNuoi> HoSoThuNuois { get; set; }
        public DbSet<BacSi> BacSis { get; set; }
        public DbSet<DatLich> DatLichs { get; set; }
    }
}
