﻿using Application.Helpers.ValidationRelated.Common.Contracts;
using Domain.Contracts.RepositoryRelated.Common;
using Domain.Entities.VehicleRelated.Classes.TypeRelated;
using FluentValidation;

namespace Application.Commands.Types.VehicleEngineTypesRelated.CreateEngineType;

internal sealed class CreateEngineTypeCommandValidator : AbstractValidator<CreateEngineTypeCommand>
{
    public CreateEngineTypeCommandValidator(IUnitOfWork unitOfWork, IValidationHelper validationHelper)
    {
        RuleFor(x => x.Name)
            .NotEmpty()
            .MaximumLength(64)
            .MinimumLength(2)
            .WithMessage("Name must be greater than 2 characters and less than 64!");

        RuleFor(x => x.Name)
            .MustAsync(async (name, _) => 
                await validationHelper.IsAspectNameUnique<VehicleBodyType>(unitOfWork, name))
            .WithMessage("Type with such name already exists!");
    }
}