using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using PemesananMakanan.Data;
using PemesananMakanan.Models;

namespace PemesananMakanan.Controllers
{
    public class PesanController : Controller
    {
        private readonly AppDbContext _db;
        private readonly ILogger<PesanController> _logger;

        public PesanController(AppDbContext db, ILogger<PesanController> logger)
        {
            _db = db;
            _logger = logger;
        }

        public IActionResult Index()
        {
            var pesan = _db.Pesans.Include(p=>p.Makanan).ToList();
            return View(pesan);
        }

        [HttpPost]
        public IActionResult AddPesan(int id, int jumlah)
        {
            //Validasi apakah id ada di dalam makanan db
            var makanan = _db.Makanans.Find(id);
            if(makanan == null)
            {
                return NotFound();
            }

            if(jumlah == null || jumlah <=0)
            {
                TempData["Notification"] = "Jumlah tidak valid";
                // return RedirectToAction("Index", "Makanan");
            }
            else
            {
                //buat pesanan baru
                var pesan = new Pesan
                {
                    MakananId = id, 
                    Quantity = jumlah, 
                    SubTotal = makanan.Harga * jumlah
                };

                // Tambah pesanan ke db dan simpan perubahan
                _db.Pesans.Add(pesan);
                _db.SaveChanges();
                return Json(new {success = true});
            }
        
             return RedirectToAction("Index", "Makanan");
        
        }

        [HttpPost]
        // public IActionResult EditPesan(int id, [FromForm] int jumlah)
        public IActionResult EditPesan(int id, int jumlah)
        {
            //validasi db
            var pesan = _db.Pesans
            // .Find(id)
            .Include(p => p.Makanan).SingleOrDefault(p => p.PesanId == id);

            if(pesan == null)
            {
                return NotFound();
            }

            //perbarui jumlah dan subtotal
            if(pesan.Quantity <= 0 || pesan.Quantity == null || jumlah <= 0 || jumlah == null)
            {
                TempData["Notification"] = "Jumlah tidak valid";
            }else
            {
                pesan.SubTotal = pesan.SubTotal/pesan.Quantity * jumlah;
                pesan.Quantity = jumlah;
                _db.SaveChanges();
                return Json(new 
                {
                    success = true,
                    pesanId = pesan.PesanId,
                    newQuantity = pesan.Quantity,
                    newSubTotal = pesan.SubTotal
                });

                
         
            }

            // _logger.LogInformation("Quantity: {Quantity}", pesan.Quantity);
          
            // _logger.LogInformation("Quantity: {Quantity}", pesan.Quantity);
            return RedirectToAction("Index", "Makanan");
           
        }


        [HttpPost]
        public IActionResult DeletePesan(int id)
        {
            //validasi id
            var pesan = _db.Pesans.Find(id);
            if(pesan == null)
            {
                return NotFound();
            }

            //Hapus entity pesan dari db
            _db.Pesans.Remove(pesan);

            _db.SaveChanges();

            return RedirectToAction("Index", "Pesan");
        }


    }
}