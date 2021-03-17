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
                new Course
                {
                    Id = 1,
                    Title = "Sıfırdan İleri Seviye React Kursu!",
                    Description = "Bu kursta sıfırdan başlayarak ileri düzeyde React öğreneceksiniz.",
                    CreatedDate = DateTime.Now,
                    CreatedByName = "Initial Create",
                    ModifiedDate = null,
                    ModifiedByName = null,
                    IsActive = true,
                    IsDeleted = false,
                    IsModified = false
                },
                new Course
                {
                    Id = 2,
                    Title = "Sıfırdan İleri Seviye JavaScript Kursu!",
                    Description = "Bu kursta sıfırdan başlayarak ileri düzeyde JavaScript öğreneceksiniz.",
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
