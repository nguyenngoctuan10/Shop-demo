using AutoMapper;
using ECommerMVC.Data;
using ECommerMVC.ViewModels;

namespace ECommerMVC.Helpers
{
    public class AutoMapperProfile: Profile
    {
        public AutoMapperProfile() {
            CreateMap<RegisterVM, KhachHang>();
                //.ForMember(kh=>kh.HoTen,option=>option.MapFrom(RegisterVM=>RegisterVM.HoTen))   
                //.ReverseMap();
        }
    }
}
