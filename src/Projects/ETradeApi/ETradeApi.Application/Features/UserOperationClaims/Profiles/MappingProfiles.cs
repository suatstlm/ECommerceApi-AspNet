using ETradeApi.Application.Features.UserOperationClaims.Commands.CreateUserOperationClaim;
using ETradeApi.Application.Features.UserOperationClaims.Commands.DeleteUserOperationClaim;
using ETradeApi.Application.Features.UserOperationClaims.Commands.UpdateUserOperationClaim;
using ETradeApi.Application.Features.UserOperationClaims.Dtos;
using ETradeApi.Application.Features.UserOperationClaims.Models;
using AutoMapper;
using Core.Persistence.Paging;
using Core.Security.Entities;

namespace ETradeApi.Application.Features.UserOperationClaims.Profiles;

public class MappingProfiles : Profile
{
    public MappingProfiles()
    {
        CreateMap<UserOperationClaim, CreateUserOperationClaimCommand>().ReverseMap();
        CreateMap<UserOperationClaim, CreatedUserOperationClaimDto>().ReverseMap();
        CreateMap<UserOperationClaim, UpdateUserOperationClaimCommand>().ReverseMap();
        CreateMap<UserOperationClaim, UpdatedUserOperationClaimDto>().ReverseMap();
        CreateMap<UserOperationClaim, DeleteUserOperationClaimCommand>().ReverseMap();
        CreateMap<UserOperationClaim, DeletedUserOperationClaimDto>().ReverseMap();
        CreateMap<UserOperationClaim, UserOperationClaimDto>().ReverseMap();
        CreateMap<UserOperationClaim, UserOperationClaimListDto>().ReverseMap();
        CreateMap<IPaginate<UserOperationClaim>, UserOperationClaimListModel>().ReverseMap();
    }
}