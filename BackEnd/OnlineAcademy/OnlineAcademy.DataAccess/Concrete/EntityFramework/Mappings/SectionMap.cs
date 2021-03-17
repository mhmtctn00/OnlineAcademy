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
    public class SectionMap : IEntityTypeConfiguration<Section>
    {
        public void Configure(EntityTypeBuilder<Section> builder)
        {
            builder.ToTable("Sections");

            builder.Property(s => s.Title).IsRequired().HasMaxLength(150);

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

            builder.HasOne(s => s.Course).WithMany(c => c.Sections).HasForeignKey(s => s.CorseId);

            builder.HasData(
                new Section
                {
                    Id = 1,
                    Title = "Course 1 Section 1",
                    CorseId = 1,
                    CreatedDate = DateTime.Now,
                    CreatedByName = "Initial Create",
                    ModifiedDate = null,
                    ModifiedByName = null,
                    IsActive = true,
                    IsDeleted = false,
                    IsModified = false
                },
                new Section
                {
                    Id = 2,
                    Title = "Course 1 Section 2",
                    CorseId = 1,
                    CreatedDate = DateTime.Now,
                    CreatedByName = "Initial Create",
                    ModifiedDate = null,
                    ModifiedByName = null,
                    IsActive = true,
                    IsDeleted = false,
                    IsModified = false
                },
                new Section
                {
                    Id = 3,
                    Title = "Course 2 Section 1",
                    CorseId = 2,
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
