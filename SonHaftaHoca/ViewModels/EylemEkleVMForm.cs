using Microsoft.AspNetCore.Mvc.Rendering;

namespace SonHaftaHoca.ViewModels
{
    public class EylemEkleVMForm
    {
        public SelectList Kategoriler { get; set; }
        public EylemEkleVM Eylem { get; set; }
    }
}
