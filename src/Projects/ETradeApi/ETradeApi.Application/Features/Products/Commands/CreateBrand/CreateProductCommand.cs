using AutoMapper;
using ETradeApi.Application.Features.Products.Dtos;
using ETradeApi.Application.Services.Repositories;
using ETradeApi.Domain.Entities;
using MediatR;

namespace ETradeApi.Application.Features.Products.Commands.CreateBrand
{
    public class CreateProductCommand : IRequest<CreatedProductDto>
    {
        public string Name { get; set; }
        public int Stock { get; set; }
        public float Price { get; set; }

        public class CreateProductCommandHandler : IRequestHandler<CreateProductCommand, CreatedProductDto>
        {
            private readonly IProductRepository _productRepository;
            private readonly IMapper _mapper;

            public CreateProductCommandHandler(IProductRepository productRepository, IMapper mapper)
            {
                _productRepository = productRepository;
                _mapper = mapper;
            }

            public async Task<CreatedProductDto> Handle(CreateProductCommand request, CancellationToken cancellationToken)
            {
                //await _productBusinessRules.BrandNameCanNotBeDuplicatedWhenInserted(request.Name);

                Product mappedProduct = _mapper.Map<Product>(request);
                Product createdProduct = await _productRepository.AddAsync(mappedProduct);
                CreatedProductDto createdProductDto = _mapper.Map<CreatedProductDto>(createdProduct);

                return createdProductDto;
            }
        }
    }
}
