using AutoMapper;
using SonHaftaHoca.Models;
using SonHaftaHoca.Repostories;
using SonHaftaHoca.ViewModels;

namespace SonHaftaHoca.Services.EylemService
{
    public class EylemService : IEylemService
    {
        private readonly EylemRepostory _eylemRepostory;
        private readonly IMapper _mapper;

        public EylemService(EylemRepostory eylemRepostory, IMapper mapper)
        {
            _eylemRepostory = eylemRepostory;
            _mapper = mapper;
        }

        public void EylemEkle(EylemEkleVM eylem)
        {
            Eylem yeniEylem = new Eylem();
            _mapper.Map(eylem, yeniEylem);
            yeniEylem.OlusturmaTarihi = DateTime.Now;
            yeniEylem.EylemYapildiMi = false;

            _eylemRepostory.Ekle(yeniEylem);
        }

        public List<EylemVM> TumEylemler(string id)
        {
            return  _eylemRepostory.Listele(id);
            
        }
    }
}
