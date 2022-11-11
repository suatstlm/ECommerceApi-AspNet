using AutoMapper;
using ETradeApi.Application.Features.Products.Commands.CreateBrand;
using ETradeApi.Application.Features.Products.Dtos;
using ETradeApi.Domain.Entities;

namespace ETradeApi.Application.Features.Products.Profiles
{
    public class MappingProfiles : Profile
    {
        public MappingProfiles()
        {
            CreateMap<Product, CreatedProductDto>().ReverseMap();
            CreateMap<Product, CreateProductCommand>().ReverseMap();

        }
    }
}
