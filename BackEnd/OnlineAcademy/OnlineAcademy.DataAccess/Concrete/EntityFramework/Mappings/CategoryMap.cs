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
    public class CategoryMap : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.ToTable("Categories");

            builder.HasKey(c => c.Id);
            builder.Property(c => c.Id).IsRequired().UseIdentityColumn();
            builder.Property(c => c.Name).IsRequired().HasMaxLength(50);

            /* EntityBase */
            builder.Property(c => c.Id).ValueGeneratedOnAdd();
            builder.Property(c => c.CreatedDate).IsRequired();
            builder.Property(c => c.CreatedByName).IsRequired();
            builder.Property(c => c.CreatedByName).HasMaxLength(50);
            builder.Property(c => c.ModifiedDate).IsRequired();
            builder.Property(c => c.ModifiedByName).IsRequired();
            builder.Property(c => c.ModifiedByName).HasMaxLength(50);
            builder.Property(c => c.IsActive).IsRequired();
            builder.Property(c => c.IsDeleted).IsRequired();
            builder.Property(c => c.IsModified).IsRequired();

            builder.HasData(
                new Category
                {
                    Id = 1,
                    ParentId = null,
                    Name = "Yazılım Geliştirme",
                    CreatedDate = DateTime.Now,
                    CreatedByName = "Initial Create",
                    ModifiedDate = null,
                    ModifiedByName = null,
                    IsActive = true,
                    IsDeleted = false,
                    IsModified = false
                },
                new Category
                {
                    Id = 2,
                    ParentId = null,
                    Name = "İşletme",
                    CreatedDate = DateTime.Now,
                    CreatedByName = "Initial Create",
                    ModifiedDate = null,
                    ModifiedByName = null,
                    IsActive = true,
                    IsDeleted = false,
                    IsModified = false
                },
                new Category
                {
                    Id = 3,
                    ParentId = 1,
                    Name = "Web Geliştirme",
                    CreatedDate = DateTime.Now,
                    CreatedByName = "Initial Create",
                    ModifiedDate = null,
                    ModifiedByName = null,
                    IsActive = true,
                    IsDeleted = false,
                    IsModified = false
                },
                new Category
                {
                    Id = 4,
                    ParentId = 1,
                    Name = "Veri Bilimi",
                    CreatedDate = DateTime.Now,
                    CreatedByName = "Initial Create",
                    ModifiedDate = null,
                    ModifiedByName = null,
                    IsActive = true,
                    IsDeleted = false,
                    IsModified = false
                },
                new Category
                {
                    Id = 5,
                    ParentId = 3,
                    Name = "JavaScript",
                    CreatedDate = DateTime.Now,
                    CreatedByName = "Initial Create",
                    ModifiedDate = null,
                    ModifiedByName = null,
                    IsActive = true,
                    IsDeleted = false,
                    IsModified = false
                },
                new Category
                {
                    Id = 6,
                    ParentId = 3,
                    Name = "React",
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
