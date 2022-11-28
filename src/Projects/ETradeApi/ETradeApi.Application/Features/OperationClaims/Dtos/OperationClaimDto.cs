using Core.Application.Dtos;

namespace ETradeApi.Application.Features.OperationClaims.Dtos;

public class OperationClaimDto : IDto
{
    public int Id { get; set; }
    public string Name { get; set; }
}