using Core.Application.Dtos;

namespace ETradeApi.Application.Features.Users.Dtos;

public class DeletedUserDto : IDto
{
    public int Id { get; set; }
}