using FluentValidation;

namespace Application.Features.LectureLikes.Commands.Update;

public class UpdateLectureLikeCommandValidator : AbstractValidator<UpdateLectureLikeCommand>
{
    public UpdateLectureLikeCommandValidator()
    {
        RuleFor(c => c.Id).NotEmpty();
        RuleFor(c => c.UserId).NotEmpty();
        RuleFor(c => c.LectureId).NotEmpty();
    }
}