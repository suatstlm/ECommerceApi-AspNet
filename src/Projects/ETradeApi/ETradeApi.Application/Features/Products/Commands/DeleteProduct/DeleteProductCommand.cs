using AutoMapper;
using ETradeApi.Application.Features.Products.Dtos;
using ETradeApi.Application.Services.Repositories;
using ETradeApi.Domain.Entities;
using MediatR;

namespace ETradeApi.Application.Features.Products.Commands.DeleteProduct
{
    public class DeleteProductCommand : IRequest<DeletedProductDto>
    {
        public int Id { get; set; }

        public class DeleteProductCommandHandler : IRequestHandler<DeleteProductCommand, DeletedProductDto>
        {
            private readonly IProductRepository _productRepository;
            private readonly IMapper _mapper;

            public DeleteProductCommandHandler(IProductRepository productRepository, IMapper mapper)
            {
                _productRepository = productRepository;
                _mapper = mapper;
            }

            public async Task<DeletedProductDto> Handle(DeleteProductCommand request, CancellationToken cancellationToken)
            {
                Product mappedProduct = _mapper.Map<Product>(request);
                Product deletedProduct = await _productRepository.DeleteAsync(mappedProduct);
                DeletedProductDto deletedProductDto = _mapper.Map<DeletedProductDto>(deletedProduct);
                return deletedProductDto;
            }
        }
    }
}
