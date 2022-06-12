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
        var role = new Role() {Name = "Admin"};
        var user = new User() {Password = "test2", UserName = "test2", FullName = "asd2"};
        var userRole = new UserRole() {Role = role, User = user};
        await _dbContext.Users.AddAsync(user);
        await _dbContext.UserRole.AddAsync(userRole);
        await _dbContext.SaveChangesAsync();
        
        return new UserDto() {Id = 1, Password = "asd", Username = "asd"};
    }
}