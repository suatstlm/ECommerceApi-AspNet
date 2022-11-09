using AutoMapper;
using MediatR;
using ETradeApi.Application.Features.Brands.Dtos;
using ETradeApi.Application.Features.Brands.Rules;
using ETradeApi.Application.Services.Repositories;
using ETradeApi.Domain.Entities;

namespace ETradeApi.Application.Features.Brands.Queries.GetByIdBrand
{
    public class GetByIdBrandQuery: IRequest<GetByIdBrandDto>
    {
        public int Id { get; set; }

        public class GetByIdBrandQueryHandler : IRequestHandler<GetByIdBrandQuery, GetByIdBrandDto>
        {
            private readonly IBrandRepository _brandRepository;
            private readonly IMapper _mapper;
            private readonly BrandBusinessRules _brandBusinessRules;

            public GetByIdBrandQueryHandler(IBrandRepository brandRepository, IMapper mapper, BrandBusinessRules brandBusinessRules)
            {
                _brandRepository = brandRepository;
                _mapper = mapper;
                _brandBusinessRules = brandBusinessRules;
            }

            public async Task<GetByIdBrandDto> Handle(GetByIdBrandQuery request, CancellationToken cancellationToken)
            {
                Brand? brand = await _brandRepository.GetAsync(b => b.Id == request.Id);
                _brandBusinessRules.BrandSouldExistWhenRequested(brand);

                GetByIdBrandDto mappedGetByIdBrandDto = _mapper.Map<GetByIdBrandDto>(brand);
                return mappedGetByIdBrandDto;
            }
        }
    }
}
