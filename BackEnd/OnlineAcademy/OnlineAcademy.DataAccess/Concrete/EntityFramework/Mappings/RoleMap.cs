using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using OnlineAcademy.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineAcademy.DataAccess.Concrete.EntityFramework.Mappings
{
    public class RoleMap : IEntityTypeConfiguration<Role>
    {
        public void Configure(EntityTypeBuilder<Role> builder)
        {
            builder.ToTable("Roles");

            builder.HasKey(r => r.Id);
            builder.Property(r => r.Id).IsRequired().UseIdentityColumn();
            builder.Property(r => r.Name).IsRequired().HasMaxLength(20);

            /* EntityBase */
            builder.Property(r => r.Id).ValueGeneratedOnAdd();
            builder.Property(r => r.CreatedDate).IsRequired();
            builder.Property(r => r.CreatedByName).IsRequired();
            builder.Property(r => r.CreatedByName).HasMaxLength(50);
            builder.Property(r => r.ModifiedDate).IsRequired();
            builder.Property(r => r.ModifiedByName).IsRequired();
            builder.Property(r => r.ModifiedByName).HasMaxLength(50);
            builder.Property(r => r.IsActive).IsRequired();
            builder.Property(r => r.IsDeleted).IsRequired();
            builder.Property(r => r.IsModified).IsRequired();

            builder.HasData(
                new Role
                {
                    Id = 1,
                    Name = "Admin",
                    CreatedDate = DateTime.Now,
                    CreatedByName = "Initial Create",
                    ModifiedDate = null,
                    ModifiedByName = null,
                    IsActive = true,
                    IsDeleted = false,
                    IsModified = false
                },
                new Role
                {
                    Id = 2,
                    Name = "Moderator",
                    CreatedDate = DateTime.Now,
                    CreatedByName = "Initial Create",
                    ModifiedDate = null,
                    ModifiedByName = null,
                    IsActive = true,
                    IsDeleted = false,
                    IsModified = false
                },
                new Role
                {
                    Id = 3,
                    Name = "Teacher",
                    CreatedDate = DateTime.Now,
                    CreatedByName = "Initial Create",
                    ModifiedDate = null,
                    ModifiedByName = null,
                    IsActive = true,
                    IsDeleted = false,
                    IsModified = false
                },
                new Role
                {
                    Id = 4,
                    Name = "Student",
                    CreatedDate = DateTime.Now,
                    CreatedByName = "Initial Create",
                    ModifiedDate = null,
                    ModifiedByName = null,
                    IsActive = true,
                    IsDeleted = false,
                    IsModified = false
                }
                );
        }
    }
}
