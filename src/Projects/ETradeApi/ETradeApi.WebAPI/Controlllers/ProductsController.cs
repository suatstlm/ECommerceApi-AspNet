using ETradeApi.Application.Features.Products.Commands.CreateBrand;
using ETradeApi.Application.Features.Products.Dtos;
using Microsoft.AspNetCore.Mvc;

namespace ETradeApi.WebAPI.Controlllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : BaseController
    {
        [HttpPost]
        public async Task<IActionResult> Add([FromBody] CreateProductCommand createProductEntityCommand)
        {
            CreatedProductDto result = await Mediator.Send(createProductEntityCommand);
            return Created("", result);
        }
    }
}
