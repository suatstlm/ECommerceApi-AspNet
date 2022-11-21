using AutoMapper;
using Core.Persistence.Paging;
using ETradeApi.Application.Features.Products.Commands.CreateProduct;
using ETradeApi.Application.Features.Products.Commands.DeleteProduct;
using ETradeApi.Application.Features.Products.Commands.UpdateProduct;
using ETradeApi.Application.Features.Products.Dtos;
using ETradeApi.Application.Features.Products.Models;
using ETradeApi.Domain.Entities;

namespace ETradeApi.Application.Features.Products.Profiles
{
    public class MappingProfiles : Profile
    {
        public MappingProfiles()
        {
            CreateMap<Product, CreatedProductDto>().ReverseMap();
            CreateMap<Product, CreateProductCommand>().ReverseMap();
            CreateMap<Product, UpdateProductCommand>().ReverseMap();
            CreateMap<Product, UpdatedProductDto>().ReverseMap();
            CreateMap<IPaginate<Product>, GetListProductModel>().ReverseMap();
            CreateMap<Product, GetListProductDto>().ReverseMap();
            CreateMap<Product, GetByIdProductDto>().ReverseMap();
            CreateMap<Product, DeleteProductCommand>().ReverseMap();
            CreateMap<Product, DeletedProductDto>().ReverseMap();
        }
    }
}
