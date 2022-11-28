using ETradeApi.Application.Features.UserOperationClaims.Dtos;
using Core.Persistence.Paging;

namespace ETradeApi.Application.Features.UserOperationClaims.Models;

public class UserOperationClaimListModel : BasePageableModel
{
    public IList<UserOperationClaimListDto> Items { get; set; }
}