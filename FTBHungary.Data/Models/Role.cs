namespace FTBHungary.Data.Models;

using Common.Models.Base;

public class Role : EntityBase
{
    public string Name { get; set; }
    public List<UserRole> UserRoles { get; set; }
}