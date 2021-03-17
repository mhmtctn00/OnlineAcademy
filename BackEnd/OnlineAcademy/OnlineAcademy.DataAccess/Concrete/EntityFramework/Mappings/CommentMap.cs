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
    public class CommentMap : IEntityTypeConfiguration<Comment>
    {
        public void Configure(EntityTypeBuilder<Comment> builder)
        {
            builder.ToTable("Comments");

            builder.Property(c => c.Title).IsRequired().HasMaxLength(150);
            builder.Property(c => c.Message).IsRequired();
            builder.Property(c => c.IsDeleted).IsRequired();
            builder.Property(c => c.CreatedDate).IsRequired();
            builder.Property(c => c.UserId).IsRequired();
            builder.Property(c => c.LessonId).IsRequired();

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

            builder.HasOne(c => c.User).WithMany(u => u.Comments).HasForeignKey(c => c.UserId);
            builder.HasOne(c => c.Lesson).WithMany(l => l.Comments).HasForeignKey(c => c.LessonId);

            builder.HasData(
                new Comment
                {
                    Id = 1,
                    Title = "Teşekkür",
                    Message = "Eğitim çok başarılı.",
                    LessonId = 1,
                    UserId = 3,
                    CreatedDate = DateTime.Now,
                    CreatedByName = "Initial Create",
                    ModifiedDate = null,
                    ModifiedByName = null,
                    IsActive = true,
                    IsDeleted = false,
                    IsModified = false
                },
                new Comment
                {
                    Id = 2,
                    Title = "Tebrik",
                    Message = "Tebrikler. Eğitim çok başarılı.",
                    LessonId = 1,
                    UserId = 4,
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
