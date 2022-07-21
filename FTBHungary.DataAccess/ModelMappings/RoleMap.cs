namespace FTBHungary.DataAccess.ModelMappings;

using Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

public class RoleMap :  IEntityTypeConfiguration<Role>
{
    public void Configure(EntityTypeBuilder<Role> builder)
    {
        builder.HasKey(k => k.Guid);

        var list = new List<Role>();
        list.Add(new Role(){Name = "Admin"});
        list.Add(new Role(){Name = "User"});
        
        builder.HasData(list);
    }
}