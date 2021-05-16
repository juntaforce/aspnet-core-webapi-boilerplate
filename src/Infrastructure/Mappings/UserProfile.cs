using AutoMapper;
using WebApi.Boilerplate.Application.Responses.Users;
using WebApi.Boilerplate.Infrastructure.Identity;

namespace WebApi.Boilerplate.Infrastructure.Mappings
{
    public class UserProfile : Profile
    {
        public UserProfile()
        {
            CreateMap<UserResponse, ExtendedIdentityUser>().ReverseMap();
        }
    }
}