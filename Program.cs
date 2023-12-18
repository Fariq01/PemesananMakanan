using Microsoft.EntityFrameworkCore;
using PemesananMakanan.Data;


var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseSqlite(builder.Configuration.GetConnectionString("DefaultConnection")));


var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

// Hapus semua data dari tabel Pesans
// using (var scope = app.Services.CreateScope())
// {
//     var _db = scope.ServiceProvider.GetRequiredService<AppDbContext>();
//     var pesanan = _db.Pesanans.ToList();
//     foreach (var p in pesanan)
//     {
//         _db.Pesanans.Remove(p);
//     }
//     _db.SaveChanges();
// }

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Makanan}/{action=Index}/{id?}");

app.Run();
