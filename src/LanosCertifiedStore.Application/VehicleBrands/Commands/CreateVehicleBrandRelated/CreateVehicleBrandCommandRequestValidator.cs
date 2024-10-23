using System.Linq.Expressions;
using FluentValidation;

namespace LanosCertifiedStore.Application.VehicleBrands.Commands.CreateVehicleBrandRelated;

internal sealed class CreateVehicleBrandCommandRequestValidator : AbstractValidator<CreateVehicleBrandCommandRequest>
{
    public CreateVehicleBrandCommandRequestValidator()
    {
        GetNameLengthValidationRule(x => x.Name);
    }
    
    private void GetNameLengthValidationRule(Expression<Func<CreateVehicleBrandCommandRequest, string>> expression)
    {
        RuleFor(expression)
            .NotEmpty()
            .MinimumLength(2)
            .MaximumLength(64)
            .WithMessage(VehicleBrandValidatorMessages.InvalidNameValue);
    }
}