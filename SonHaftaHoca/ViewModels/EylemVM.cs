using System.ComponentModel.DataAnnotations.Schema;

namespace SonHaftaHoca.ViewModels
{
    public class EylemVM
    {
        public int EylemId { get; set; }

        public string EylemAdi { get; set; }

        public string Aciklama { get; set; }

        public DateTime OlusturmaTarihi { get; set; }

        public DateTime EylemTarihi { get; set; }

        public bool EylemYapildiMi { get; set; }

        [ForeignKey("User")]
        public string UserId { get; set; }
        public string KategoriAdi { get; set; }
    }
}
