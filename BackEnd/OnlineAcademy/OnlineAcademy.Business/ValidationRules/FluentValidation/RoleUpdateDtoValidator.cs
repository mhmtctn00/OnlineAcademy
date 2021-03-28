using FluentValidation;
using OnlineAcademy.Entities.Dtos.Update;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineAcademy.Business.ValidationRules.FluentValidation
{
    public class RoleUpdateDtoValidator : AbstractValidator<RoleUpdateDto>
    {
        public RoleUpdateDtoValidator()
        {
            RuleFor(r => r.Id).NotEmpty();
            RuleFor(r => r.Id).GreaterThan(0);
        }
    }
}
