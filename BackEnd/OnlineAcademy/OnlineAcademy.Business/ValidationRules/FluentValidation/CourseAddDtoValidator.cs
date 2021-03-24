using FluentValidation;
using OnlineAcademy.Entities.Concrete;
using OnlineAcademy.Entities.Dtos.Add;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineAcademy.Business.ValidationRules.FluentValidation
{
    public class CourseAddDtoValidator : AbstractValidator<CourseAddDto>
    {
        public CourseAddDtoValidator()
        {
            RuleFor(c => c.Title).NotEmpty();
            RuleFor(c => c.Title).MinimumLength(5);
        }
    }
}
