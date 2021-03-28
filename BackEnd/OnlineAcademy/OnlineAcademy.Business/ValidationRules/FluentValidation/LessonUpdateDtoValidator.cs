using FluentValidation;
using OnlineAcademy.Entities.Dtos.Update;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineAcademy.Business.ValidationRules.FluentValidation
{
    public class LessonUpdateDtoValidator:AbstractValidator<LessonUpdateDto>
    {
        public LessonUpdateDtoValidator()
        {
            RuleFor(l => l.Id).NotEmpty();
            RuleFor(l => l.Id).GreaterThan(0);
        }
    }
}
