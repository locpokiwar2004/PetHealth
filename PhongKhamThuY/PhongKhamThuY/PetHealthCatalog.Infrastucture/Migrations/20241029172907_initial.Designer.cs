﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using PetHealthCatalog.Infrastucture.Context;

#nullable disable

namespace PetHealthCatalog.Infrastucture.Migrations
{
    [DbContext(typeof(PetHealthDBContext))]
    [Migration("20241029172907_initial")]
    partial class initial
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("PetHealthCatalog.Domain.Entities.BacSi", b =>
                {
                    b.Property<int>("MaBacSi")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("MaBacSi"));

                    b.Property<string>("DiaChi")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<string>("SoDienThoai")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<string>("TenBacSi")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("MaBacSi");

                    b.ToTable("BacSis");
                });

            modelBuilder.Entity("PetHealthCatalog.Domain.Entities.DatLich", b =>
                {
                    b.Property<int>("MaHen")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("MaHen"));

                    b.Property<double>("GiaKham")
                        .HasColumnType("float");

                    b.Property<DateTime?>("NgayGioHen")
                        .IsRequired()
                        .HasColumnType("datetime2");

                    b.Property<bool>("TrangThaiHen")
                        .HasColumnType("bit");

                    b.Property<bool>("TrangThaiTT")
                        .HasColumnType("bit");

                    b.HasKey("MaHen");

                    b.ToTable("DatLichs");
                });

            modelBuilder.Entity("PetHealthCatalog.Domain.Entities.HoSoThuNuoi", b =>
                {
                    b.Property<int>("MaVatNuoi")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("MaVatNuoi"));

                    b.Property<int>("CanNang")
                        .HasColumnType("int");

                    b.Property<string>("ChuanDoan")
                        .IsRequired()
                        .HasMaxLength(225)
                        .HasColumnType("nvarchar(225)");

                    b.Property<string>("LoaiVatNuoi")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TenChu")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("TenThuCung")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("TinhTrang")
                        .IsRequired()
                        .HasMaxLength(225)
                        .HasColumnType("nvarchar(225)");

                    b.Property<int>("Tuoi")
                        .HasColumnType("int");

                    b.HasKey("MaVatNuoi");

                    b.ToTable("HoSoThuNuois");
                });

            modelBuilder.Entity("PetHealthCatalog.Domain.Entities.KhachHang", b =>
                {
                    b.Property<int>("MaKhachHang")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("MaKhachHang"));

                    b.Property<string>("DiaChi")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<string>("SoDienThoai")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<string>("TenKhachHang")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("TenThuCung")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("MaKhachHang");

                    b.ToTable("KhachHangs");
                });

            modelBuilder.Entity("PetHealthCatalog.Domain.Entities.Thuoc", b =>
                {
                    b.Property<int>("MaSoThuoc")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("MaSoThuoc"));

                    b.Property<double>("GiaBan")
                        .HasColumnType("float");

                    b.Property<DateTime?>("HanSuDung")
                        .IsRequired()
                        .HasColumnType("datetime2");

                    b.Property<string>("LoaiThuoc")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("NgaySanXuat")
                        .IsRequired()
                        .HasColumnType("datetime2");

                    b.Property<int>("SoLuongThuoc")
                        .HasColumnType("int");

                    b.Property<string>("TenNSX")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("TenThuoc")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("MaSoThuoc");

                    b.ToTable("Thuocs");
                });
#pragma warning restore 612, 618
        }
    }
}
