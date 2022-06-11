namespace FTBHungary.Api.Controllers;

using Data.Dtos;
using Logic.IServices;
using Microsoft.AspNetCore.Mvc;

public class UserController : ControllerBase
{
    private readonly IUserService _userService;

    public UserController( IUserService userService)
    {
        _userService = userService;
    }

    [HttpPost("register")]
    public async Task<UserDto> Register(UserDto userDto)
    {
        var user = await _userService.Register(userDto);
        return user;
    }
}