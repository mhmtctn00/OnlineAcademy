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
    public class CourseCategoryMap : IEntityTypeConfiguration<CourseCategory>
    {
        public void Configure(EntityTypeBuilder<CourseCategory> builder)
        {
            builder.ToTable("CourseCategories");

            builder.HasKey(cc => new { cc.CourseId, cc.CategoryId });
            builder.Property(cc => cc.CourseId).IsRequired();
            builder.Property(cc => cc.CategoryId).IsRequired();

            builder.HasOne(cc => cc.Course).WithMany(c => c.CourseCategories).HasForeignKey(cc => cc.CourseId);
            builder.HasOne(cc => cc.Category).WithMany(c => c.CourseCategories).HasForeignKey(cc => cc.CategoryId);

            builder.HasData(
                new CourseCategory
                {
                    CourseId = 1,
                    CategoryId = 1
                },
                new CourseCategory
                {
                    CourseId = 1,
                    CategoryId = 3
                },
                new CourseCategory
                {
                    CourseId = 1,
                    CategoryId = 6
                },
                new CourseCategory
                {
                    CourseId = 2,
                    CategoryId = 1
                },
                new CourseCategory
                {
                    CourseId = 2,
                    CategoryId = 3
                },
                new CourseCategory
                {
                    CourseId = 2,
                    CategoryId = 5
                }
                );
        }
    }
}
