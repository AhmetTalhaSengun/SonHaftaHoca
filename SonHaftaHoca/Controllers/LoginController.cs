using AutoMapper;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using SonHaftaHoca.Services.LoginService;
using SonHaftaHoca.ViewModels;

namespace SonHaftaHoca.Controllers
{
    public class LoginController : Controller
    {

        private readonly ILoginService _loginService;
        private readonly IMapper _mapper;
        private readonly SignInManager<IdentityUser>  _signInManager;

        public LoginController(ILoginService loginService, IMapper mapper, SignInManager<IdentityUser> signInManager)
        {
            _loginService = loginService;
            _mapper = mapper;
            _signInManager = signInManager;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]

        public IActionResult Index(LoginVM login)
        {
            if (ModelState.IsValid)
            {
                IdentityUser? user = _loginService.Login(login);
                if (user != null)
                {
                    _signInManager.SignInAsync(user,false).Wait();
                    return RedirectToAction("Index", "Eylem");
                }
            }

            ModelState.AddModelError("HATA", "Kullanıcı adı veya şifre hatalı");
            return View();
        }

        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Register(RegisterVM uye)
        {
            if(ModelState.IsValid)
            {
            _loginService.Register(uye);
                return RedirectToAction("Index");
               
            }
            return View();
        }

        public IActionResult Logout()
        {
            _signInManager.SignOutAsync().Wait();
            return RedirectToAction("Index");
        }
    }
}
