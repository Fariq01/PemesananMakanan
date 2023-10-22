using Microsoft.EntityFrameworkCore;
using PemesananMakanan.Models;

public class AppDbContext : DbContext
{
    public DbSet<Makanan> Makanans {get; set;}
    public DbSet<Pesanan> Pesanans {get; set;}

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=MyDatabase;");
    }
}