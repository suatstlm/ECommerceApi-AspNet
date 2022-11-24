using AutoMapper;
using Core.Security.Entities;
using ETradeApi.Application.Features.Auths.Dtos;

namespace ETradeApi.Application.Features.Auths.Profiles
{
    public class MappingProfiles : Profile
    {
        public MappingProfiles()
        {
            CreateMap<RefreshToken, RevokedTokenDto>().ReverseMap();
        }
    }
}
