using AutoMapper;
using Microsoft.AspNetCore.Identity;
using SonHaftaHoca.Models;
using SonHaftaHoca.ViewModels;

namespace SonHaftaHoca.MapperClasses
{
    public class ToDoMapper : Profile
    {
        public ToDoMapper()
        {
            CreateMap<IdentityUser,RegisterVM>().ReverseMap();
            CreateMap<Eylem,EylemEkleVM>().ReverseMap();
            CreateMap<Eylem,EylemVM>().ForMember(x=>x.KategoriAdi,y=>y.MapFrom(y=>y.Kategori.KategoriAdi)).ReverseMap();

        }

        
    }
}
