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
    public class CourseStudentMap : IEntityTypeConfiguration<CourseStudent>
    {
        public void Configure(EntityTypeBuilder<CourseStudent> builder)
        {
            builder.ToTable("CourseStudents");

            builder.HasKey(cs => new { cs.CourseId, cs.UserId });
            builder.Property(cs => cs.CourseId).IsRequired();
            builder.Property(cs => cs.UserId).IsRequired();

            builder.HasOne(cs => cs.Course).WithMany(c => c.CourseStudents).HasForeignKey(cs => cs.CourseId);
            builder.HasOne(cs => cs.User).WithMany(u => u.CourseStudents).HasForeignKey(cs => cs.UserId);

            builder.HasData(
                new CourseStudent
                {
                    CourseId = 1,
                    UserId = 3
                },
                new CourseStudent
                {
                    CourseId = 1,
                    UserId = 4
                },
                new CourseStudent
                {
                    CourseId = 2,
                    UserId = 3
                }
                );
        }
    }
}
