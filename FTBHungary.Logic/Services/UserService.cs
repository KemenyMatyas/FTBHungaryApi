namespace FTBHungary.Logic.Services;

using Data.Dtos;
using Data.Models;
using DataAccess;
using IServices;

public class UserService : IUserService
{

    private readonly FTBHungaryContext _dbContext;

    public UserService(FTBHungaryContext dbContext)
    {
        _dbContext = dbContext;
    }
    
    public async Task<UserDto> Register(UserDto userDto)
    {
        _dbContext.Users.Add(new User() {Password = "test", Username = "test"});
        await _dbContext.SaveChangesAsync();
        
        return new UserDto() {Id = 1, Password = "asd", Username = "asd"};
    }
}