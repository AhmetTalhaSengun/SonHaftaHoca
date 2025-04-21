using SonHaftaHoca.Data;
using SonHaftaHoca.Models;
using SonHaftaHoca.ViewModels;

namespace SonHaftaHoca.Repostories
{
    public class EylemRepostory : BaseRepostory<Eylem>
    {
        public EylemRepostory(ToDoDbContext context) : base(context)
        {

        }

        public List<EylemVM> Listele(string id)
        {
            return _table.Select(x=> new EylemVM {
            EylemId = x.EylemId,
            Aciklama = x.Aciklama,
                EylemAdi = x.EylemAdi,
                EylemTarihi = x.EylemTarihi,
                OlusturmaTarihi = x.OlusturmaTarihi,
                EylemYapildiMi = x.EylemYapildiMi,
                KategoriAdi = x.Kategori.KategoriAdi,
                UserId = x.UserId
            }).Where(x =>x.UserId == id).ToList();
        }
    }
}
