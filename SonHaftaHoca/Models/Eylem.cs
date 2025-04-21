namespace SonHaftaHoca.Models
{
    public class Eylem
    {
        public int EylemId { get; set; }

        public string EylemAdi { get; set; }

        public string Aciklamas { get; set; }

        public DateTime OlusturmaTarihi { get; set; }

        public DateTime EylemTarihi { get; set; }

        public int KategoriId { get; set; }

        public Kategori? Kategori { get; set; }

    }
}
