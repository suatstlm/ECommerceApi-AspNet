using AutoMapper;
using Core.Persistence.Paging;
using ETradeApi.Application.Features.Brands.Commands.CreateBrand;
using ETradeApi.Application.Features.Brands.Commands.UpdateBrand;
using ETradeApi.Application.Features.Brands.Dtos;
using ETradeApi.Application.Features.Brands.Models;
using ETradeApi.Domain.Entities;

namespace ETradeApi.Application.Features.Brands.Profiles
{
    public class MappingProfiles : Profile
    {
        public MappingProfiles()
        {
            CreateMap<Brand, CreatedBrandDto>().ReverseMap();
            CreateMap<Brand, CreateBrandCommand>().ReverseMap();
            CreateMap<IPaginate<Brand>, GetListBrandModel>().ReverseMap();
            CreateMap<Brand, GetListBrandDto>().ReverseMap();
            CreateMap<Brand, GetByIdBrandDto>().ReverseMap(); 
            CreateMap<Brand, DeletedBrandDto>().ReverseMap();
            CreateMap<Brand, UpdatedBrandDto>().ReverseMap();
            CreateMap<Brand, UpdateBrandCommand>().ReverseMap();

        }
    }
}
