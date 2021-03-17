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

            builder.Property(c => c.Title).IsRequired().HasMaxLength(150);
            builder.Property(c => c.Description).IsRequired();
            builder.Property(c => c.CreatedDate).IsRequired();
            builder.Property(c => c.IsDeleted).IsRequired();

            /* EntityBase */
            builder.HasKey(eb => eb.Id);
            builder.Property(eb => eb.Id).IsRequired().UseIdentityColumn();
            builder.Property(eb => eb.CreatedDate).IsRequired();
            builder.Property(eb => eb.CreatedByName).IsRequired();
            builder.Property(eb => eb.CreatedByName).HasMaxLength(50);
            builder.Property(eb => eb.ModifiedDate).IsRequired();
            builder.Property(eb => eb.ModifiedByName).IsRequired();
            builder.Property(eb => eb.ModifiedByName).HasMaxLength(50);
            builder.Property(eb => eb.IsActive).IsRequired();
            builder.Property(eb => eb.IsDeleted).IsRequired();
            builder.Property(eb => eb.IsModified).IsRequired();

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
