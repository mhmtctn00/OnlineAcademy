using FluentValidation;
using OnlineAcademy.Entities.Dtos.Add;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineAcademy.Business.ValidationRules.FluentValidation
{
    public class CategoryAddDtoValidator : AbstractValidator<CategoryAddDto>
    {
        public CategoryAddDtoValidator()
        {
            RuleFor(c => c.Name).NotEmpty();
            RuleFor(c => c.Name).MaximumLength(100);
        }
    }
}
