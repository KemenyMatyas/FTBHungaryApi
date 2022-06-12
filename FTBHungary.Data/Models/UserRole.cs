namespace FTBHungary.Data.Models;

using Common.Models.Base;

public class UserRole : EntityBase
{
    public User User { get; set; }
    public Guid UserGuid { get; set; }
    public Guid RoleGuid { get; set; }
    public Role Role { get; set; }
}