using AutoMapper;
using Microsoft.AspNetCore.Identity;
using SonHaftaHoca.ViewModels;
using System.Security.Claims;

namespace SonHaftaHoca.Services.LoginService
{
    public class LoginService : ILoginService
    {
        private readonly UserManager<IdentityUser> _userManager;
        private readonly IMapper _mapper;

        public LoginService(UserManager<IdentityUser> userManager, IMapper mapper)
        {
            _userManager = userManager;
            _mapper = mapper;
        }

        public string GetUserId(ClaimsPrincipal claim)
        {
           return  _userManager.GetUserId(claim);
        }

        public IdentityUser? Login(LoginVM login)
        {
            var user = _userManager.FindByNameAsync(login.UserName).Result;
            if (user != null)
            {
                 if(_userManager.CheckPasswordAsync(user, login.Password).Result)
                {
                    //burda log outu yazarsam programı webe bağımlı hale getirmiş olurum.!!!!!!!!!
                    return user;
                }
            }

            return null;

        }

       

        public void Register(RegisterVM register)
        {
            IdentityUser newUser = new IdentityUser();
            _mapper.Map(register, newUser);
            var result =_userManager.CreateAsync(newUser, register.Password).Result;

        }
    }
}
