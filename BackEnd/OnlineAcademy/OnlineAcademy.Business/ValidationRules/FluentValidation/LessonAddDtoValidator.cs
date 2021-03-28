using FluentValidation;
using OnlineAcademy.Entities.Dtos.Add;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineAcademy.Business.ValidationRules.FluentValidation
{
    public class LessonAddDtoValidator : AbstractValidator<LessonAddDto>
    {
        public LessonAddDtoValidator()
        {
            RuleFor(l => l.SectionId).NotEmpty();
            RuleFor(l => l.SectionId).GreaterThan(0);
            RuleFor(l => l.Title).NotEmpty();
            RuleFor(l => l.Title).Length(10,100);
        }
    }
}
