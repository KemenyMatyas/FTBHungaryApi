namespace FTBHungary.Logic.IServices;

using Data.Dtos;

public interface IUserService
{
    public Task<UserDto> Register(UserDto userDto);
}