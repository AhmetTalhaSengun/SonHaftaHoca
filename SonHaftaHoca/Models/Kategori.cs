namespace SonHaftaHoca.Models
{
    public class Kategori
    {
        public int KategoriId { get; set; }

        public string KategoriAdi { get; set; }

        public ICollection<Eylem>? Eylemler { get; set; }
    }
}
