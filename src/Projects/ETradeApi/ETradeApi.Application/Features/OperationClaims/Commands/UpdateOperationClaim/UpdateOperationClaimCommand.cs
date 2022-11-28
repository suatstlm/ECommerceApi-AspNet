using ETradeApi.Application.Features.OperationClaims.Dtos;
using ETradeApi.Application.Features.OperationClaims.Rules;
using ETradeApi.Application.Services.Repositories;
using AutoMapper;
using Core.Application.Pipelines.Authorization;
using Core.Security.Entities;
using MediatR;
using static ETradeApi.Application.Features.OperationClaims.Constants.OperationClaims;
using static ETradeApi.Domain.Constants.OperationClaims;

namespace ETradeApi.Application.Features.OperationClaims.Commands.UpdateOperationClaim;

public class UpdateOperationClaimCommand : IRequest<UpdatedOperationClaimDto>, ISecuredRequest
{
    public int Id { get; set; }
    public string Name { get; set; }

    public string[] Roles => new[] { Admin, OperationClaimAdmin, OperationClaimWrite, OperationClaimUpdate };

    public class
        UpdateOperationClaimCommandHandler : IRequestHandler<UpdateOperationClaimCommand, UpdatedOperationClaimDto>
    {
        private readonly IOperationClaimRepository _operationClaimRepository;
        private readonly IMapper _mapper;
        private readonly OperationClaimBusinessRules _operationClaimBusinessRules;

        public UpdateOperationClaimCommandHandler(IOperationClaimRepository operationClaimRepository, IMapper mapper,
                                                  OperationClaimBusinessRules operationClaimBusinessRules)
        {
            _operationClaimRepository = operationClaimRepository;
            _mapper = mapper;
            _operationClaimBusinessRules = operationClaimBusinessRules;
        }

        public async Task<UpdatedOperationClaimDto> Handle(UpdateOperationClaimCommand request,
                                                           CancellationToken cancellationToken)
        {
            OperationClaim mappedOperationClaim = _mapper.Map<OperationClaim>(request);
            OperationClaim updatedOperationClaim = await _operationClaimRepository.UpdateAsync(mappedOperationClaim);
            UpdatedOperationClaimDto updatedOperationClaimDto =
                _mapper.Map<UpdatedOperationClaimDto>(updatedOperationClaim);
            return updatedOperationClaimDto;
        }
    }
}