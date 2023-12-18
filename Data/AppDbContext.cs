using Microsoft.EntityFrameworkCore;
using PemesananMakanan.Models;

namespace PemesananMakanan.Data;

public class AppDbContext : DbContext
{
    private readonly IConfiguration _configuration;

 //Konfigurasi applicationDbContext(DB) untuk desktop app atau konsol, dan tanpa dependency injection

    // public AppDbContext(IConfiguration configuration)
    // {
    //     _configuration = configuration;
    // }
    
    // protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    // {
    //     optionsBuilder.UseSqlite(_configuration.GetConnectionString("DefaultConnection"));
    // }

    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {

    }

    public DbSet<Makanan> Makanans {get; set;}
    public DbSet<Pesan> Pesans {get; set;}
    public DbSet<Pesanan> Pesanans {get; set;}

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Makanan>().HasData
        (
            new Makanan{ MakananId = 1,  MakananNama = "Indomie", Harga = 5000, PicturePath = "/images/indomie.jpg"},
            new Makanan{ MakananId = 2,  MakananNama = "Telor Ceplok", Harga = 3000, PicturePath = "/images/telorCeplok.jpg"},
            new Makanan{ MakananId = 3,  MakananNama = "Telor Dadar", Harga = 3000, PicturePath = "/images/telorDadar.jpg"},
            new Makanan{ MakananId = 4,  MakananNama = "Kulit Ayam Goreng", Harga = 5000, PicturePath = "/images/KulitAyamGoreng.jpg"},
            new Makanan{ MakananId = 5,  MakananNama = "Nasgor Mentega", Harga = 12000, PicturePath = "/images/NasgorMentega.jpg"},
            new Makanan{ MakananId = 6,  MakananNama = "Omurice", Harga = 15000, PicturePath = "/images/OmuRice.jpg"},
            new Makanan{ MakananId = 7,  MakananNama = "Martabak Duren", Harga = 12000, PicturePath = "/images/MartabakDuren.jpg"},
            new Makanan{ MakananId = 8,  MakananNama = "Es Teh", Harga = 2000, PicturePath = "/images/EsTeh.jpg"},
            new Makanan{ MakananId = 9,  MakananNama = "Teh Tarik", Harga = 3000, PicturePath = "/images/TehTarik.jpg"},
            new Makanan{ MakananId = 10, MakananNama = "Josu", Harga = 5000, PicturePath = "/images/Josu.jpg"}
        );
    }




}