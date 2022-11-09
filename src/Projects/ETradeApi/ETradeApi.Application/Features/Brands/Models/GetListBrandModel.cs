using Core.Persistence.Paging;
using ETradeApi.Application.Features.Brands.Dtos;

namespace ETradeApi.Application.Features.Brands.Models
{
    public class GetListBrandModel: BasePageableModel
    {
        public IList<GetListBrandDto> Items { get; set; }
    }
}
