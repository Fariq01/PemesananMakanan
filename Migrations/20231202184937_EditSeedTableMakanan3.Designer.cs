﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using PemesananMakanan.Data;

#nullable disable

namespace PemesananMakanan.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20231202184937_EditSeedTableMakanan3")]
    partial class EditSeedTableMakanan3
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
                        },
                        new
                        {
                            MakananId = 3,
                            Harga = 3000f,
                            MakananNama = "Telor Dadar",
                            PicturePath = "/images/telorDadar.jpg"
                        },
                        new
                        {
                            MakananId = 4,
                            Harga = 5000f,
                            MakananNama = "Kulit Ayam Goreng",
                            PicturePath = "/images/KulitAyamGoreng.jpg"
                        },
                        new
                        {
                            MakananId = 5,
                            Harga = 12000f,
                            MakananNama = "Nasgor Mentega",
                            PicturePath = "/images/NasgorMentega.jpg"
                        },
                        new
                        {
                            MakananId = 6,
                            Harga = 15000f,
                            MakananNama = "Omurice",
                            PicturePath = "/images/OmuRice.jpg"
                        },
                        new
                        {
                            MakananId = 7,
                            Harga = 12000f,
                            MakananNama = "Martabak Duren",
                            PicturePath = "/images/MartabakDuren.jpg"
                        },
                        new
                        {
                            MakananId = 8,
                            Harga = 2000f,
                            MakananNama = "Es Teh",
                            PicturePath = "/images/EsTeh.jpg"
                        },
                        new
                        {
                            MakananId = 9,
                            Harga = 3000f,
                            MakananNama = "Teh Tarik",
                            PicturePath = "/images/TehTarik.jpg"
                        },
                        new
                        {
                            MakananId = 10,
                            Harga = 5000f,
                            MakananNama = "Josu",
                            PicturePath = "/images/Josu.jpg"
                        });
                });

            modelBuilder.Entity("PemesananMakanan.Models.Pesan", b =>
                {
                    b.Property<int>("PesanId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("MakananId")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("PesananId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Quantity")
                        .HasColumnType("INTEGER");

                    b.Property<float>("SubTotal")
                        .HasColumnType("REAL");

                    b.HasKey("PesanId");

                    b.HasIndex("MakananId");

                    b.HasIndex("PesananId");

                    b.ToTable("Pesans");
                });

            modelBuilder.Entity("PemesananMakanan.Models.Pesanan", b =>
                {
                    b.Property<int>("pesananId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<float>("TotalHarga")
                        .HasColumnType("REAL");

                    b.HasKey("pesananId");

                    b.ToTable("Pesanans");
                });

            modelBuilder.Entity("PemesananMakanan.Models.Pesan", b =>
                {
                    b.HasOne("PemesananMakanan.Models.Makanan", "Makanan")
                        .WithMany()
                        .HasForeignKey("MakananId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("PemesananMakanan.Models.Pesanan", "Pesanan")
                        .WithMany("Pesan")
                        .HasForeignKey("PesananId");

                    b.Navigation("Makanan");

                    b.Navigation("Pesanan");
                });

            modelBuilder.Entity("PemesananMakanan.Models.Pesanan", b =>
                {
                    b.Navigation("Pesan");
                });
#pragma warning restore 612, 618
        }
    }
}
