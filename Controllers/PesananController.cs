using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PemesananMakanan.Data;
using PemesananMakanan.Models;

namespace PemesananMakanan.Controllers
{
    public class PesananController : Controller
    {
        private readonly AppDbContext _db;

        public PesananController(AppDbContext db)
        {
            _db = db;
        }

        public void Startup()
        {
            var pesanan = _db.Pesanans.ToList();
            foreach(var p in pesanan)
            {
                _db.Pesanans.Remove(p);
            }
            _db.SaveChanges();
        }

        public IActionResult Index()
        {
            var pesanan = _db.Pesanans
            .Include(p=>p.Pesan)
            .ThenInclude(pesan => pesan.Makanan)
            .ToList();
            return View(pesanan);
        }

        public IActionResult AddPesanan()
        {
            var pesans = _db.Pesans
            .Where(p => p.PesananId.HasValue == false)
            .ToList();

            if(pesans.Count > 0)
            {
                //buat pesanan
                var pesanan = new Pesanan();
                _db.Pesanans.Add(pesanan);
                _db.SaveChanges();

                //tambah semua pesan ke pesanan, dari pesananId
                foreach(var pesan in pesans)
                {
                    pesan.PesananId = pesanan.pesananId;
                    pesanan.TotalHarga += pesan.SubTotal;
                }

                _db.SaveChanges();
            }

            return RedirectToAction("Index", "Pesanan");
        }

        public IActionResult DeletePesanan(int id)
        {
            var pesanan = _db.Pesanans.Find(id);
            if (pesanan == null)
            {
                return NotFound();
            }

            _db.Pesanans.Remove(pesanan);
            _db.SaveChanges();

            return RedirectToAction("Index", "Pesanan");
        }
    }
}