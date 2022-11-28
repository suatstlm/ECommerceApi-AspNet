using ETradeApi.Application.Features.UserOperationClaims.Dtos;
using ETradeApi.Application.Features.UserOperationClaims.Rules;
using ETradeApi.Application.Services.Repositories;
using AutoMapper;
using Core.Application.Pipelines.Authorization;
using Core.Security.Entities;
using MediatR;
using static ETradeApi.Application.Features.UserOperationClaims.Constants.OperationClaims;
using static ETradeApi.Domain.Constants.OperationClaims;

namespace ETradeApi.Application.Features.UserOperationClaims.Commands.DeleteUserOperationClaim;

public class DeleteUserOperationClaimCommand : IRequest<DeletedUserOperationClaimDto>, ISecuredRequest
{
    public int Id { get; set; }

    public string[] Roles => new[] { Admin, UserOperationClaimAdmin, UserOperationClaimWrite, UserOperationClaimDelete };

    public class
        DeleteUserOperationClaimCommandHandler : IRequestHandler<DeleteUserOperationClaimCommand,
            DeletedUserOperationClaimDto>
    {
        private readonly IUserOperationClaimRepository _userOperationClaimRepository;
        private readonly IMapper _mapper;
        private readonly UserOperationClaimBusinessRules _userOperationClaimBusinessRules;

        public DeleteUserOperationClaimCommandHandler(IUserOperationClaimRepository userOperationClaimRepository,
                                                      IMapper mapper,
                                                      UserOperationClaimBusinessRules userOperationClaimBusinessRules)
        {
            _userOperationClaimRepository = userOperationClaimRepository;
            _mapper = mapper;
            _userOperationClaimBusinessRules = userOperationClaimBusinessRules;
        }

        public async Task<DeletedUserOperationClaimDto> Handle(DeleteUserOperationClaimCommand request,
                                                               CancellationToken cancellationToken)
        {
            await _userOperationClaimBusinessRules.UserOperationClaimIdShouldExistWhenSelected(request.Id);

            UserOperationClaim mappedUserOperationClaim = _mapper.Map<UserOperationClaim>(request);
            UserOperationClaim deletedUserOperationClaim =
                await _userOperationClaimRepository.DeleteAsync(mappedUserOperationClaim);
            DeletedUserOperationClaimDto deletedUserOperationClaimDto =
                _mapper.Map<DeletedUserOperationClaimDto>(deletedUserOperationClaim);
            return deletedUserOperationClaimDto;
        }
    }
}