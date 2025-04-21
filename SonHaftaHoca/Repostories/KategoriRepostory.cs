using SonHaftaHoca.Data;
using SonHaftaHoca.Models;

namespace SonHaftaHoca.Repostories
{
    public class KategoriRepostory : BaseRepostory<Kategori>
    {
        public KategoriRepostory(ToDoDbContext context) : base(context)
        {
        }
    }
}
