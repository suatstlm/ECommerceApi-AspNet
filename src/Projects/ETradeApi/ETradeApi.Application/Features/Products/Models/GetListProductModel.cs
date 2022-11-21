using Core.Persistence.Paging;
using ETradeApi.Application.Features.Products.Dtos;

namespace ETradeApi.Application.Features.Products.Models
{
    public class GetListProductModel : BasePageableModel
    {
        public IList<GetListProductDto> Items { get; set; }
    }
}
