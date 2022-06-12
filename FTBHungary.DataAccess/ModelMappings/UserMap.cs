namespace FTBHungary.DataAccess.ModelMappings;

using Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

public class UserMap : IEntityTypeConfiguration<User>
{
    public void Configure(EntityTypeBuilder<User> builder)
    {
        builder.HasKey(k => k.Guid);
        builder.HasMany(h => h.UserRoles).WithOne(w => w.User)
            .HasForeignKey(k => k.UserGuid)
            .OnDelete(DeleteBehavior.Cascade);
    }
}