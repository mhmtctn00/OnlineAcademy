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
    public class LessonMap : IEntityTypeConfiguration<Lesson>
    {
        public void Configure(EntityTypeBuilder<Lesson> builder)
        {
            builder.ToTable("Lessons");

            builder.Property(c => c.Title).IsRequired().HasMaxLength(150);
            builder.Property(l => l.Length).IsRequired();
            builder.Property(l => l.Video).IsRequired().HasMaxLength(200);
            builder.Property(l => l.SectionId).IsRequired();

            /* EntityBase */
            builder.HasKey(eb => eb.Id);
            builder.Property(eb => eb.Id).IsRequired().UseIdentityColumn();
            builder.Property(eb => eb.CreatedDate).IsRequired();
            builder.Property(eb => eb.CreatedByName).IsRequired();
            builder.Property(eb => eb.CreatedByName).HasMaxLength(50);
            builder.Property(eb => eb.ModifiedDate).IsRequired(false);
            builder.Property(eb => eb.ModifiedByName).IsRequired(false);
            builder.Property(eb => eb.ModifiedByName).HasMaxLength(50);
            builder.Property(eb => eb.IsActive).IsRequired();
            builder.Property(eb => eb.IsDeleted).IsRequired();
            builder.Property(eb => eb.IsModified).IsRequired();

            builder.HasOne(l => l.Section).WithMany(s => s.Lessons).HasForeignKey(l => l.SectionId);

            builder.HasData(
                new Lesson
                {
                    Id = 1,
                    Title = "Section 1 Lesson 1",
                    Length = 15,
                    Video = @"https://www.youtube.com/watch?v=w7ejDZ8SWv8&ab_channel=TraversyMedia",
                    SectionId = 1,
                    CreatedDate = DateTime.Now,
                    CreatedByName = "Initial Create",
                    ModifiedDate = null,
                    ModifiedByName = null,
                    IsActive = true,
                    IsDeleted = false,
                    IsModified = false
                },
                new Lesson
                {
                    Id = 2,
                    Title = "Section 1 Lesson 2",
                    Length = 23,
                    Video = @"https://www.youtube.com/watch?v=dGcsHMXbSOA&ab_channel=DevEd",
                    SectionId = 1,
                    CreatedDate = DateTime.Now,
                    CreatedByName = "Initial Create",
                    ModifiedDate = null,
                    ModifiedByName = null,
                    IsActive = true,
                    IsDeleted = false,
                    IsModified = false
                },
                new Lesson
                {
                    Id = 3,
                    Title = "Section 2 Lesson 1",
                    Length = 23,
                    Video = @"https://www.youtube.com/watch?v=Law7wfdg_ls&ab_channel=DevEd",
                    SectionId = 2,
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
