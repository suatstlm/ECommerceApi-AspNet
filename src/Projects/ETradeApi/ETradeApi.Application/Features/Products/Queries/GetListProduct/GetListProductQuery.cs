using AutoMapper;
using Core.Application.Requests;
using Core.Persistence.Paging;
using ETradeApi.Application.Features.Products.Models;
using ETradeApi.Application.Services.Repositories;
using ETradeApi.Domain.Entities;
using MediatR;

namespace ETradeApi.Application.Features.Products.Queries.GetListProduct
{
    public class GetListProductQuery : IRequest<GetListProductModel>
    {
        public PageRequest PageRequest { get; set; }

        public class GetLİstProductQueryHandler : IRequestHandler<GetListProductQuery, GetListProductModel>
        {
            private readonly IProductRepository _productRepository;
            private readonly IMapper _mapper;

            public GetLİstProductQueryHandler(IProductRepository productRepository, IMapper mapper)
            {
                _productRepository = productRepository;
                _mapper = mapper;
            }

            public async Task<GetListProductModel> Handle(GetListProductQuery request, CancellationToken cancellationToken)
            {
                IPaginate<Product> products = await _productRepository.GetListAsync(index: request.PageRequest.Page, size: request.PageRequest.PageSize);
                GetListProductModel mappedGetListProductModel = _mapper.Map<GetListProductModel>(products);
                return mappedGetListProductModel;
            }
        }
    }
}
