using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PetHealthCatalog.Infrastucture.Migrations
{
    /// <inheritdoc />
    public partial class model : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "BacSis",
                columns: table => new
                {
                    MaBacSi = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TenBacSi = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    SoDienThoai = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    DiaChi = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BacSis", x => x.MaBacSi);
                });

            migrationBuilder.CreateTable(
                name: "DatLichs",
                columns: table => new
                {
                    MaHen = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    GiaKham = table.Column<double>(type: "float", nullable: false),
                    TrangThaiTT = table.Column<bool>(type: "bit", nullable: false),
                    TrangThaiHen = table.Column<bool>(type: "bit", nullable: false),
                    NgayGioHen = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DatLichs", x => x.MaHen);
                });

            migrationBuilder.CreateTable(
                name: "HoSoThuNuois",
                columns: table => new
                {
                    MaVatNuoi = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TenThuCung = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    TenChu = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Tuoi = table.Column<int>(type: "int", nullable: false),
                    CanNang = table.Column<int>(type: "int", nullable: false),
                    TinhTrang = table.Column<string>(type: "nvarchar(225)", maxLength: 225, nullable: false),
                    ChuanDoan = table.Column<string>(type: "nvarchar(225)", maxLength: 225, nullable: false),
                    LoaiVatNuoi = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HoSoThuNuois", x => x.MaVatNuoi);
                });

            migrationBuilder.CreateTable(
                name: "KhachHangs",
                columns: table => new
                {
                    MaKhachHang = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TenKhachHang = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    SoDienThoai = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    DiaChi = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    TenThuCung = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KhachHangs", x => x.MaKhachHang);
                });

            migrationBuilder.CreateTable(
                name: "Thuocs",
                columns: table => new
                {
                    MaSoThuoc = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TenThuoc = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    NgaySanXuat = table.Column<DateTime>(type: "datetime2", nullable: false),
                    HanSuDung = table.Column<DateTime>(type: "datetime2", nullable: false),
                    SoLuongThuoc = table.Column<int>(type: "int", nullable: false),
                    GiaBan = table.Column<double>(type: "float", nullable: false),
                    TenNSX = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    LoaiThuoc = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Thuocs", x => x.MaSoThuoc);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BacSis");

            migrationBuilder.DropTable(
                name: "DatLichs");

            migrationBuilder.DropTable(
                name: "HoSoThuNuois");

            migrationBuilder.DropTable(
                name: "KhachHangs");

            migrationBuilder.DropTable(
                name: "Thuocs");
        }
    }
}
