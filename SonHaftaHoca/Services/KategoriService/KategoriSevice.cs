using SonHaftaHoca.Models;
using SonHaftaHoca.Repostories;

namespace SonHaftaHoca.Services.KategoriService
{
    public class KategoriSevice : IKategoriService
    {
        private readonly KategoriRepostory _kategoriRepostory;

        public KategoriSevice(KategoriRepostory kategoriRepostory)
        {
            _kategoriRepostory = kategoriRepostory;
        }

        public List<Kategori> TumKategoriler()
        {
           return _kategoriRepostory.Listele();
        }
    }
}
