using AutoMapper;
using Core.Application.Requests;
using Core.Persistence.Dynamic;
using Core.Persistence.Paging;
using MediatR;
using Microsoft.EntityFrameworkCore;
using ETradeApi.Application.Features.Models.Models;
using ETradeApi.Application.Services.Repositories;
using ETradeApi.Domain.Entities;

namespace ETradeApi.Application.Features.Models.Queries.GetListModelByDynamic
{
    public class GetListModelByDynamicQuery: IRequest<GetListModelModel>
    {
        public Dynamic Dynamic { get; set; }
        public PageRequest PageRequest { get; set; }

        public class GetListModelByDynamicQueryHanler : IRequestHandler<GetListModelByDynamicQuery, GetListModelModel>
        {
            private readonly IModelRepository _modelRepository;
            private readonly IMapper _mapper;

            public GetListModelByDynamicQueryHanler(IModelRepository modelRepository, IMapper mapper)
            {
                _modelRepository = modelRepository;
                _mapper = mapper;
            }

            public async Task<GetListModelModel> Handle(GetListModelByDynamicQuery request, CancellationToken cancellationToken)
            {
                IPaginate<Model> models = await _modelRepository.GetListByDynamicAsync(request.Dynamic, include:
                                              m => m.Include(c => c.Brand),
                                              index: request.PageRequest.Page,
                                              size: request.PageRequest.PageSize
                                              );

                GetListModelModel model = _mapper.Map<GetListModelModel>(models);
                return model;

            }
        }
    }
}
