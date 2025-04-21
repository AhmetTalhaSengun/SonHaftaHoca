using System.ComponentModel.DataAnnotations.Schema;

namespace SonHaftaHoca.ViewModels
{
    public class EylemEkleVM
    {
        public string EylemAdi { get; set; }

        public string Aciklama { get; set; }

        public DateTime EylemTarihi { get; set; }

        [ForeignKey("User")]
        public string? UserId { get; set; }
        public int KategoriId { get; set; }
    }
}
