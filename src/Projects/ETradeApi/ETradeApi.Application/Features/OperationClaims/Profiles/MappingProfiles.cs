using ETradeApi.Application.Features.OperationClaims.Commands.CreateOperationClaim;
using ETradeApi.Application.Features.OperationClaims.Commands.DeleteOperationClaim;
using ETradeApi.Application.Features.OperationClaims.Commands.UpdateOperationClaim;
using ETradeApi.Application.Features.OperationClaims.Dtos;
using ETradeApi.Application.Features.OperationClaims.Models;
using AutoMapper;
using Core.Persistence.Paging;
using Core.Security.Entities;

namespace ETradeApi.Application.Features.OperationClaims.Profiles;

public class MappingProfiles : Profile
{
    public MappingProfiles()
    {
        CreateMap<OperationClaim, CreateOperationClaimCommand>().ReverseMap();
        CreateMap<OperationClaim, CreatedOperationClaimDto>().ReverseMap();
        CreateMap<OperationClaim, UpdateOperationClaimCommand>().ReverseMap();
        CreateMap<OperationClaim, UpdatedOperationClaimDto>().ReverseMap();
        CreateMap<OperationClaim, DeleteOperationClaimCommand>().ReverseMap();
        CreateMap<OperationClaim, DeletedOperationClaimDto>().ReverseMap();
        CreateMap<OperationClaim, OperationClaimDto>().ReverseMap();
        CreateMap<OperationClaim, OperationClaimListDto>().ReverseMap();
        CreateMap<IPaginate<OperationClaim>, OperationClaimListModel>().ReverseMap();
    }
}