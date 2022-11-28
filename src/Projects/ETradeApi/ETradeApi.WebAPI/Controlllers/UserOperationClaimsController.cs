using Core.Application.Requests;
using Microsoft.AspNetCore.Mvc;
using ETradeApi.WebAPI.Controllers;
using ETradeApi.Application.Features.UserOperationClaims.Queries.GetByIdUserOperationClaim;
using ETradeApi.Application.Features.UserOperationClaims.Dtos;
using ETradeApi.Application.Features.UserOperationClaims.Queries.GetListUserOperationClaim;
using ETradeApi.Application.Features.UserOperationClaims.Models;
using ETradeApi.Application.Features.UserOperationClaims.Commands.CreateUserOperationClaim;
using ETradeApi.Application.Features.UserOperationClaims.Commands.UpdateUserOperationClaim;
using ETradeApi.Application.Features.UserOperationClaims.Commands.DeleteUserOperationClaim;

namespace ETradeApi.WebAPI.Controlllers
{
    public class UserOperationClaimsController : BaseController
    {
        [HttpGet]
        public async Task<IActionResult> GetList([FromQuery] PageRequest pageRequest)
        {
            GetListUserOperationClaimQuery getListUserOperationClaimQuery = new() { PageRequest = pageRequest };
            UserOperationClaimListModel result = await Mediator.Send(getListUserOperationClaimQuery);
            return Ok(result);
        }

        [HttpPost]
        public async Task<IActionResult> Add([FromBody] CreateUserOperationClaimCommand createUserOperationClaimCommand)
        {
            CreatedUserOperationClaimDto result = await Mediator.Send(createUserOperationClaimCommand);
            return Created("", result);
        }

        [HttpPut]
        public async Task<IActionResult> Update([FromBody] UpdateUserOperationClaimCommand updateUserOperationClaimCommand)
        {
            UpdatedUserOperationClaimDto result = await Mediator.Send(updateUserOperationClaimCommand);
            return Ok(result);
        }

        [HttpDelete]
        public async Task<IActionResult> Delete([FromBody] DeleteUserOperationClaimCommand deleteUserOperationClaimCommand)
        {
            DeletedUserOperationClaimDto result = await Mediator.Send(deleteUserOperationClaimCommand);
            return Ok(result);
        }
    }
}
