using Core.Application.Requests;
using Microsoft.AspNetCore.Mvc;
using ETradeApi.Application.Features.Brands.Commands.CreateBrand;
using ETradeApi.Application.Features.Brands.Commands.DeleteBrand;
using ETradeApi.Application.Features.Brands.Commands.UpdateBrand;
using ETradeApi.Application.Features.Brands.Dtos;
using ETradeApi.Application.Features.Brands.Models;
using ETradeApi.Application.Features.Brands.Queries.GetByIdBrand;
using ETradeApi.Application.Features.Brands.Queries.GetListBrand;

namespace ETradeApi.WebAPI.Controlllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BrandsController : BaseController
    {
        [HttpPost]
        public async Task<IActionResult> Add([FromBody] CreateBrandCommand createBrandEntityCommand)
        {
            CreatedBrandDto result = await Mediator.Send(createBrandEntityCommand);
            return Created("", result);
        }

        [HttpGet]
        public async Task<IActionResult> GetList([FromQuery] PageRequest pageRequest)
        {
            GetListBrandQuery getListBrandQuery = new() { PageRequest = pageRequest };
            GetListBrandModel result = await Mediator.Send(getListBrandQuery);
            return Ok(result);
        }

        [HttpGet("{Id}")]
        public async Task<IActionResult> GetById([FromRoute] GetByIdBrandQuery getByIdBrandQuery)
        {
            GetByIdBrandDto getByIdBrandDto = await Mediator.Send(getByIdBrandQuery);
            return Ok(getByIdBrandDto);
        }

        [HttpDelete("Remove")]
        public async Task<IActionResult> Remove([FromQuery] DeleteBrandCommand deleteBrandCommand)
        {
            DeletedBrandDto result = await Mediator.Send(deleteBrandCommand);
            return Ok(result);
        }

        [HttpPut("Update")]
        public async Task<IActionResult> Update([FromBody] UpdateBrandCommand updateBrandCommand)
        {
            UpdatedBrandDto result = await Mediator.Send(updateBrandCommand);
            return Ok(result);
        }

    }
}
