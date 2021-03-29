using FluentValidation;
using OnlineAcademy.Entities.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineAcademy.Business.ValidationRules.FluentValidation
{
    public class UserLoginDtoValidator : AbstractValidator<UserLoginDto>
    {
        public UserLoginDtoValidator()
        {
            RuleFor(ul => ul.Email).NotEmpty();
            RuleFor(ul => ul.Email).MaximumLength(70);
            RuleFor(ul => ul.Password).NotEmpty();
        }
    }
}
