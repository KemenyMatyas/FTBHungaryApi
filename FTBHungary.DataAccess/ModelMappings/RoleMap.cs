namespace FTBHungary.DataAccess.ModelMappings;

using Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

public class RoleMap :  IEntityTypeConfiguration<Role>
{
    public void Configure(EntityTypeBuilder<Role> builder)
    {
        builder.HasKey(k => k.Guid);
        builder.HasMany(h => h.UserRoles).WithOne(w => w.Role)
            .HasForeignKey(k => k.RoleGuid)
            .OnDelete(DeleteBehavior.Cascade);
    }
}