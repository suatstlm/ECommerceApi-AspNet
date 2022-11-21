
namespace ETradeApi.Application.Features.Products.Dtos
{
    public class GetListProductDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Stock { get; set; }
        public float Price { get; set; }
    }
}
