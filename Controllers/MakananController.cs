using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using PemesananMakanan.Data;
using PemesananMakanan.Models;


namespace PemesananMakanan.Controllers
{
    public class MakananController : Controller
    {
        private readonly AppDbContext _db;

        public MakananController(AppDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            //var = DbSet<Makanan>
            
            var makanan = _db.Makanans;
            return View(makanan);
        }

        public IActionResult Search(string input)
        {
          
            var FullMakanan = _db.Makanans;

            if(input == null)
            {
                return View("Index", FullMakanan);
            }
            else
            {

                var makanan = _db.Makanans
                .Where(m => m.MakananNama
                .ToLower()
                .Contains(input.ToLower())).ToList();
                return View("Index", makanan);

            }
        }

   

    }
}