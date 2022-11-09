using ETradeApi.Application.Features.Models.Dtos;

namespace ETradeApi.Application.Features.Models.Models
{
    public class GetListModelModel
    {
        public IList<GetListModelDto> Items { get; set; }
    }
}
