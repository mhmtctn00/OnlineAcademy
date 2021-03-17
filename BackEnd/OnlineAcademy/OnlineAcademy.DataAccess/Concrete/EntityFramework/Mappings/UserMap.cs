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
    public class UserMap : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.ToTable("Users");

            builder.HasKey(u => u.Id);
            builder.Property(u => u.Id).IsRequired().UseIdentityColumn();
            builder.Property(u => u.Email).IsRequired().HasMaxLength(50);
            builder.Property(u => u.Password).IsRequired().HasMaxLength(20);
            builder.Property(u => u.Firstname).IsRequired().HasMaxLength(50);
            builder.Property(u => u.Lastname).IsRequired().HasMaxLength(50);
            builder.Property(u => u.CreatedDate).IsRequired();
            builder.Property(u => u.IsActive).IsRequired();

            /* EntityBase */
            builder.Property(u => u.Id).ValueGeneratedOnAdd();
            builder.Property(u => u.CreatedDate).IsRequired();
            builder.Property(u => u.CreatedByName).IsRequired();
            builder.Property(u => u.CreatedByName).HasMaxLength(50);
            builder.Property(u => u.ModifiedDate).IsRequired();
            builder.Property(u => u.ModifiedByName).IsRequired();
            builder.Property(u => u.ModifiedByName).HasMaxLength(50);
            builder.Property(u => u.IsActive).IsRequired();
            builder.Property(u => u.IsDeleted).IsRequired();
            builder.Property(u => u.IsModified).IsRequired();

            builder.HasData(
                new User
                {
                    Id = 1,
                    Email = "mhmt.cetin00@gmail.com",
                    Password = "123456",
                    Firstname = "Mehmet",
                    Lastname = "Çetin",
                    CreatedDate = DateTime.Now,
                    CreatedByName = "Initial Create",
                    ModifiedDate = null,
                    ModifiedByName = null,
                    IsActive = true,
                    IsDeleted = false,
                    IsModified = false
                },
                new User
                {
                    Id = 2,
                    Email = "mail@mail.com",
                    Password = "123456",
                    Firstname = "MailF",
                    Lastname = "MailL",
                    CreatedDate = DateTime.Now,
                    CreatedByName = "Initial Create",
                    ModifiedDate = null,
                    ModifiedByName = null,
                    IsActive = true,
                    IsDeleted = false,
                    IsModified = false

                },
                new User
                {
                    Id = 3,
                    Email = "student1@gmail.com",
                    Password = "123456",
                    Firstname = "student1F",
                    Lastname = "student1L",
                    CreatedDate = DateTime.Now,
                    CreatedByName = "Initial Create",
                    ModifiedDate = null,
                    ModifiedByName = null,
                    IsActive = true,
                    IsDeleted = false,
                    IsModified = false
                },
                new User
                {
                    Id = 4,
                    Email = "student2@mail.com",
                    Password = "123456",
                    Firstname = "student2F",
                    Lastname = "student2L",
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
