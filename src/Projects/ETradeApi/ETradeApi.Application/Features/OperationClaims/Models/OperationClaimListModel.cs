using ETradeApi.Application.Features.OperationClaims.Dtos;
using Core.Persistence.Paging;

namespace ETradeApi.Application.Features.OperationClaims.Models;

public class OperationClaimListModel : BasePageableModel
{
    public IList<OperationClaimListDto> Items { get; set; }
}