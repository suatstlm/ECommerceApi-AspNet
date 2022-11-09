using AutoMapper;
using Core.Persistence.Paging;
using ETradeApi.Application.Features.Models.Dtos;
using ETradeApi.Application.Features.Models.Models;
using ETradeApi.Domain.Entities;

namespace ETradeApi.Application.Features.Models.Profiles
{
    public class MappingProfiles: Profile
    {
        public MappingProfiles()
        {
            CreateMap<Model, GetListModelDto>()
                .ForMember(c => c.BrandName, opt => opt
                .MapFrom(c => c.Brand.Name)).ReverseMap();
            CreateMap<IPaginate<Model>, GetListModelModel>().ReverseMap();
        }
    }
}
