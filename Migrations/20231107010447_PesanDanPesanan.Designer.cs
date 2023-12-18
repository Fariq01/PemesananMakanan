﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using PemesananMakanan.Data;

#nullable disable

namespace PemesananMakanan.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20231107010447_PesanDanPesanan")]
    partial class PesanDanPesanan
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "7.0.12");

            modelBuilder.Entity("PemesananMakanan.Models.Makanan", b =>
                {
                    b.Property<int>("MakananId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<float>("Harga")
                        .HasColumnType("REAL");

                    b.Property<string>("MakananNama")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("TEXT");

                    b.Property<string>("PicturePath")
                        .HasColumnType("TEXT");

                    b.HasKey("MakananId");

                    b.ToTable("Makanans");

                    b.HasData(
                        new
                        {
                            MakananId = 1,
                            Harga = 5000f,
                            MakananNama = "Indomie",
                            PicturePath = "/images/indomie.jpg"
                        },
                        new
                        {
                            MakananId = 2,
                            Harga = 3000f,
                            MakananNama = "Telor Ceplok",
                            PicturePath = "/images/telorCeplok.jpg"
                        });
                });

            modelBuilder.Entity("PemesananMakanan.Models.Pesan", b =>
                {
                    b.Property<int>("PesanId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("MakananId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Quantity")
                        .HasColumnType("INTEGER");

                    b.Property<float>("TotalHarga")
                        .HasColumnType("REAL");

                    b.HasKey("PesanId");

                    b.HasIndex("MakananId");

                    b.ToTable("Pesans");
                });

            modelBuilder.Entity("PemesananMakanan.Models.Pesan", b =>
                {
                    b.HasOne("PemesananMakanan.Models.Makanan", "Makanan")
                        .WithMany()
                        .HasForeignKey("MakananId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Makanan");
                });
#pragma warning restore 612, 618
        }
    }
}