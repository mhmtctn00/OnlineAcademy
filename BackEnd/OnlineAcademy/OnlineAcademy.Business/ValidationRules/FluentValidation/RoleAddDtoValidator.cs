using FluentValidation;
using OnlineAcademy.Entities.Dtos.Add;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineAcademy.Business.ValidationRules.FluentValidation
{
    public class RoleAddDtoValidator : AbstractValidator<RoleAddDto>
    {
        public RoleAddDtoValidator()
        {
            RuleFor(r => r.Name).NotEmpty();
            RuleFor(r => r.Name).MaximumLength(50);
        }
    }
}
