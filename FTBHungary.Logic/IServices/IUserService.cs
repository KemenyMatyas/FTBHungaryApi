namespace FTBHungary.Logic.IServices;

using Data.Dtos;

public interface IUserService
{
    public Task Register(RegisterUserDto userDto);
    public Task<string> Login(LoginUserDto userDto);
}