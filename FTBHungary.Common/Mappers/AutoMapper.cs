namespace Common.Mappers;

using FTBHungary.Data.Dtos;
using FTBHungary.Data.Models;
using global::AutoMapper;

public class AutoMapper : Profile
{
    public AutoMapper()
    {
        CreateMap<User, RegisterUserDto>().ReverseMap();
    }
}