using Core.Application.Requests;
using Microsoft.AspNetCore.Mvc;
using ETradeApi.WebAPI.Controllers;
using ETradeApi.Application.Features.Users.Queries.GetByIdUser;
using ETradeApi.Application.Features.Users.Dtos;
using ETradeApi.Application.Features.Users.Queries.GetListUser;
using ETradeApi.Application.Features.Users.Models;
using ETradeApi.Application.Features.Users.Commands.CreateUser;
using ETradeApi.Application.Features.Users.Commands.UpdateUser;
using ETradeApi.Application.Features.Users.Commands.UpdateUserFromAuth;
using ETradeApi.Application.Features.Users.Commands.DeleteUser;

namespace ETradeApi.WebAPI.Controlllers
{
    public class UsersController : BaseController
    {
        [HttpGet("{Id}")]
        public async Task<IActionResult> GetById([FromRoute] GetByIdUserQuery getByIdUserQuery)
        {
            UserDto result = await Mediator.Send(getByIdUserQuery);
            return Ok(result);
        }

        [HttpGet("GetFromAuth")]
        public async Task<IActionResult> GetFromAuth()
        {
            GetByIdUserQuery getByIdUserQuery = new() { Id = getUserIdFromRequest() };
            UserDto result = await Mediator.Send(getByIdUserQuery);
            return Ok(result);
        }

        [HttpGet]
        public async Task<IActionResult> GetList([FromQuery] PageRequest pageRequest)
        {
            GetListUserQuery getListUserQuery = new() { PageRequest = pageRequest };
            UserListModel result = await Mediator.Send(getListUserQuery);
            return Ok(result);
        }

        [HttpPost]
        public async Task<IActionResult> Add([FromBody] CreateUserCommand createUserCommand)
        {
            CreatedUserDto result = await Mediator.Send(createUserCommand);
            return Created("", result);
        }

        [HttpPut]
        public async Task<IActionResult> Update([FromBody] UpdateUserCommand updateUserCommand)
        {
            UpdatedUserDto result = await Mediator.Send(updateUserCommand);
            return Ok(result);
        }

        [HttpPut("FromAuth")]
        public async Task<IActionResult> UpdateFromAuth([FromBody] UpdateUserFromAuthCommand updateUserFromAuthCommand)
        {
            updateUserFromAuthCommand.Id = getUserIdFromRequest();
            UpdatedUserFromAuthDto result = await Mediator.Send(updateUserFromAuthCommand);
            return Ok(result);
        }

        [HttpDelete]
        public async Task<IActionResult> Delete([FromBody] DeleteUserCommand deleteUserCommand)
        {
            DeletedUserDto result = await Mediator.Send(deleteUserCommand);
            return Ok(result);
        }
    }
}
