using Core.Application.Requests;
using ETradeApi.Application.Features.Brands.Dtos;
using ETradeApi.Application.Features.Products.Commands.CreateProduct;
using ETradeApi.Application.Features.Products.Commands.DeleteProduct;
using ETradeApi.Application.Features.Products.Commands.UpdateProduct;
using ETradeApi.Application.Features.Products.Dtos;
using ETradeApi.Application.Features.Products.Models;
using ETradeApi.Application.Features.Products.Queries.GetByIdProduct;
using ETradeApi.Application.Features.Products.Queries.GetListProduct;
using Microsoft.AspNetCore.Mvc;

namespace ETradeApi.WebAPI.Controlllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : BaseController
    {
        [HttpGet("{Id}")]
        public async Task<IActionResult> GetById([FromRoute] GetByIdProductQuery getByIdProductQuery)
        {
            GetByIdProductDto result = await Mediator.Send(getByIdProductQuery);
            return Ok(result);
        }

        [HttpGet]
        public async Task<IActionResult> GetList([FromQuery] PageRequest pageRequest)
        {
            GetListProductQuery getListProductQuery = new() { PageRequest = pageRequest };
            GetListProductModel result = await Mediator.Send(getListProductQuery);
            return Ok(result);
        }

        [HttpPost]
        public async Task<IActionResult> Add([FromBody] CreateProductCommand createProductCommand)
        {
            CreatedProductDto result = await Mediator.Send(createProductCommand);

            return Created("", result);
        }

        [HttpPut]
        public async Task<IActionResult> Update([FromBody] UpdateProductCommand updateProductCommand)
        {
            UpdatedProductDto result = await Mediator.Send(updateProductCommand);
            return Ok(result);
        }

        [HttpDelete("{Id}")]
        public async Task<IActionResult> Delete([FromRoute] DeleteProductCommand deleteProductCommand)
        {
            DeletedProductDto result = await Mediator.Send(deleteProductCommand);
            return Ok(result);
        }
    }
}
