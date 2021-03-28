using FluentValidation;
using OnlineAcademy.Entities.Dtos.Add;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineAcademy.Business.ValidationRules.FluentValidation
{
    public class SectionAddDtoValidator : AbstractValidator<SectionAddDto>
    {
        public SectionAddDtoValidator()
        {
            RuleFor(s => s.CorseId).NotEmpty();
            RuleFor(s => s.CorseId).GreaterThan(0);
            RuleFor(s => s.Title).NotEmpty();
            RuleFor(s => s.Title).Length(10, 100);
        }
    }
}
