using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PemesananMakanan.Models
{
    public class Pesan
    {
        public int PesanId {get; set;}
        public int MakananId {get; set;}
        public Makanan Makanan {get; set;}

        [Range(1, 10, ErrorMessage = "Quantity minimal 1 !")]
        public int Quantity {get; set;}
        public float SubTotal {get; set;}

        public int? PesananId{get; set;}
        public Pesanan Pesanan {get; set;}
    
    
    }
}