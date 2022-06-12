namespace FTBHungary.DataAccess.ModelMappings;

using Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

public class UserRoleMap :  IEntityTypeConfiguration<UserRole>
{
    public void Configure(EntityTypeBuilder<UserRole> builder)
    {
        builder.HasKey(a => a.Guid);
        builder.HasIndex(a => new {a.UserGuid, a.RoleGuid}).IsUnique();
    }
}