using FluentValidation;
using OnlineAcademy.Entities.Dtos.Update;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineAcademy.Business.ValidationRules.FluentValidation
{
    public class SectionUpdateDtoValidator : AbstractValidator<SectionUpdateDto>
    {
        public SectionUpdateDtoValidator()
        {
            RuleFor(s => s.Id).NotEmpty();
            RuleFor(s => s.Id).GreaterThan(0);
        }
    }
}
