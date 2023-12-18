namespace PemesananMakanan.Models
{
    public class Pesanan
    {
        public int pesananId {get; set;}
        public List<Pesan> Pesan {get; set;}
        public float TotalHarga {get; set;}
    }
}