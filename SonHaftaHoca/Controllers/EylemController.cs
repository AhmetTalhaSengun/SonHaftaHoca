using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using SonHaftaHoca.Services.EylemService;
using SonHaftaHoca.Services.KategoriService;
using SonHaftaHoca.Services.LoginService;
using SonHaftaHoca.ViewModels;

namespace SonHaftaHoca.Controllers
{
    [Authorize]
    public class EylemController : Controller
    {
        private readonly IEylemService _eylemService;
        private readonly IMapper _mapper;
        private readonly IKategoriService _kategoriService;
        private readonly ILoginService _loginService;

        public EylemController(IEylemService eylemService, IMapper mapper, IKategoriService kategoriService, ILoginService loginService)
        {
            _eylemService = eylemService;
            _mapper = mapper;
            _kategoriService = kategoriService;
            _loginService = loginService;
        }

        public IActionResult Index()
        {
           var eylemler =  _eylemService.TumEylemler(_loginService.GetUserId(User));
            return View(eylemler);
        }

        public IActionResult Ekle()
        {
            EylemEkleVMForm frmData = new EylemEkleVMForm();
            frmData.Kategoriler = new SelectList(_kategoriService.TumKategoriler(), "KategoriId", "KategoriAdi");
            return View(frmData);
        }

        [HttpPost]

        public IActionResult Ekle(EylemEkleVM eylem)
        {
            if (ModelState.IsValid)
            {
                eylem.UserId = _loginService.GetUserId(User);
                _eylemService.EylemEkle(eylem);
                return RedirectToAction("Index");
            }
            return View();
        }
    }
}
