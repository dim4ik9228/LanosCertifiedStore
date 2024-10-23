using System.Linq.Expressions;
using FluentValidation;

namespace LanosCertifiedStore.Application.VehicleBrands.Commands.UpdateVehicleBrandRelated;

internal sealed class UpdateVehicleBrandCommandRequestValidator : AbstractValidator<UpdateVehicleBrandCommandRequest>
{
    public UpdateVehicleBrandCommandRequestValidator()
    {
        GetNameLengthValidationRule(x => x.UpdatedName);
    }

    private void GetNameLengthValidationRule(Expression<Func<UpdateVehicleBrandCommandRequest, string>> expression)
    {
        RuleFor(expression)
            .NotEmpty()
            .MinimumLength(2)
            .MaximumLength(64)
            .WithMessage(VehicleBrandValidatorMessages.InvalidNameValue);
    }
}