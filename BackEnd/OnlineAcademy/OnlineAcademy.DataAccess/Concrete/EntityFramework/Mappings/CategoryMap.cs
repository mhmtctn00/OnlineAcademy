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

            builder.HasData(
                new Category
                {
                    Id = 1,
                    ParentId = null,
                    Name = "Yazılım Geliştirme"
                },
                new Category
                {
                    Id = 2,
                    ParentId = null,
                    Name = "İşletme"
                },
                new Category
                {
                    Id = 3,
                    ParentId = 1,
                    Name = "Web Geliştirme"
                },
                new Category
                {
                    Id = 4,
                    ParentId = 1,
                    Name = "Veri Bilimi"
                },
                new Category
                {
                    Id = 5,
                    ParentId = 3,
                    Name = "JavaScript"
                },
                new Category
                {
                    Id = 6,
                    ParentId = 3,
                    Name = "React"
                }
                );
        }
    }
}
