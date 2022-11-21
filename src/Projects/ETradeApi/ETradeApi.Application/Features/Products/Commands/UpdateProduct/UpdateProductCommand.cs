using AutoMapper;
using ETradeApi.Application.Features.Products.Dtos;
using ETradeApi.Application.Services.Repositories;
using ETradeApi.Domain.Entities;
using MediatR;

namespace ETradeApi.Application.Features.Products.Commands.UpdateProduct
{
    public class UpdateProductCommand : IRequest<UpdatedProductDto>
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Stock { get; set; }
        public float Price { get; set; }

        public class UpdateProductCommandHandler : IRequestHandler<UpdateProductCommand, UpdatedProductDto>
        {
            private readonly IProductRepository _productRepository;
            private readonly IMapper _mapper;

            public UpdateProductCommandHandler(IProductRepository productRepository, IMapper mapper)
            {
                _productRepository = productRepository;
                _mapper = mapper;
            }

            public async Task<UpdatedProductDto> Handle(UpdateProductCommand request, CancellationToken cancellationToken)
            {
                Product mappedProduct = _mapper.Map<Product>(request);
                Product updatedProduct = await _productRepository.UpdateAsync(mappedProduct);
                UpdatedProductDto updatedProductDto = _mapper.Map<UpdatedProductDto>(updatedProduct);
                return updatedProductDto;
            }
        }
    }
}
        
