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
    public class CourseMap : IEntityTypeConfiguration<Course>
    {
        public void Configure(EntityTypeBuilder<Course> builder)
        {
            builder.ToTable("Courses");

            builder.HasKey(c => c.Id);
            builder.Property(c => c.Id).IsRequired().UseIdentityColumn();
            builder.Property(c => c.Title).IsRequired().HasMaxLength(150);
            builder.Property(c => c.Description).IsRequired();
            builder.Property(c => c.CreatedDate).IsRequired();
            builder.Property(c => c.IsDeleted).IsRequired();

            builder.HasData(
                new Course
                {
                    Id = 1,
                    Title = "Sıfırdan İleri Seviye React Kursu!",
                    Description = "Bu kursta sıfırdan başlayarak ileri düzeyde React öğreneceksiniz.",
                    CreatedDate = DateTime.Now,
                    UpdatedDate = null,
                    IsDeleted = false,
                    IsActive = true
                },
                new Course
                {
                    Id = 2,
                    Title = "Sıfırdan İleri Seviye JavaScript Kursu!",
                    Description = "Bu kursta sıfırdan başlayarak ileri düzeyde JavaScript öğreneceksiniz.",
                    CreatedDate = DateTime.Now,
                    UpdatedDate = null,
                    IsDeleted = false,
                    IsActive = true
                }
                );

        }
    }
}
