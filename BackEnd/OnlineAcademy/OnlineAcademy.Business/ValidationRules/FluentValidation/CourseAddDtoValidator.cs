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
            RuleFor(c => c.Title).Length(5, 100);
            RuleFor(c => c.Description).NotEmpty();
            RuleFor(c => c.Categories).NotEmpty();
            RuleFor(c => c.Price).NotEmpty();
            RuleFor(c => c.Price).GreaterThan(0);
        }
    }
}
