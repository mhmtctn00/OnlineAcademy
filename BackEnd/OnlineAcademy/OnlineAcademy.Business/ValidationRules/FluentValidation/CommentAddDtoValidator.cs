using FluentValidation;
using OnlineAcademy.Entities.Dtos.Add;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineAcademy.Business.ValidationRules.FluentValidation
{
    public class CommentAddDtoValidator : AbstractValidator<CommentAddDto>
    {
        public CommentAddDtoValidator()
        {
            RuleFor(c => c.UserId).NotEmpty();
            RuleFor(c => c.UserId).GreaterThan(0);
            RuleFor(c => c.LessonId).NotEmpty();
            RuleFor(c => c.LessonId).GreaterThan(0);
            RuleFor(c => c.Title).NotEmpty();
            RuleFor(c => c.Title).Length(10, 100);
            RuleFor(c => c.Message).NotEmpty();
            RuleFor(c => c.Message).MinimumLength(5);
        }
    }
}
