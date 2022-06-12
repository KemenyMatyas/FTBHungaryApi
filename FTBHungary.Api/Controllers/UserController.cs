namespace FTBHungary.Api.Controllers;

using Common.Dtos;
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
    public async Task<ApiResponseDto<bool>> Register(RegisterUserDto userDto)
    {

        var response = new ApiResponseDto<bool>();
        try
        {
            await _userService.Register(userDto);

            response.IsSuccess = true;
            response.Error = string.Empty;
            response.Data = true;

        }
        catch (Exception ex)
        {
            response.IsSuccess = false;
            response.Error = ex.Message;
            response.Data = false;
        }
        
        return response;
    }
    
    [HttpPost("login")]
    public async Task<ApiResponseDto<string>> Login(LoginUserDto userDto)
    {
        var response = new ApiResponseDto<string>();
        try
        {
            var res = await _userService.Login(userDto);
            if (res == null)
            {
                response.IsSuccess = false;
                response.Error = $"Nem sikerült a lekérni az elemeket";
                response.Data = null;
            }
            else
            {
                response.IsSuccess = true;
                response.Error = string.Empty;
                response.Data = res;
            }
        }
        catch (Exception ex)
        {
            response.IsSuccess = false;
            response.Error = ex.Message;
            response.Data = null;
        }

        return response;
    }
}