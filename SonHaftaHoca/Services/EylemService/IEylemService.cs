using SonHaftaHoca.ViewModels;

namespace SonHaftaHoca.Services.EylemService
{
    public interface IEylemService
    {
        void EylemEkle(EylemEkleVM eylem);
        List<EylemVM> TumEylemler(string id);
    }
}
