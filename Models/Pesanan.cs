using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PemesananMakanan.Models
{
    public class Pesanan
    {
        public int PesananId {get; set;}
        public Makanan Makanan {get; set;}
        [Range(1, int.MaxValue, ErrorMessage = "Quantity must be a positive number !")]
        public int Quantity {get; set;}
        public float SubTotal {get {return Makanan.Harga * Quantity;}}
        public float TotalHarga {get; set;}
    }
}