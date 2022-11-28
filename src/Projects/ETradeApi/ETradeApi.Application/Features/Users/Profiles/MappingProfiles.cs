using ETradeApi.Application.Features.Users.Commands.CreateUser;
using ETradeApi.Application.Features.Users.Commands.DeleteUser;
using ETradeApi.Application.Features.Users.Commands.UpdateUser;
using ETradeApi.Application.Features.Users.Commands.UpdateUserFromAuth;
using ETradeApi.Application.Features.Users.Dtos;
using ETradeApi.Application.Features.Users.Models;
using AutoMapper;
using Core.Persistence.Paging;
using Core.Security.Entities;

namespace ETradeApi.Application.Features.Users.Profiles;

public class MappingProfiles : Profile
{
    public MappingProfiles()
    {
        CreateMap<User, CreateUserCommand>().ReverseMap();
        CreateMap<User, CreatedUserDto>().ReverseMap();
        CreateMap<User, UpdateUserCommand>().ReverseMap();
        CreateMap<User, UpdatedUserDto>().ReverseMap();
        CreateMap<User, UpdateUserFromAuthCommand>().ReverseMap();
        CreateMap<User, UpdatedUserFromAuthDto>().ReverseMap();
        CreateMap<User, DeleteUserCommand>().ReverseMap();
        CreateMap<User, DeletedUserDto>().ReverseMap();
        CreateMap<User, UserDto>().ReverseMap();
        CreateMap<User, UserListDto>().ReverseMap();
        CreateMap<IPaginate<User>, UserListModel>().ReverseMap();
    }
}