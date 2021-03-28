using Core.Entities.Concrete;
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
    public class UserRoleMap : IEntityTypeConfiguration<UserRole>
    {
        public void Configure(EntityTypeBuilder<UserRole> builder)
        {
            builder.ToTable("UserRoles");

            builder.HasKey(ur => new { ur.UserId, ur.RoleId });
            builder.Property(ur => ur.UserId).IsRequired();
            builder.Property(ur => ur.RoleId).IsRequired();

            builder.HasOne(ur => ur.User).WithMany(u => u.UserRoles).HasForeignKey(ur => ur.UserId);
            builder.HasOne(ur => ur.Role).WithMany(r => r.UserRoles).HasForeignKey(ur => ur.RoleId);

            builder.HasData(
                new UserRole
                {
                    UserId = 1,
                    RoleId = 3
                },
                new UserRole
                {
                    UserId = 1,
                    RoleId = 4
                },
                new UserRole
                {
                    UserId = 2,
                    RoleId = 3
                },
                new UserRole
                {
                    UserId = 2,
                    RoleId = 4
                },
                new UserRole
                {
                    UserId = 3,
                    RoleId = 4
                },
                new UserRole
                {
                    UserId = 4,
                    RoleId = 4
                }
                );
        }
    }
}
