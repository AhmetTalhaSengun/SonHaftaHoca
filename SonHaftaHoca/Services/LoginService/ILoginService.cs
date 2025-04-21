using AutoMapper;
using Microsoft.AspNetCore.Identity;
using SonHaftaHoca.ViewModels;
using System.Security.Claims;

namespace SonHaftaHoca.Services.LoginService
{
    public interface ILoginService
    {
        

        void Register(RegisterVM register);

        IdentityUser? Login(LoginVM login); // id string olduğu için

        string GetUserId(ClaimsPrincipal claim);
        // void Logout();




    }
}
