using FluentValidation;
using OnlineAcademy.Entities.Dtos.Add;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineAcademy.Business.ValidationRules.FluentValidation
{
    public class UserAddDtoValidator : AbstractValidator<UserAddDto>
    {
        public UserAddDtoValidator()
        {
            RuleFor(u => u.Email).NotEmpty();
            RuleFor(u => u.Email).MaximumLength(70);
            RuleFor(u => u.Email).EmailAddress();
            RuleFor(u => u.Firstname).NotEmpty();
            RuleFor(u => u.Firstname).MaximumLength(50);
            RuleFor(u => u.Lastname).NotEmpty();
            RuleFor(u => u.Lastname).MaximumLength(50);
            RuleFor(u => u.PasswordSalt).NotEmpty();
            RuleFor(u => u.PasswordHash).NotEmpty();
        }
    }
}
