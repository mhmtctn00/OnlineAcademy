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
    public class CourseTeacherMap : IEntityTypeConfiguration<CourseInstructor>
    {
        public void Configure(EntityTypeBuilder<CourseInstructor> builder)
        {
            builder.ToTable("CourseTeachers");

            builder.HasKey(cs => new { cs.CourseId, cs.UserId });
            builder.Property(cs => cs.CourseId).IsRequired();
            builder.Property(cs => cs.UserId).IsRequired();

            builder.HasOne(cs => cs.Course).WithMany(c => c.CourseInstructors).HasForeignKey(cs => cs.CourseId);
            builder.HasOne(cs => cs.User).WithMany(u => u.CourseInstructors).HasForeignKey(cs => cs.UserId);

            builder.HasData(
                new CourseStudent
                {
                    CourseId = 1,
                    UserId = 1
                },
                new CourseStudent
                {
                    CourseId = 1,
                    UserId = 2
                },
                new CourseStudent
                {
                    CourseId = 2,
                    UserId = 1
                }
                );
        }
    }
}
