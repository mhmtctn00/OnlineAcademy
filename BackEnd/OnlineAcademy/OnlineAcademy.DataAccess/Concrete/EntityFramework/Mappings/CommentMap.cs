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

            builder.HasKey(c => c.Id);
            builder.Property(c => c.Id).IsRequired().UseIdentityColumn();
            builder.Property(c => c.Title).IsRequired().HasMaxLength(150);
            builder.Property(c => c.Message).IsRequired();
            builder.Property(c => c.IsDeleted).IsRequired();
            builder.Property(c => c.CreatedDate).IsRequired();
            builder.Property(c => c.UserId).IsRequired();
            builder.Property(c => c.LessonId).IsRequired();

            builder.HasOne(c => c.User).WithMany(u => u.Comments).HasForeignKey(c => c.UserId);
            builder.HasOne(c => c.Lesson).WithMany(l => l.Comments).HasForeignKey(c => c.LessonId);

            builder.HasData(
                new Comment
                {
                    Id = 1,
                    Title = "Teşekkür",
                    Message = "Eğitim çok başarılı.",
                    IsDeleted = false,
                    CreatedDate = DateTime.Now,
                    UpdatedDate = null,
                    LessonId = 1,
                    UserId = 3
                },
                new Comment
                {
                    Id = 2,
                    Title = "Tebrik",
                    Message = "Tebrikler. Eğitim çok başarılı.",
                    IsDeleted = false,
                    CreatedDate = DateTime.Now,
                    UpdatedDate = null,
                    LessonId = 1,
                    UserId = 4
                }
                );
        }
    }
}
