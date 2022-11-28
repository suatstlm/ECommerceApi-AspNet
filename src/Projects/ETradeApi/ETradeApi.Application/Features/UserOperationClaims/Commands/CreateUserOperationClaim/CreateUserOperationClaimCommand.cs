using ETradeApi.Application.Features.UserOperationClaims.Dtos;
using ETradeApi.Application.Features.UserOperationClaims.Rules;
using ETradeApi.Application.Services.Repositories;
using AutoMapper;
using Core.Application.Pipelines.Authorization;
using Core.Security.Entities;
using MediatR;
using static ETradeApi.Application.Features.UserOperationClaims.Constants.OperationClaims;
using static ETradeApi.Domain.Constants.OperationClaims;

namespace ETradeApi.Application.Features.UserOperationClaims.Commands.CreateUserOperationClaim;

public class CreateUserOperationClaimCommand : IRequest<CreatedUserOperationClaimDto>, ISecuredRequest
{
    public int UserId { get; set; }
    public int OperationClaimId { get; set; }

    public string[] Roles => new[] { Admin, UserOperationClaimAdmin, UserOperationClaimWrite, UserOperationClaimAdd };

    public class
        CreateUserOperationClaimCommandHandler : IRequestHandler<CreateUserOperationClaimCommand,
            CreatedUserOperationClaimDto>
    {
        private readonly IUserOperationClaimRepository _userOperationClaimRepository;
        private readonly IMapper _mapper;
        private readonly UserOperationClaimBusinessRules _userOperationClaimBusinessRules;

        public CreateUserOperationClaimCommandHandler(IUserOperationClaimRepository userOperationClaimRepository,
                                                      IMapper mapper,
                                                      UserOperationClaimBusinessRules userOperationClaimBusinessRules)
        {
            _userOperationClaimRepository = userOperationClaimRepository;
            _mapper = mapper;
            _userOperationClaimBusinessRules = userOperationClaimBusinessRules;
        }

        public async Task<CreatedUserOperationClaimDto> Handle(CreateUserOperationClaimCommand request,
                                                               CancellationToken cancellationToken)
        {
            UserOperationClaim mappedUserOperationClaim = _mapper.Map<UserOperationClaim>(request);
            UserOperationClaim createdUserOperationClaim =
                await _userOperationClaimRepository.AddAsync(mappedUserOperationClaim);
            CreatedUserOperationClaimDto createdUserOperationClaimDto =
                _mapper.Map<CreatedUserOperationClaimDto>(createdUserOperationClaim);
            return createdUserOperationClaimDto;
        }
    }
}