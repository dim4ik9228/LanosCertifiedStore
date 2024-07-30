﻿using FluentValidation;

namespace LanosCertifiedStore.Application.Identity.Commands.UpdateUserSelfCommandRequestRelated;

internal sealed class UpdateUserSelfCommandRequestValidator : AbstractValidator<UpdateUserSelfCommandRequest>
{
    public UpdateUserSelfCommandRequestValidator()
    {
        RuleFor(x => x.PhoneNumber)
            .NotEmpty()
            .MinimumLength(4)
            .MaximumLength(32);

        RuleFor(x => x.FirstName)
            .NotEmpty()
            .MinimumLength(2)
            .MaximumLength(64);

        RuleFor(x => x.LastName)
            .NotEmpty()
            .MinimumLength(2)
            .MaximumLength(64);
    }
}